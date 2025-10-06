using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;

namespace WinFormsApp
{
    public partial class MenuAlumno : Form
    {
        private readonly HttpClient client;
        private int alumnoId;
        private int selectedMateriaId;

        // Datos cargados desde la API
        private List<DTOs.EstadoAcademico> materiasList = new List<DTOs.EstadoAcademico>();
        private List<DTOs.CursoWithEstado> cursosList = new List<DTOs.CursoWithEstado>();
        private List<DTOs.EstadoAcademico> estadoAcedemicos = new List<DTOs.EstadoAcademico>();

        private string mensaje = string.Empty;

        // Flags para evitar cargas concurrentes
        private bool _isLoadingMaterias = false;
        private bool _isLoadingCursos = false;
        private bool _isLoadingEstado = false;

        // Id de curso en proceso de inscripción (para deshabilitar temporalmente)
        private int? loadingCursoId = null;

        public MenuAlumno(int IdAlumno)
        {
            InitializeComponent();

            alumnoId = IdAlumno;
            client = new HttpClient { BaseAddress = new Uri("http://localhost:5183") };

            ShowPanelMenu();

            VolverMaterias.Click += VolverMateriasClick;
            VolverCursos.Click += VolverCursosClick;
            VolverEstadoAcademico.Click += VolverEstadoAcademicoClick;

            // Asegurar que no haya suscripciones duplicadas
            dataGridView1.CellContentClick -= dataGridView1CellContentClick;
            dataGridView1.CellContentClick += dataGridView1CellContentClick;

            GridCurso.CellContentClick -= GridCursoCellContentClick;
            GridCurso.CellContentClick += GridCursoCellContentClick;

            GridEstadoAcademico.CellContentClick -= GridEstadoAcademico_CellContentClick;
            GridEstadoAcademico.CellContentClick += GridEstadoAcademico_CellContentClick;
        }

        private void ShowPanelMenu()
        {
            panelMenuAlumno.Visible = true;
            panelMaterias.Visible = false;
            panelCursos.Visible = false;
            panelEsatdoAcademico.Visible = false;
        }

        private void ShowPanelMaterias()
        {
            panelMenuAlumno.Visible = false;
            panelMaterias.Visible = true;
            panelCursos.Visible = false;
            panelEsatdoAcademico.Visible = false;
        }

        private void ShowPanelCursos()
        {
            panelMenuAlumno.Visible = false;
            panelMaterias.Visible = false;
            panelCursos.Visible = true;
            panelEsatdoAcademico.Visible = false;
        }

        private void ShowPanelEstado()
        {
            panelMenuAlumno.Visible = false;
            panelMaterias.Visible = false;
            panelCursos.Visible = false;
            panelEsatdoAcademico.Visible = true;
        }

        // Click desde diseñador: abrir listado de materias para inscribirse
        private async void inscrClick(object sender, EventArgs e)
        {
            await LoadMateriasAsync();
            ShowPanelMaterias();
        }

        // Click desde diseñador: ver estado académico
        private async void EstadoAcademicoClick(object sender, EventArgs e)
        {
            await LoadEstadoAcademicoAsync();
            ShowPanelEstado();
        }

        private async void dataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var col = dataGridView1.Columns[e.ColumnIndex];
            bool isButton = col is DataGridViewButtonColumn || col.Name == "Inscribirme";
            if (!isButton) return;

            var row = dataGridView1.Rows[e.RowIndex];
            int materiaId = 0;
            if (row.Tag is int mid) materiaId = mid;
            else if (int.TryParse(row.Cells[0].Value?.ToString(), out int parsed)) materiaId = parsed;

            if (materiaId > 0)
            {
                selectedMateriaId = materiaId;
                await LoadCursosAsync(materiaId);
                ShowPanelCursos();
            }
        }

        private async void GridCursoCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var col = GridCurso.Columns[e.ColumnIndex];
            bool isButton = col is DataGridViewButtonColumn || col.Name == "Anotarme";
            if (!isButton) return;

            var row = GridCurso.Rows[e.RowIndex];
            int cursoId = 0;
            if (row.Tag is int cid) cursoId = cid;
            else if (int.TryParse(row.Cells[0].Value?.ToString(), out int parsed)) cursoId = parsed;

            if (cursoId <= 0)
            {
                MostrarAviso("Id de curso inválido");
                return;
            }

            // Buscar el curso en la lista y comprobar disponibilidad
            var curso = cursosList.FirstOrDefault(c => c.Id == cursoId);
            if (curso != null && !curso.Estado)
            {
                MostrarAviso("No hay más cupo en el curso seleccionado.");
                return;
            }

            await AnotarmeCursoAsync(cursoId);
        }

        private async Task LoadMateriasAsync()
        {
            if (_isLoadingMaterias) return;
            _isLoadingMaterias = true;

            try
            {
                dataGridView1.Rows.Clear();

                var materias = await client.GetFromJsonAsync<List<DTOs.EstadoAcademico>>($"/inscripciones/estadoOfAlumno/{alumnoId}");
                materiasList = materias ?? new List<DTOs.EstadoAcademico>();

                // Deduplicar por IdMateria por si acaso
                var distinct = materiasList.GroupBy(m => m.IdMateria).Select(g => g.First()).ToList();

                foreach (var mat in distinct)
                {
                    if (mat.Nota == null)
                    {
                        int idx = dataGridView1.Rows.Add(mat.DescMateria, "Inscribirme");
                        dataGridView1.Rows[idx].Tag = mat.IdMateria;
                    }
                }

                if (!distinct.Any())
                {
                    MostrarAviso("No se encontraron materias para poder inscribirse.");
                }
            }
            catch (Exception ex)
            {
                MostrarAviso($"Excepción al obtener las materias: {ex.Message}");
            }
            finally
            {
                _isLoadingMaterias = false;
            }
        }

        private async Task LoadCursosAsync(int materiaId)
        {
            if (_isLoadingCursos) return;
            _isLoadingCursos = true;

            try
            {
                GridCurso.Rows.Clear();

                var cursos = await client.GetFromJsonAsync<List<DTOs.CursoWithEstado>>($"/cursos/ByMateria/{materiaId}");
                cursosList = cursos ?? new List<DTOs.CursoWithEstado>();

                // Deduplicar por Id
                var distinct = cursosList.GroupBy(c => c.Id).Select(g => g.First()).ToList();

                foreach (var cur in distinct)
                {
                    int idx = GridCurso.Rows.Add(cur.Id, cur.Descripcion, cur.Estado ? "Anotarme" : "Sin cupo");
                    GridCurso.Rows[idx].Tag = cur.Id;
                }

                if (!distinct.Any())
                {
                    MostrarAviso("No se encontraron cursos para la materia seleccionada.");
                }
            }
            catch (Exception ex)
            {
                MostrarAviso($"Excepción al obtener los cursos: {ex.Message}");
            }
            finally
            {
                _isLoadingCursos = false;
            }
        }

        private async Task AnotarmeCursoAsync(int cursoId)
        {
            try
            {
                // Marcar loading para evitar acciones duplicadas
                loadingCursoId = cursoId;
                // Deshabilitar grid mientras se inscribe
                GridCurso.Enabled = false;

                var inscripcion = new InscripcionDTO { IdAlumno = alumnoId, IdCurso = cursoId, Condicion = "cursando" };
                var response = await client.PostAsJsonAsync("/inscripciones", inscripcion);
                if (response.IsSuccessStatusCode)
                {
                    MostrarAviso("Inscripción realizada con éxito.");
                    // Recargar materias para actualizar estado
                    await LoadMateriasAsync();
                    ShowPanelMaterias();
                }
                else
                {
                    var txt = await response.Content.ReadAsStringAsync();
                    MostrarAviso($"Error al inscribirse: {(int)response.StatusCode} {response.ReasonPhrase} - {txt}");
                }
            }
            catch (Exception ex)
            {
                MostrarAviso($"Excepción al inscribirse: {ex.Message}");
            }
            finally
            {
                loadingCursoId = null;
                GridCurso.Enabled = true;
            }
        }

        private async Task LoadEstadoAcademicoAsync()
        {
            if (_isLoadingEstado) return;
            _isLoadingEstado = true;

            try
            {
                GridEstadoAcademico.Rows.Clear();

                var estado = await client.GetFromJsonAsync<List<DTOs.EstadoAcademico>>($"/inscripciones/estadoOfAlumno/{alumnoId}");
                estadoAcedemicos = estado ?? new List<DTOs.EstadoAcademico>();

                // Mostrar cada registro
                foreach (var est in estadoAcedemicos)
                {
                    string condicion = est.Nota != null ? (est.Nota != 0 ? $"Nota final: {est.Nota}" : (est.Condicion ?? string.Empty)) : "No cursada";
                    GridEstadoAcademico.Rows.Add(est.DescMateria, condicion, est.IdComCursada ?? 0, est.AnioEspecialidadCursada ?? 0);
                }

                if (!estadoAcedemicos.Any())
                {
                    MostrarAviso("No se encontraron materias en el estado académico.");
                }
            }
            catch (Exception ex)
            {
                MostrarAviso($"Excepción al obtener el estado académico: {ex.Message}");
            }
            finally
            {
                _isLoadingEstado = false;
            }
        }

        private void VolverMateriasClick(object sender, EventArgs e)
        {
            ShowPanelMenu();
        }

        private void VolverCursosClick(object sender, EventArgs e)
        {
            ShowPanelMaterias();
        }

        private void VolverEstadoAcademicoClick(object sender, EventArgs e)
        {
            ShowPanelMenu();
        }

        private void GridEstadoAcademico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // no-op
        }

        // Simple helper to show messages (centralizado)
        private void MostrarAviso(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return;
            MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
