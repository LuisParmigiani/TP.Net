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
    public partial class MateriaCrud : Form
    {
        public MateriaCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja MateriaDTO del servidor
        private record MateriaDto(int Id, string Descripcion, int HSSemanales, int HSTotales, int IdPlan);

            private void txtBuscarHsTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarIdPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsTotales_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsSemanales_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarIdPlan_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox (modificado para usar el control correcto)
            string texto = txtModificarIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtModificarIdPlan.SelectionStart - 1;
                txtModificarIdPlan.Text = soloNumeros;
                txtModificarIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtModificarHsTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarHsSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtModificarDescripcion.Text.Length > 50)
                MessageBox.Show("La descripción no puede exceder los 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Crear -> POST /materias
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = txtCrearDescripcion.Text?.Trim();
            var hsSemanales = (int)txtCrearHsSemanales.Value;
            var hsTotales = (int)txtCrearHsTotales.Value;
            var idPlanText = txtCrearIdPlan.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("Por favor, ingrese un ID de plan válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var dto = new MateriaDto(0, descripcion, hsSemanales, hsTotales, idPlan);
                var resp = await _httpClient.PostAsJsonAsync("/materias", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<MateriaDto>();
                    MessageBox.Show($"Materia '{created?.Descripcion}' creada con éxito. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCrearDescripcion.Clear();
                    txtCrearHsSemanales.Value = 0;
                    txtCrearHsTotales.Value = 0;
                    txtCrearIdPlan.Clear();
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear materia: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtCrearDescripcion.Text.Length > 50)
                txtCrearDescripcion.Text = txtCrearDescripcion.Text.Substring(0, 50);
        }

        private void txtCrearHsSemanales_ValueChanged(object sender, EventArgs e)
        {
            if (txtCrearHsSemanales.Value > 24)
            {
                MessageBox.Show("El valor máximo permitido es 24.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCrearIdPlan_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox de eliminar
            string texto = txtEliminarId.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtEliminarId.SelectionStart - 1;
                txtEliminarId.Text = soloNumeros;
                txtEliminarId.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Buscar para eliminar -> GET /materias/{id}
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
                var getResp = await _httpClient.GetAsync($"/materias/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var mat = await getResp.Content.ReadFromJsonAsync<MateriaDto>();
                    var confirm = MessageBox.Show($"Materia encontrada: '{mat?.Descripcion}' (HsSem: {mat?.HSSemanales}, HsTot: {mat?.HSTotales}, IdPlan: {mat?.IdPlan}). ¿Desea eliminarla?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/materias/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show($"Materia con ID {id} eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEliminarId.Clear();
                            txtBuscarDescripcion.Clear();
                            txtBuscarHsSemanales.Text = "";
                            txtBuscarHsTotales.Text = "";
                            txtBuscarIdPlan.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show($"Materia con ID {id} no encontrada al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar materia: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Materia con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtBuscarBuscarId_TextChanged(object sender, EventArgs e)
        {
            // Validación para permitir solo números en el campo de búsqueda
            string texto = txtBuscarBuscarId.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtBuscarBuscarId.SelectionStart - 1;
                txtBuscarBuscarId.Text = soloNumeros;
                txtBuscarBuscarId.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Buscar -> GET /materias/{id}
        private async void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/materias/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var mat = await resp.Content.ReadFromJsonAsync<MateriaDto>();
                    if (mat != null)
                    {
                        txtBuscarDescripcion.Text = mat.Descripcion;
                        txtBuscarHsSemanales.Text = mat.HSSemanales.ToString();
                        txtBuscarHsTotales.Text = mat.HSTotales.ToString();
                        txtBuscarIdPlan.Text = mat.IdPlan.ToString();
                        MessageBox.Show("Materia encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Materia con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Permitir solo números en el TextBox
            string texto = txtModificarId.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtModificarId.SelectionStart - 1;
                txtModificarId.Text = soloNumeros;
                txtModificarId.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Buscar para modificar -> GET /materias/{id}
        private async void btnModificarBuscar_Click_1(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/materias/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var mat = await resp.Content.ReadFromJsonAsync<MateriaDto>();
                    if (mat != null)
                    {
                        txtModificarDescripcion.Text = mat.Descripcion;
                        txtModificarHsSemanales.Value = mat.HSSemanales;
                        txtModificarHsTotales.Value = mat.HSTotales;
                        txtModificarIdPlan.Text = mat.IdPlan.ToString();
                        MessageBox.Show("Materia encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Materia con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Modificar -> PUT /materias/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            var hsSemanales = (int)txtModificarHsSemanales.Value;
            var hsTotales = (int)txtModificarHsTotales.Value;
            var idPlanText = txtModificarIdPlan.Text;

            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idText, out int id) || !int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("Por favor, ingrese un ID y un ID de plan válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var dto = new MateriaDto(id, descripcion, hsSemanales, hsTotales, idPlan);
                var resp = await _httpClient.PutAsJsonAsync($"/materias/{id}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show($"Materia con ID {id} modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Materia con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar materia: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
