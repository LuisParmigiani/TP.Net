using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
namespace WinFormsApp
{
    public partial class MenuAlumno : Form
    {
        private readonly HttpClient _httpClient;
        private readonly int _alumnoId;

        private List<MateriaDTO> _materias = new();
        private List<CursoDTO> _cursos = new();
        private List<EstadoAcedemico> _estado = new();
        private int _selectedMateriaId;

        public MenuAlumno(int IdAlumno)
        {
            InitializeComponent();

            _alumnoId = IdAlumno;
            // Ajusta la BaseAddress si tu API está en otra URL
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5183") };

            // Asegurar paneles al inicio
            ShowPanelMenu();

            // Suscribir eventos no ligados por el diseñador
            VolverMaterias.Click += VolverMaterias_Click;
            VolverCursos.Click += VolverCursos_Click;
            GridCurso.CellContentClick += GridCurso_CellContentClick;
            // Los botones principales ya están ligados en el diseñador a inscr_Click y EstadoAcademico_Click
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
        private async void inscr_Click(object sender, EventArgs e)
        {
            await LoadMateriasAsync();
            ShowPanelMaterias();
        }

        // Click desde diseñador: ver estado académico
        private async void EstadoAcademico_Click(object sender, EventArgs e)
        {
            await LoadEstadoAcademicoAsync();
            ShowPanelEstado();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var btnCol = dataGridView1.Columns["Inscribirme"];
            if (btnCol != null && e.ColumnIndex == btnCol.Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Tag is int mid)
                {
                    _selectedMateriaId = mid;
                }
                else
                {
                    var desc = row.Cells["Materia"].Value?.ToString();
                    var m = _materias.Find(x => x.Descripcion == desc);
                    _selectedMateriaId = m?.Id ?? 0;
                }

                if (_selectedMateriaId > 0)
                {
                    await LoadCursosAsync(_selectedMateriaId);
                    ShowPanelCursos();
                }
            }
        }

        private async void GridCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var btnCol = GridCurso.Columns["Anotarme"];
            if (btnCol != null && e.ColumnIndex == btnCol.Index)
            {
                var row = GridCurso.Rows[e.RowIndex];
                int cursoId = 0;
                if (row.Tag is int cid) cursoId = cid;
                else if (int.TryParse(row.Cells["Curso"].Value?.ToString(), out int parsed)) cursoId = parsed;

                if (cursoId > 0)
                {
                    await AnotarmeCursoAsync(cursoId);
                }
            }
        }

        private async Task LoadMateriasAsync()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var materias = await _httpClient.GetFromJsonAsync<List<MateriaDTO>>("/materias");
                _materias = materias ?? new List<MateriaDTO>();

                foreach (var m in _materias)
                {
                    // Añade una fila: la columna Materia mostrará la descripción; la columna Inscribirme es botón
                    dataGridView1.Rows.Add(m.Descripcion);
                    var idx = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[idx].Tag = m.Id;
                }

                if (_materias.Count == 0)
                {
                    MessageBox.Show("No se encontraron materias disponibles.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo conectar con la API de materias: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener materias: " + ex.Message);
            }
        }

        private async Task LoadCursosAsync(int materiaId)
        {
            try
            {
                GridCurso.Rows.Clear();
                var cursos = await _httpClient.GetFromJsonAsync<List<CursoDTO>>("/cursos");
                cursos ??= new List<CursoDTO>();
                _cursos = cursos.FindAll(c => c.IdMateria == materiaId);

                foreach (var c in _cursos)
                {
                    GridCurso.Rows.Add(c.Id, c.Descripcion);
                    var idx = GridCurso.Rows.Count - 1;
                    GridCurso.Rows[idx].Tag = c.Id;
                }

                if (_cursos.Count == 0)
                {
                    MessageBox.Show("No se encontraron cursos para la materia seleccionada.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo conectar con la API de cursos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cursos: " + ex.Message);
            }
        }

        private async Task AnotarmeCursoAsync(int cursoId)
        {
            try
            {
                var inscripcion = new InscripcionDTO
                {
                    IdAlumno = _alumnoId,
                    IdCurso = cursoId,
                    Condicion = "cursando"
                };

                var resp = await _httpClient.PostAsJsonAsync("/inscripciones", inscripcion);
                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Inscripción realizada con éxito.");
                    // Mostrar estado académico actualizado
                    await LoadEstadoAcademicoAsync();
                    ShowPanelEstado();
                }
                else
                {
                    var err = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al inscribirse: {(int)resp.StatusCode} {resp.ReasonPhrase}\n{err}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo conectar con la API de inscripciones: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribirse: " + ex.Message);
            }
        }

        private async Task LoadEstadoAcademicoAsync()
        {
            try
            {
                GridEstadoAcademico.Rows.Clear();
                var lista = await _httpClient.GetFromJsonAsync<List<EstadoAcedemico>>($"/inscripciones/estadoOfAlumno/{_alumnoId}");
                _estado = lista ?? new List<EstadoAcedemico>();

                foreach (var eac in _estado)
                {
                    string condicionText = eac.Nota != 0 ? $"Nota final: {eac.Nota}" : eac.Condicion;
                    GridEstadoAcademico.Rows.Add(eac.Descripcion_Materia, condicionText, eac.Id_Comision);
                }

                if (_estado.Count == 0)
                {
                    MessageBox.Show("No hay registros en el estado académico.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("No se pudo conectar con la API de estado académico: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estado académico: " + ex.Message);
            }
        }

        private void VolverMaterias_Click(object sender, EventArgs e)
        {
            ShowPanelMenu();
        }

        private void VolverCursos_Click(object sender, EventArgs e)
        {
            ShowPanelMaterias();
        }

        private void VolverEstadoAcademico_Click(object sender, EventArgs e)
        {
            ShowPanelMenu();
        }
    }
}
