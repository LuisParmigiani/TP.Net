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
        private List<AlumnoInscripcion> ListaAlumnos = new();
        private int ListaCursoseleccionadoId;

        // evita cargas concurrentes que provoquen duplicados
        private bool _isLoadingCursos = false;
        private bool _isLoadingAlumnos = false;

        // helper para almacenar ids por fila
        private record RowIds(int AlumnoId, int InscripcionId);


        /// <summary>
        /// Constructor del formulario MenuProfesor.
        /// </summary>
        /// <param name="IdProfesor">Id del profesor que usa el formulario.</param>
        public MenuProfesor(int IdProfesor)
        {
            InitializeComponent();

            profesorId = IdProfesor;
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5183") };

            // No suscribimos CellClick para evitar llamadas duplicadas.
            // El diseñador ya asoció dgvListaCursos.CellContentClick a dgvListaCursos_CellContentClick_1.
            if (dgvListaAlumnos != null)
            {
                // Suscribir sólo a CellContentClick para manejar clicks sobre el botón "Guardar"
                dgvListaAlumnos.CellContentClick -= DgvListaAlumnos_CellContentClick; // quitar por si acaso
                dgvListaAlumnos.CellContentClick += DgvListaAlumnos_CellContentClick;
            }

            if (btnVolver != null) btnVolver.Click -= BtnVolver_Click; btnVolver.Click += BtnVolver_Click;

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
            if (_isLoadingCursos) return;
            _isLoadingCursos = true;

            try
            {
                dgvListaCursos?.Rows.Clear();
                var cursos = await _httpClient.GetFromJsonAsync<List<CursoDTO>>($"/cursos/Byprofesor/{profesorId}");
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
            finally
            {
                _isLoadingCursos = false;
            }
        }

        private async Task CargarAlumnosAsync(int cursoId)
        {
            if (_isLoadingAlumnos) return;
            _isLoadingAlumnos = true;

            try
            {
                dgvListaAlumnos?.Rows.Clear();
                var alumnos = await _httpClient.GetFromJsonAsync<List<AlumnoInscripcion>>($"/alumnos/{cursoId}");
                ListaAlumnos = alumnos ?? new List<AlumnoInscripcion>();

                // Deduplicar por IdInscripcion (evita filas repetidas si el endpoint devuelve duplicados)
                var distinctAlumnos = ListaAlumnos
                    .GroupBy(a => a.IdInscripcion)
                    .Select(g => g.First())
                    .ToList();

                // Evitar que se procese accidentalmente un click mientras añadimos filas
                dgvListaAlumnos.CellContentClick -= DgvListaAlumnos_CellContentClick;

                foreach (var a in distinctAlumnos)
                {
                    // Mostrar Legajo, Nombre y Nota
                    dgvListaAlumnos?.Rows.Add(a.LegajoAlumno, a.NombreAlumno + " " + a.ApellidoAlumno, a.Nota);
                    var idx = dgvListaAlumnos?.Rows.Count - 1 ?? -1;
                    if (idx >= 0)
                    {
                        // Asignar siempre Tag con los ids reales
                        dgvListaAlumnos.Rows[idx].Tag = new RowIds(a.IdALumno, a.IdInscripcion);
                    }
                }

                // Reasignar handler (si aún existe el control)
                if (dgvListaAlumnos != null)
                {
                    dgvListaAlumnos.CellContentClick -= DgvListaAlumnos_CellContentClick;
                    dgvListaAlumnos.CellContentClick += DgvListaAlumnos_CellContentClick;
                }

                if (distinctAlumnos.Count == 0)
                {
                    MostrarAviso("No se encontraron alumnos.");
                }

                // Forzar refresh para asegurar visual correcto
                dgvListaAlumnos?.Refresh();
            }
            catch (HttpRequestException ex)
            {
                MostrarAviso("No se pudo conectar con la API de alumnos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MostrarAviso("Error al obtener alumnos: " + ex.Message);
            }
            finally
            {
                _isLoadingAlumnos = false;
            }
        }

        /// <summary>
        /// Manejador para clicks en el DataGridView de cursos.
        /// Detecta clicks en la columna de botón "Ver Alumnos" y abre la vista de alumnos.
        /// </summary>
        private async void DgvListaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            bool isButtonClick = false;

            // Intentar localizar columna por nombre (según el Designer el botón se llama "btnVer")
            var botonCol = dgvListaCursos.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "btnVer");
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
            else if (int.TryParse(row.Cells[0].Value?.ToString(), out int parsed)) cursoId = parsed; // columna 0 es Id

            if (cursoId > 0)
            {
                ListaCursoseleccionadoId = cursoId;
                // Cargar alumnos y mostrar panel (await para evitar llamadas concurrentes)
                await CargarAlumnosAsync(cursoId);
                MostrarPanelAlumnos();
            }
        }

        // Método generado por el diseñador — reusa el handler con la lógica real
        private async void dgvListaCursos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DgvListaCursos_CellContentClick(sender, e);
        }

        /// <summary>
        /// Manejador para clicks en el DataGridView de alumnos.
        /// Detecta clicks en la columna de botón "Guardar" y guarda la nota.
        /// Soporta CellContentClick.
        /// </summary>
        private async void DgvListaAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            bool isButtonClick = false;
            var botonGuardar = dgvListaAlumnos.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "btnGuardar");
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

            // recuperar ids desde Tag preferentemente
            int alumnoId = 0;
            int idInscripcion = 0;
            if (row.Tag is RowIds rid)
            {
                alumnoId = rid.AlumnoId;
                idInscripcion = rid.InscripcionId;
            }
            else if (e.RowIndex >= 0 && e.RowIndex < ListaAlumnos.Count)
            {
                // fallback: usar la lista cargada por índice (más fiable que devolver Legajo)
                var a = ListaAlumnos[e.RowIndex];
                alumnoId = a.IdALumno;
                idInscripcion = a.IdInscripcion;
            }
            else
            {
                MostrarAviso("No se pudo determinar el alumno");
                return;
            }

            var notaStr = row.Cells[2].Value?.ToString(); // columna 2 = Nota
            if (!int.TryParse(notaStr, out int notaVal))
            {
                // si vacío, tomar 0 (regular)
                notaVal = 0;
            }

            if (alumnoId > 0 && idInscripcion > 0)
            {
                await SubirNotaAsync(alumnoId, idInscripcion, notaVal);
            }
            else
            {
                MostrarAviso("Faltan datos para subir la nota");
            }
        }

        private async Task SubirNotaAsync(int idAlumno, int idInscripcion, int notaValor)
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
                        Id = idInscripcion,
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
                        Id = idInscripcion,
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
                        Id = idInscripcion,
                        IdAlumno = idAlumno,
                        IdCurso = ListaCursoseleccionadoId,
                        Nota = notaValor,
                        Condicion = "aprobado"
                    };
                }

                var resp = await _httpClient.PutAsJsonAsync($"/inscripciones/{idInscripcion}", inscripcionDTO);
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

    }
}
