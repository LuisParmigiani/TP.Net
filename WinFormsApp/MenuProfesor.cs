using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using DTOs;

namespace WinFormsApp
{
    public partial class MenuProfesor : Form
    {
        // Cliente HTTP para llamadas a la API
        private readonly HttpClient _httpClient;
        private readonly int profesorId;

        // Diccionario que puede almacenar notas temporales por Id de alumno
        private Dictionary<int, int?> notasPorAlumno = new();
        private List<CursoDTO> ListaCursos = new();
        private List<PersonaDTO> ListaAlumnos = new();
        private int ListaCursoseleccionadoId;

        /// <summary>
        /// Constructor del formulario MenuProfesor.
        /// </summary>
        /// <param name="IdProfesor">Id del profesor que usa el formulario.</param>
        public MenuProfesor(int IdProfesor)
        {
            InitializeComponent();

            profesorId = IdProfesor;
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5183") };

            if (dgvListaCursos != null)
            {
                dgvListaCursos.CellContentClick += DgvListaCursos_CellContentClick;
                dgvListaCursos.CellClick += DgvListaCursos_CellContentClick;
            }

            if (dgvListaAlumnos != null)
            {
                dgvListaAlumnos.CellContentClick += DgvListaAlumnos_CellContentClick;
                dgvListaAlumnos.CellClick += DgvListaAlumnos_CellContentClick;
            }

            if (btnVolver != null) btnVolver.Click += BtnVolver_Click;

            // Mostrar panel inicial y cargar datos
            MostrarPanelCursos();
            _ = CargarCursosAsync();
        }

        /// <summary>
        /// Muestra el panel de cursos y oculta la vista de alumnos.
        /// </summary>
        private void MostrarPanelCursos()
        {
            if (pnlCursos != null) pnlCursos.Visible = true;
            if (pnlAlumnos != null) pnlAlumnos.Visible = false;
            if (lblAviso != null) lblAviso.Visible = false;
        }

        /// <summary>
        /// Muestra el panel de alumnos y oculta la lista de cursos.
        /// </summary>
        private void MostrarPanelAlumnos()
        {
            if (pnlCursos != null) pnlCursos.Visible = false;
            if (pnlAlumnos != null) pnlAlumnos.Visible = true;
            if (lblAviso != null) lblAviso.Visible = false;
        }

        private async Task CargarCursosAsync()
        {
            try
            {
                dgvListaCursos?.Rows.Clear();
                var cursos = await _httpClient.GetFromJsonAsync<List<CursoDTO>>("/cursos");
                ListaCursos = cursos ?? new List<CursoDTO>();

                foreach (var curso in ListaCursos)
                {
                    dgvListaCursos?.Rows.Add(curso.Id, curso.Descripcion, curso.AnioCalendario, curso.IdComision);
                    var idx = dgvListaCursos?.Rows.Count - 1 ?? -1;
                    if (idx >= 0) dgvListaCursos.Rows[idx].Tag = curso.Id;
                }

                if (ListaCursos.Count == 0)
                {
                    MostrarAviso("No se encontraron cursos disponibles.");
                }
            }
            catch (HttpRequestException ex)
            {
                MostrarAviso("No se pudo conectar con la API de cursos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MostrarAviso("Error al obtener cursos: " + ex.Message);
            }
        }

        private async Task CargarAlumnosAsync(int cursoId)
        {
            try
            {
                dgvListaAlumnos?.Rows.Clear();
                var alumnos = await _httpClient.GetFromJsonAsync<List<PersonaDTO>>("/personas");
                ListaAlumnos = alumnos ?? new List<PersonaDTO>();

                foreach (var a in ListaAlumnos)
                {
                    dgvListaAlumnos?.Rows.Add(a.Legajo, a.Nombre + " " + a.Apellido, string.Empty);
                    var idx = dgvListaAlumnos?.Rows.Count - 1 ?? -1;
                    if (idx >= 0) dgvListaAlumnos.Rows[idx].Tag = a.Id;
                }

                if (ListaAlumnos.Count == 0)
                {
                    MostrarAviso("No se encontraron alumnos.");
                }
            }
            catch (HttpRequestException ex)
            {
                MostrarAviso("No se pudo conectar con la API de personas: " + ex.Message);
            }
            catch (Exception ex)
            {
                MostrarAviso("Error al obtener alumnos: " + ex.Message);
            }
        }

        /// <summary>
        /// Manejador para clicks en el DataGridView de cursos.
        /// Detecta clicks en la columna de botón "Ver Alumnos" y abre la vista de alumnos.
        /// Soporta tanto CellContentClick como CellClick.
        /// </summary>
        private void DgvListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isButtonClick = false;

            // Intentar localizar columna por nombre
            var botonCol = dgvListaCursos.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "ColVerAlumnos");
            if (botonCol != null)
            {
                isButtonClick = e.ColumnIndex == botonCol.Index;
            }
            else
            {
                // Fallback: si la columna clickeada es de tipo botón, considerarlo
                isButtonClick = dgvListaCursos.Columns[e.ColumnIndex] is DataGridViewButtonColumn;
            }

            if (!isButtonClick) return;

            var row = dgvListaCursos.Rows[e.RowIndex];
            int cursoId = 0;
            if (row.Tag is int cid) cursoId = cid;
            else if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int parsed)) cursoId = parsed;

            if (cursoId > 0)
            {
                ListaCursoseleccionadoId = cursoId;
                // Cargar alumnos y mostrar panel
                _ = CargarAlumnosAsync(cursoId);
                MostrarPanelAlumnos();
            }
        }

        /// <summary>
        /// Manejador para clicks en el DataGridView de alumnos.
        /// Detecta clicks en la columna de botón "Guardar" y guarda la nota.
        /// Soporta tanto CellContentClick como CellClick.
        /// </summary>
        private async void DgvListaAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isButtonClick = false;
            var botonGuardar = dgvListaAlumnos.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "ColGuardarNota");
            if (botonGuardar != null)
            {
                isButtonClick = e.ColumnIndex == botonGuardar.Index;
            }
            else
            {
                isButtonClick = dgvListaAlumnos.Columns[e.ColumnIndex] is DataGridViewButtonColumn;
            }

            if (!isButtonClick) return;

            var row = dgvListaAlumnos.Rows[e.RowIndex];
            int alumnoId = 0;
            if (row.Tag is int aid) alumnoId = aid;
            else if (int.TryParse(row.Cells["Legajo"].Value?.ToString(), out int parsed)) alumnoId = parsed;

            var notaStr = row.Cells["Nota"].Value?.ToString();
            if (!int.TryParse(notaStr, out int notaVal))
            {
                // si vacío, tomar 0 (regular)
                notaVal = 0;
            }

            if (alumnoId > 0)
            {
                await SubirNotaAsync(alumnoId, notaVal);
            }
        }

        private async Task SubirNotaAsync(int idAlumno, int notaValor)
        {
            // Validación local de la nota
            if (notaValor != -1 && notaValor != 0 && !(notaValor >= 6 && notaValor <= 10))
            {
                MostrarAviso("Nota no válida");
                return;
            }

            try
            {
                InscripcionDTO inscripcionDTO;
                if (notaValor == 0)
                {
                    inscripcionDTO = new InscripcionDTO
                    {
                        Id = 4,
                        IdAlumno = idAlumno,
                        IdCurso = ListaCursoseleccionadoId,
                        Nota = 0,
                        Condicion = "regular"
                    };
                }
                else if (notaValor == -1)
                {
                    inscripcionDTO = new InscripcionDTO
                    {
                        Id = 4,
                        IdAlumno = idAlumno,
                        IdCurso = ListaCursoseleccionadoId,
                        Nota = 0,
                        Condicion = "libre"
                    };
                }
                else
                {
                    inscripcionDTO = new InscripcionDTO
                    {
                        Id = 4,
                        IdAlumno = idAlumno,
                        IdCurso = ListaCursoseleccionadoId,
                        Nota = notaValor,
                        Condicion = "aprobado"
                    };
                }

                var resp = await _httpClient.PutAsJsonAsync($"/inscripciones/6", inscripcionDTO);
                if (resp.IsSuccessStatusCode)
                {
                    MostrarAviso("Nota subida con éxito");
                    notasPorAlumno.Remove(idAlumno);
                    await CargarAlumnosAsync(ListaCursoseleccionadoId);
                    MostrarPanelAlumnos();
                }
                else
                {
                    var err = await resp.Content.ReadAsStringAsync();
                    MostrarAviso($"Error al subir la nota: {(int)resp.StatusCode} {resp.ReasonPhrase} - {err}");
                }
            }
            catch (HttpRequestException ex)
            {
                MostrarAviso("No se pudo conectar con la API de inscripciones: " + ex.Message);
            }
            catch (Exception ex)
            {
                MostrarAviso("Error al subir la nota: " + ex.Message);
            }
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MostrarPanelCursos();
        }

        private System.Windows.Forms.Timer _msgTimer;

        private void MostrarAviso(string texto, int milliseconds = 4000)
        {
            if (lblAviso == null) return;
            lblAviso.Text = texto;
            lblAviso.Visible = true;

            if (_msgTimer == null)
            {
                _msgTimer = new System.Windows.Forms.Timer();
                _msgTimer.Tick += (s, e) => { lblAviso.Visible = false; _msgTimer.Stop(); };
            }

            _msgTimer.Interval = milliseconds;
            _msgTimer.Start();
        }

        private void dgvListaCursos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
