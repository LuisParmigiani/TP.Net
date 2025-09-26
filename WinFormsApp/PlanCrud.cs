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
    public partial class PlanCrud : Form
    {
        public PlanCrud()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // Local DTO matching the API PlanDTO
        private record PlanDto(int Id, string Descripcion, int IdEspecialidad);


        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (int.TryParse(idText, out int id))
            {
                try
                {
                    var response = await _httpClient.GetAsync($"/planes/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var plan = await response.Content.ReadFromJsonAsync<PlanDto>();
                        var confirm = MessageBox.Show($"Plan con ID {id} encontrado: '{plan?.Descripcion}'. ¿Desea eliminarlo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            var delResp = await _httpClient.DeleteAsync($"/planes/{id}");
                            if (delResp.IsSuccessStatusCode)
                            {
                                MessageBox.Show($"Plan con ID {id} eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                            {
                                MessageBox.Show($"Plan con ID {id} no encontrado al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show($"Error al eliminar el plan: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
            }
        }

        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            
            if (int.TryParse(idText, out int id))
            {
                try
                {
                    var response = await _httpClient.GetAsync($"/planes/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var plan = await response.Content.ReadFromJsonAsync<PlanDto>();
                        if (plan != null)
                        {
                            txtModificarId.Text = plan.Id.ToString();
                            txtModificarDescripcion.Text = plan.Descripcion;
                            txtModificarIdEspecialidad.Text = plan.IdEspecialidad.ToString();
                            MessageBox.Show($"Plan con ID {id} encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
            }
        }

        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            var idEspecialidadText = txtModificarIdEspecialidad.Text;
            if(!int.TryParse(idEspecialidadText, out int idEspecialidad))
            {
                MessageBox.Show("El ID de especialidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(idText, out int id))
            {
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var dto = new PlanDto(id, descripcion, idEspecialidad);
                    var putResp = await _httpClient.PutAsJsonAsync($"/planes/{id}", dto);
                    if (putResp.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Plan con ID {id} modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (putResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var content = await putResp.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al modificar el plan: {putResp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (int.TryParse(idText, out int id))
            {
                try
                {
                    var response = await _httpClient.GetAsync($"/planes/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var plan = await response.Content.ReadFromJsonAsync<PlanDto>();
                        txtBuscarBuscarId.Text = plan.Id.ToString();
                        txtBuscarDescripcion.Text = plan.Descripcion;
                        txtBuscarIdEspecialidad.Text = plan.IdEspecialidad.ToString();
                        MessageBox.Show($"Plan con ID {id} encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarBuscarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
            }
        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            // Deshabilitar edición
            textBox.ReadOnly = true;
        }

        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = txtCrearDescripcion.Text;
            var idEspecialidadText = txtCrearIdEspecialidad.Text;
            if (string.IsNullOrEmpty(idEspecialidadText))
            {
                MessageBox.Show("El ID de especialidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idEspecialidadText, out int idEspecialidad))
            {
                MessageBox.Show("El ID de especialidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    var dto = new PlanDto(0, descripcion, idEspecialidad);
                    var postResp = await _httpClient.PostAsJsonAsync("/planes", dto);
                    if (postResp.IsSuccessStatusCode)
                    {
                        var created = await postResp.Content.ReadFromJsonAsync<PlanDto>();
                        MessageBox.Show($"Plan '{created?.Descripcion}' creado con éxito. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        var content = await postResp.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al crear el plan: {postResp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();

        }

        private void txtCrearIdEspecialidad_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscarIdEspecialidad_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtModificarIdEspecialidad_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
