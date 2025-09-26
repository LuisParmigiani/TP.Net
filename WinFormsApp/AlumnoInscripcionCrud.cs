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

namespace WinFormsApp
{
    public partial class AlumnoInscripcionCrud : Form
    {
        public AlumnoInscripcionCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja InscripcionDTO del servidor
        private record InscripcionDto(int Id, int IdAlumno, int IdCurso, int Nota, string Condicion);

        private void txtCrearIdAlumno_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtCrearIdCurso_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtCrearNota_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                int valor = 0;
                if (!string.IsNullOrEmpty(soloNumeros))
                {
                    valor = int.Parse(soloNumeros);
                    if (valor > 10)
                    {
                        soloNumeros = "10";
                        valor = 10;
                    }
                }
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtModificarIdAlumno_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtModificarIdCurso_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtModificarIdNota_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                int valor = 0;
                if (!string.IsNullOrEmpty(soloNumeros))
                {
                    valor = int.Parse(soloNumeros);
                    if (valor > 10)
                    {
                        soloNumeros = "10";
                        valor = 10;
                    }
                }
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtBuscarBuscarId_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                if (txt.Text != soloNumeros)
                {
                    int pos = txt.SelectionStart - (txt.Text.Length - soloNumeros.Length);
                    txt.Text = soloNumeros;
                    txt.SelectionStart = Math.Max(0, pos);
                }
            }
        }

        // Crear inscripcion -> POST /inscripciones
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var idAlumnoText = txtCrearIdAlumno.Text;
            var idCursoText = txtCrearIdCurso.Text;
            var notaText = txtCrearNota.Text;
            string condicion = null;

            if (radioCrearRegular.Checked)
            {
                condicion = "regular";
            }
            else if (radioCrearLibre.Checked)
            {
                condicion = "libre";
            }
            else if (radioCrearAprobado.Checked)
            {
                condicion = "aprobado";
            }

            if (string.IsNullOrEmpty(idAlumnoText) || string.IsNullOrEmpty(idCursoText) || string.IsNullOrEmpty(notaText) || string.IsNullOrEmpty(condicion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int idAlumno = int.Parse(idAlumnoText);
            int idCurso = int.Parse(idCursoText);
            int nota = int.Parse(notaText);

            try
            {
                var dto = new InscripcionDto(0, idAlumno, idCurso, nota, condicion);
                var response = await _httpClient.PostAsJsonAsync("/inscripciones", dto);
                if (response.IsSuccessStatusCode)
                {
                    var created = await response.Content.ReadFromJsonAsync<InscripcionDto>();
                    MessageBox.Show($"Inscripción creada. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear: {response.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar para modificar -> GET /inscripciones/{id}
        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"/inscripciones/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var insc = await response.Content.ReadFromJsonAsync<InscripcionDto>();
                    if (insc != null)
                    {
                        txtModificarIdAlumno.Text = insc.IdAlumno.ToString();
                        txtModificarIdCurso.Text = insc.IdCurso.ToString();
                        txtModificarIdNota.Text = insc.Nota.ToString();

                        radioMoificarRegular.Checked = insc.Condicion == "regular";
                        radioMoificarLibre.Checked = insc.Condicion == "libre";
                        radioMoificarAprobado.Checked = insc.Condicion == "aprobado";

                        MessageBox.Show("Inscripción encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Modificar inscripcion -> PUT /inscripciones/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var idAlumnoText = txtModificarIdAlumno.Text;
            var idCursoText = txtModificarIdCurso.Text;
            var notaText = txtModificarIdNota.Text;
            string condicion = null;

            if (radioMoificarRegular.Checked)
            {
                condicion = "regular";
            }
            else if (radioMoificarLibre.Checked)
            {
                condicion = "libre";
            }
            else if (radioMoificarAprobado.Checked)
            {
                condicion = "aprobado";
            }

            if (string.IsNullOrEmpty(idText) || string.IsNullOrEmpty(idAlumnoText) || string.IsNullOrEmpty(idCursoText) || string.IsNullOrEmpty(notaText) || string.IsNullOrEmpty(condicion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(idText, out int id) ||
                !int.TryParse(idAlumnoText, out int idAlumno) ||
                !int.TryParse(idCursoText, out int idCurso) ||
                !int.TryParse(notaText, out int nota))
            {
                MessageBox.Show("Algunos valores numéricos son inválidos.");
                return;
            }

            try
            {
                var dto = new InscripcionDto(id, idAlumno, idCurso, nota, condicion);
                var response = await _httpClient.PutAsJsonAsync($"/inscripciones/{id}", dto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Inscripción modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar: {response.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar para visualizar -> GET /inscripciones/{id}
        private async void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"/inscripciones/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var insc = await response.Content.ReadFromJsonAsync<InscripcionDto>();
                    if (insc != null)
                    {
                        txtBuscarIdAlumno.Text = insc.IdAlumno.ToString();
                        txtBuscarIdCurso.Text = insc.IdCurso.ToString();
                        txtBuscarNota.Text = insc.Nota.ToString();

                        RadioBuscarRegular.Checked = insc.Condicion == "regular";
                        RadioBuscarLibre.Checked = insc.Condicion == "libre";
                        RadioBuscarAprobado.Checked = insc.Condicion == "aprobado";

                        MessageBox.Show("Inscripción encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar -> DELETE /inscripciones/{id}
        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var id = txtEliminarId;
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            if (!int.TryParse(id.Text, out int idEliminar))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"/inscripciones/{idEliminar}");
                if (response.IsSuccessStatusCode)
                {
                    var insc = await response.Content.ReadFromJsonAsync<InscripcionDto>();
                    var confirm = MessageBox.Show($"Inscripción encontrada (Alumno {insc?.IdAlumno}, Curso {insc?.IdCurso}). ¿Desea eliminarla?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/inscripciones/{idEliminar}");
                        if (delResp.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Inscripción eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Inscripción no encontrada al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Inscripción no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
