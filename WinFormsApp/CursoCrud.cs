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
    public partial class CursoCrud : Form
    {
        public CursoCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja CursoDTO del servidor
        private record CursoDto(int Id, int AnioCalendario, int Cupo, string Descripcion, int IdComision, int IdMateria);

        private void txtModificarCupo_TextChanged(object sender, EventArgs e)
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

        private void txtCrearIdMateria_TextChanged(object sender, EventArgs e)
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

        private void txtCrearIdComision_TextChanged(object sender, EventArgs e)
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

        private void txtCrearAnioCalendario_TextChanged(object sender, EventArgs e)
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

        private void txtCrearCupo_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdMateria_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdComision_TextChanged(object sender, EventArgs e)
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

        private void txtModificarAnioCalendario_TextChanged(object sender, EventArgs e)
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



        private void textBox5_TextChanged(object sender, EventArgs e)
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

        // Crear curso -> POST /cursos
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCrearIdMateria.Text) ||
                string.IsNullOrWhiteSpace(txtCrearIdComision.Text) ||
                string.IsNullOrWhiteSpace(txtCrearAnioCalendario.Text) ||
                string.IsNullOrWhiteSpace(txtCrearCupo.Text) ||
                string.IsNullOrWhiteSpace(txtCrearDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para crear un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCrearIdMateria.Text, out int idMateria) ||
                !int.TryParse(txtCrearIdComision.Text, out int idComision) ||
                !int.TryParse(txtCrearAnioCalendario.Text, out int anioCalendario) ||
                !int.TryParse(txtCrearCupo.Text, out int cupo))
            {
                MessageBox.Show("Algunos campos numéricos no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // La UI actual no tiene un campo Descripcion; se envía string.Empty.
                var dto = new CursoDto(0, anioCalendario, cupo, txtCrearDescripcion.Text , idComision, idMateria);
                var resp = await _httpClient.PostAsJsonAsync("/cursos", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<CursoDto>();
                    MessageBox.Show($"Curso creado correctamente. ID: {created?.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // limpiar inputs si quieres:
                    txtCrearIdMateria.Clear();
                    txtCrearIdComision.Clear();
                    txtCrearAnioCalendario.Clear();
                    txtCrearCupo.Clear();
                    txtCrearDescripcion.Clear();
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear curso: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarIdMateria_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarIdComision_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarAnioCalendario_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarCupo_TextChanged(object sender, EventArgs e)
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

        // Buscar para modificar -> GET /cursos/{id}
        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un Id para buscar el curso a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/cursos/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var curso = await resp.Content.ReadFromJsonAsync<CursoDto>();
                    if (curso != null)
                    {
                        txtModificarIdMateria.Text = curso.IdMateria.ToString();
                        txtModificarIdComision.Text = curso.IdComision.ToString();
                        txtModificarAnioCalendario.Text = curso.AnioCalendario.ToString();
                        txtModificarCupo.Text = curso.Cupo.ToString();
                        txtModificarDescripcion.Text = curso.Descripcion;
                        MessageBox.Show("Curso encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Modificar curso -> PUT /cursos/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var id = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(id) || !int.TryParse(id, out int idCurso) || string.IsNullOrEmpty(txtModificarDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese un Id válido para modificar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtModificarIdMateria.Text, out int idMateria) ||
                !int.TryParse(txtModificarIdComision.Text, out int idComision) ||
                !int.TryParse(txtModificarAnioCalendario.Text, out int anioCalendario) ||
                !int.TryParse(txtModificarCupo.Text, out int cupo))
            {
                MessageBox.Show("Algunos campos numéricos no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // UI no tiene Descripcion para modificar; enviamos string.Empty
                var dto = new CursoDto(idCurso, anioCalendario, cupo, txtModificarDescripcion.Text , idComision, idMateria);
                var resp = await _httpClient.PutAsJsonAsync($"/cursos/{idCurso}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Curso modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Curso no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar curso: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar para visualizar -> GET /cursos/{id}
        private async void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un Id válido para buscar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/cursos/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var curso = await resp.Content.ReadFromJsonAsync<CursoDto>();
                    if (curso != null)
                    {
                        txtBuscarIdMateria.Text = curso.IdMateria.ToString();
                        txtBuscarIdComision.Text = curso.IdComision.ToString();
                        txtBuscarAnioCalendario.Text = curso.AnioCalendario.ToString();
                        txtBuscarCupo.Text = curso.Cupo.ToString();
                        txtBuscarDescripcion.Text = curso.Descripcion;  
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Eliminar -> DELETE /cursos/{id}
        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminarId.Text) || !int.TryParse(txtEliminarId.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un Id válido para eliminar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var getResp = await _httpClient.GetAsync($"/cursos/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var curso = await getResp.Content.ReadFromJsonAsync<CursoDto>();
                    var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el curso Id {id} (Materia {curso?.IdMateria}, Comisión {curso?.IdComision})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/cursos/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show($"Curso con Id: {id} eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEliminarId.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Curso no encontrado al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar curso: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud
                = new menuCrud();
            menuCrud.Show();
            this.Close();
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
