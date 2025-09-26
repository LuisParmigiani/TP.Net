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
    public partial class EspecialidadCrud : Form
    {
        public EspecialidadCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja EspecialidadDTO en la API
        private record EspecialidadDto(int Id, string Descripcion);

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }

        private void panelCrear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        // Crear -> POST /especialidades
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = textBox1.Text?.Trim();
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (descripcion.Length > 50)
            {
                MessageBox.Show("Máximo 50 caracteres permitidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descripcion = descripcion.Substring(0, 50);
                textBox1.Text = descripcion;
            }

            try
            {
                var dto = new EspecialidadDto(0, descripcion);
                var resp = await _httpClient.PostAsJsonAsync("/especialidades", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<EspecialidadDto>();
                    MessageBox.Show($"Especialidad '{created?.Descripcion}' creada con éxito. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear especialidad: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 50)
            {
                textBox1.Text = textBox1.Text.Substring(0, 50);
                textBox1.SelectionStart = textBox1.Text.Length;
                MessageBox.Show("Máximo 50 caracteres permitidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Buscar -> GET /especialidades/{id}
        private async void btnBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarId.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/especialidades/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var esp = await resp.Content.ReadFromJsonAsync<EspecialidadDto>();
                    if (esp != null)
                    {
                        txtBuscarId.Text = esp.Id.ToString();
                        txtBuscardescripcion.Text = esp.Descripcion;
                        MessageBox.Show($"Especialidad con ID {id} encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {resp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtBuscarId.SelectionStart = txtBuscarId.Text.Length;
            }
        }

        // Buscar para modificar -> GET /especialidades/{id}
        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/especialidades/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var esp = await resp.Content.ReadFromJsonAsync<EspecialidadDto>();
                    if (esp != null)
                    {
                        txtModificarId.Text = esp.Id.ToString();
                        txtModificarDescripcion.Text = esp.Descripcion;
                        MessageBox.Show($"Especialidad con ID {id} encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {resp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtModificarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModificarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtModificarId.SelectionStart = txtModificarId.Text.Length;
            }
        }

        // Modificar -> PUT /especialidades/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text?.Trim();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (descripcion.Length > 50)
            {
                MessageBox.Show("Máximo 50 caracteres permitidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descripcion = descripcion.Substring(0, 50);
                txtModificarDescripcion.Text = descripcion;
            }

            try
            {
                var dto = new EspecialidadDto(id, descripcion);
                var resp = await _httpClient.PutAsJsonAsync($"/especialidades/{id}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show($"Especialidad con ID {id} modificada a '{descripcion}' con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar especialidad: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtEliminarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEliminarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtEliminarId.SelectionStart = txtEliminarId.Text.Length;
            }
        }

        // Eliminar -> DELETE /especialidades/{id}
        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var getResp = await _httpClient.GetAsync($"/especialidades/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var esp = await getResp.Content.ReadFromJsonAsync<EspecialidadDto>();
                    var confirm = MessageBox.Show($"Especialidad con ID {esp?.Id} encontrada: '{esp?.Descripcion}'. ¿Desea eliminarla?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/especialidades/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show($"Especialidad con ID {id} eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEliminarId.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show($"Especialidad con ID {id} no encontrada al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar especialidad: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al consultar la API: {getResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscardescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
