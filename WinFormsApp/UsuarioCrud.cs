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
    public partial class UsuarioCrud : Form
    {
        public UsuarioCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja UsuarioDTO del servidor
        private record UsuarioDto(int Id, string NombreUsuario, string Clave, bool Habilitado, int IdPersona, bool CambiaClave);

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarIdPersona_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarIdP_TextChanged(object sender, EventArgs e)
        {

        }

        private void    txtModificarNombreUsuario_TextChanged(object sender, EventArgs e)
        {

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

        private void txtCrearIdPersona_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdPersona_TextChanged(object sender, EventArgs e)
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

        private void txtModificarMail_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string valor = txt.Text;
                // Expresión regular simple para validar formato de email
                var esMail = System.Text.RegularExpressions.Regex.IsMatch(valor, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!esMail && valor.Length > 0)
                {
                    txt.ForeColor = Color.Red;
                }
                else
                {
                    txt.ForeColor = Color.Black;
                }
            }
        }

        // Crear usuario -> POST /usuarios
        private async void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var nombreUsuario = txtCrearNombreUsuario.Text;
            var clave = txtCrearClave.Text;
            var nombre = txtCrearNombre.Text;
            var apellido = txtCrearApellido.Text;
            var mail = txtCrearEmail.Text;
            var idPersonaText = txtCrearIdPersona.Text;
            var habilitado = radioCrearHabilitado.Checked;
            var cambioClave = radioCrearCambioClave.Checked;

            // Validar formato de email
            var esMail = System.Text.RegularExpressions.Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(idPersonaText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!esMail)
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }

            if (!int.TryParse(idPersonaText, out int idPersona))
            {
                MessageBox.Show("IdPersona inválido.");
                return;
            }

            try
            {
                var dto = new UsuarioDto(0, nombreUsuario, clave, habilitado, idPersona, cambioClave);
                var resp = await _httpClient.PostAsJsonAsync("/usuarios", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<UsuarioDto>();
                    MessageBox.Show($"Usuario '{created?.NombreUsuario}' creado exitosamente. ID: {created?.Id}");
                    // limpiar formulario básico
                    txtCrearNombreUsuario.Clear();
                    txtCrearClave.Clear();
                    txtCrearNombre.Clear();
                    txtCrearApellido.Clear();
                    txtCrearEmail.Clear();
                    txtCrearIdPersona.Clear();
                    radioCrearHabilitado.Checked = false;
                    radioCrearCambioClave.Checked = false;
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear usuario: {resp.StatusCode} - {content}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
        }

        // Buscar para modificar -> GET /usuarios/{id}
        private async void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/usuarios/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var u = await resp.Content.ReadFromJsonAsync<UsuarioDto>();
                    if (u != null)
                    {
                        txtModificarNombreUsuario.Text = u.NombreUsuario;
                        txtModificarClave.Text = u.Clave;
                        txtModificarIdPersona.Text = u.IdPersona.ToString();
                        radioModificarHabilitado.Checked = u.Habilitado;
                        radioModificarCambioClave.Checked = u.CambiaClave;
                        // Nombre, Apellido, Mail no vienen en UsuarioDTO; quedan como estaban o se deben manejar aparte si existe API.
                        MessageBox.Show("Usuario encontrado.");
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Usuario no encontrado.");
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

        // Modificar usuario -> PUT /usuarios/{id}
        private async void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var nombreUsuario = txtModificarNombreUsuario.Text;
            var clave = txtModificarClave.Text;
            var nombre = txtModificarNombre.Text;
            var apellido = txtModificarApellido.Text;
            var mail = txtModificarMail.Text;
            var idPersonaText = txtModificarIdPersona.Text;
            var habilitado = radioModificarHabilitado.Checked;
            var cambioClave = radioModificarCambioClave.Checked;

            var esMail = System.Text.RegularExpressions.Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!esMail && !string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(idPersonaText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(idText, out int id) || !int.TryParse(idPersonaText, out int idPersona))
            {
                MessageBox.Show("ID o IdPersona inválidos.");
                return;
            }

            try
            {
                var dto = new UsuarioDto(id, nombreUsuario, clave, habilitado, idPersona, cambioClave);
                var resp = await _httpClient.PutAsJsonAsync($"/usuarios/{id}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Usuario modificado exitosamente.");
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar usuario: {resp.StatusCode} - {content}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
        }

        // Buscar visualización -> GET /usuarios/{id}
        private async void btnBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/usuarios/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var u = await resp.Content.ReadFromJsonAsync<UsuarioDto>();
                    if (u != null)
                    {
                        txtBuscarNombreUsuario.Text = u.NombreUsuario;
                        txtBuscarClave.Text = u.Clave;
                        txtBuscarIdPersona.Text = u.IdPersona.ToString();
                        radioBuscarHabilitado.Checked = u.Habilitado;
                        radioBuscarCambioClave.Checked = u.CambiaClave;
                        // Nombre/Apellido/Mail no provienen del endpoint; si tu API los expone, adapta el DTO.
                        MessageBox.Show("Usuario encontrado.");
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"{id} no encontrado.");
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

        // Eliminar -> DELETE /usuarios/{id}
        private async void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idCtrl = txtEliminarId;
            if (idCtrl is null || string.IsNullOrWhiteSpace(idCtrl.Text) || !int.TryParse(idCtrl.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }

            try
            {
                var getResp = await _httpClient.GetAsync($"/usuarios/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var u = await getResp.Content.ReadFromJsonAsync<UsuarioDto>();
                    var confirm = MessageBox.Show($"Usuario encontrado: {u?.NombreUsuario} (IdPersona {u?.IdPersona}). ¿Desea eliminarlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/usuarios/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.");
                            txtEliminarId.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Usuario no encontrado al intentar eliminar.");
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar usuario: {delResp.StatusCode}");
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Usuario no encontrado.");
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
            menuCrud.Show(this);
            this.Hide();
        }
    }
}
