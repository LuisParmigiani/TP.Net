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
    public partial class DocenteCursoCrud : Form
    {
        public DocenteCursoCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja DictadoDTO en la API
        private record DictadoDto(int Id, string Cargo, int IDCurso, int IDDocente);

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

        private void txtCrearIdDocente_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdDocente_TextChanged(object sender, EventArgs e)
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

        // Crear DocenteCurso -> POST /dictados
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var idCursoText = txtCrearIdCurso.Text;
            var idDocenteText = txtCrearIdDocente.Text;
            var cargo = txtCrearCargo.Text;
            if (string.IsNullOrWhiteSpace(idCursoText) || string.IsNullOrWhiteSpace(idDocenteText) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(idCursoText, out int idCurso) || !int.TryParse(idDocenteText, out int idDocente))
            {
                MessageBox.Show("ID de Curso e ID de Docente deben ser números válidos.");
                return;
            }

            try
            {
                var dto = new DictadoDto(0, cargo, idCurso, idDocente);
                var resp = await _httpClient.PostAsJsonAsync("/dictados", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<DictadoDto>();
                    MessageBox.Show($"DocenteCurso creado. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCrearIdCurso.Clear();
                    txtCrearIdDocente.Clear();
                    txtCrearCargo.Clear();
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar para modificar -> GET /dictados/{id}
        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/dictados/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var dc = await resp.Content.ReadFromJsonAsync<DictadoDto>();
                    if (dc != null)
                    {
                        txtModificarIdCurso.Text = dc.IDCurso.ToString();
                        txtModificarIdDocente.Text = dc.IDDocente.ToString();
                        txtModificarCargo.Text = dc.Cargo;
                        MessageBox.Show("DocenteCurso encontrado.");
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("DocenteCurso no encontrado.");
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {resp.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
        }

        // Modificar DocenteCurso -> PUT /dictados/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var idCursoText = txtModificarIdCurso.Text;
            var idDocenteText = txtModificarIdDocente.Text;
            var cargo = txtModificarCargo.Text;
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(idCursoText) || string.IsNullOrWhiteSpace(idDocenteText) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(idText, out int id) || !int.TryParse(idCursoText, out int idCurso) || !int.TryParse(idDocenteText, out int idDocente))
            {
                MessageBox.Show("IDs deben ser números válidos.");
                return;
            }

            try
            {
                var dto = new DictadoDto(id, cargo, idCurso, idDocente);
                var resp = await _httpClient.PutAsJsonAsync($"/dictados/{id}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("DocenteCurso modificado exitosamente.");
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("DocenteCurso no encontrado.");
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar: {resp.StatusCode} - {content}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
        }

        // Buscar para visualizar -> GET /dictados/{id}
        private async void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/dictados/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var dc = await resp.Content.ReadFromJsonAsync<DictadoDto>();
                    if (dc != null)
                    {
                        txtBuscarIdCurso.Text = dc.IDCurso.ToString();
                        txtBuscarIdDocente.Text = dc.IDDocente.ToString();
                        txtBuscarCargo.Text = dc.Cargo;
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("DocenteCurso no encontrado.");
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {resp.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
        }

        // Eliminar -> DELETE /dictados/{id}
        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            try
            {
                var getResp = await _httpClient.GetAsync($"/dictados/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var dc = await getResp.Content.ReadFromJsonAsync<DictadoDto>();
                    var confirm = MessageBox.Show($"Dictado encontrado (Curso {dc?.IDCurso}, Docente {dc?.IDDocente}, Cargo '{dc?.Cargo}'). ¿Desea eliminarlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/dictados/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show("DocenteCurso eliminado exitosamente.");
                            txtEliminarId.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("DocenteCurso no encontrado al intentar eliminar.");
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar: {delResp.StatusCode}");
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("DocenteCurso no encontrado.");
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {getResp.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
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
