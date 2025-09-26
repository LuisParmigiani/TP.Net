using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinFormsApp
{
    public partial class PersonaCrud : Form
    {
        public PersonaCrud()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5183")
        };

        // DTO local que refleja PersonaDTO del servidor
        private record PersonaDto(int Id, string Nombre, string Apellido, string Direccion, string Email, string Telefono, DateTime FechaNacimiento, string Legajo, string TipoPersona, int IdPlan);

        // Método para el botón Guardar/Cargar del panel Crear
        private async void btnGuardarCrear_Click_1(object sender, EventArgs e)
        {
            // Validar campos antes de asignar
            if (!ValidarCamposCrear())
            {
                return; // Detener ejecución si hay errores
            }
            var idPlan = txtModificarIdPlan.Text;
            if (!int.TryParse(idPlan, out int idp))
            {
                MessageBox.Show("Ingrese un ID de plan válido");
                return;
            }
            // Determinar el tipo de usuario basado en los RadioButtons
            var TipoUsuario = "";
            if (RadioProfesor.Checked)
            {
                TipoUsuario = "Profesor";
            }
            else if (RadioAlumno.Checked)
            {
                TipoUsuario = "Alumno";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario (Profesor o Alumno)");
                return;
            }

            // Construir DTO (si no tienes FechaNacimiento en la UI, uso DateTime.Now como placeholder)
            var dto = new PersonaDto(0,
                                     txtNombreCrear.Text.Trim(),
                                     txtCrearApellido.Text.Trim(),
                                     txtCrearDireccion.Text.Trim(),
                                     txtCrearEmail.Text.Trim(),
                                     txtCrearTelefono.Text.Trim(),
                                     DateTime.Now,
                                     txtCrearLegajo.Text.Trim(),
                                     TipoUsuario,
                                     idp
                                     );

            try
            {
                var resp = await _httpClient.PostAsJsonAsync("/personas", dto);
                if (resp.IsSuccessStatusCode)
                {
                    var created = await resp.Content.ReadFromJsonAsync<PersonaDto>();
                    MessageBox.Show($"Persona creada:\nID: {created?.Id}\nNombre: {created?.Nombre} {created?.Apellido}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // limpiar inputs
                    txtNombreCrear.Clear();
                    txtCrearApellido.Clear();
                    txtCrearDireccion.Clear();
                    txtCrearEmail.Clear();
                    txtCrearTelefono.Clear();
                    txtCrearLegajo.Clear();
                    RadioProfesor.Checked = false;
                    RadioAlumno.Checked = false;
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear persona: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función necesaria para validar campos del formulario Crear
        private bool ValidarCamposCrear()
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreCrear.Text) ||
                        string.IsNullOrWhiteSpace(txtCrearApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCrearDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCrearEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCrearTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCrearLegajo.Text))
            {
                MessageBox.Show("Faltan datos por completar");
                return false;
            }

            // Validar teléfono
            if (txtCrearTelefono.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos");
                return false;
            }

            // Validar email
            if (!txtCrearEmail.Text.Contains("@") || !txtCrearEmail.Text.Contains(".com"))
            {
                MessageBox.Show("El email debe tener un formato válido");
                return false;
            }

            return true;
        }

        // Buscar persona por Id (panel Buscar)
        private async void btnBuscarBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdBuscar.Text, out int id))
            {
                try
                {
                    var resp = await _httpClient.GetAsync($"/personas/{id}");
                    if (resp.IsSuccessStatusCode)
                    {
                        var persona = await resp.Content.ReadFromJsonAsync<PersonaDto>();
                        if (persona != null)
                        {
                            MessageBox.Show($"Persona encontrada:\nID: {persona.Id}\nNombre: {persona.Nombre} {persona.Apellido}\nEmail: {persona.Email}\nTel: {persona.Telefono}\nLegajo: {persona.Legajo}\nTipo: {persona.TipoPersona}", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"No se encontró la persona con ID: {id}", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        private void btnBuscarBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscando ID: " + txtIdBuscar.Text);
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificando ID: " + txtIdModificar.Text);
        }

        private void btnBorrarBorrar_Click(object sender, EventArgs e)
        {
            // Reemplazado por llamada real en btnBorrarBorrar_ClickAsync si el botón estuviera enlazado a ese método.
            MessageBox.Show("Borrando ID: " + txtIdBorrar.Text);
        }

        private void PersonaCrud_Load(object sender, EventArgs e)
        {
            // Inicialización del formulario si es necesaria
        }

        private void TextTelefono_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                FiltrarSoloNumeros(textBox);
            }
        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox textBox) return;

            string texto = textBox.Text;
            string textoFiltrado = "";

            // Filtrar solo caracteres válidos para email
            foreach (char c in texto)
            {
                if (char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_')
                {
                    textoFiltrado += c;
                }
            }

            // Si el texto cambió, actualizar el TextBox
            if (texto != textoFiltrado)
            {
                textBox.Text = textoFiltrado;
                textBox.SelectionStart = textoFiltrado.Length; // Posicionar cursor al final
            }

            // Validación básica de formato email
            if (!string.IsNullOrEmpty(textoFiltrado))
            {
                bool formatoValido = textoFiltrado.Contains("@") &&
                                   textoFiltrado.LastIndexOf('@') < textoFiltrado.LastIndexOf('.') &&
                                   textoFiltrado.LastIndexOf('.') < textoFiltrado.Length - 1;

                if (!formatoValido)
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    textBox.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
            }
        }

                private void btnBuscarBuscar_Click_1_old(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdBuscar.Text, out int id))
            {
                MessageBox.Show("Buscando ID: " + id);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        private void txtIdBuscar_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                FiltrarSoloNumeros(textBox);
            }
        }

        private void txtIdModificar_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                FiltrarSoloNumeros(textBox);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        // Buscar para modificar -> ahora consulta la API y completa los campos de modificación
        private async void BuscarModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdModificar.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }

            try
            {
                var resp = await _httpClient.GetAsync($"/personas/{id}");
                if (resp.IsSuccessStatusCode)
                {
                    var persona = await resp.Content.ReadFromJsonAsync<PersonaDto>();
                    if (persona != null)
                    {
                        txtModificarNombre.Text = persona.Nombre;
                        txtModificarApellido.Text = persona.Apellido;
                        txtModificarDireccion.Text = persona.Direccion;
                        txtModificarEmail.Text = persona.Email;
                        txtModificarTelefono.Text = persona.Telefono;
                        txtModificarFechaNac.Text = persona.FechaNacimiento.ToShortDateString();
                        txtModificarTipoUsuario.Text = persona.TipoPersona;
                        txtModificarIdPlan.Text = persona.IdPlan.ToString();
                        // si tienes IdPlan u otros campos, asignarlos aquí
                        MessageBox.Show("Persona encontrada y cargada para modificar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("ID no encontrado", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCamposModificar();
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

        // Función necesaria para limpiar campos del formulario Modificar
        private void LimpiarCamposModificar()
        {
            txtModificarNombre.Text = "";
            txtModificarApellido.Text = "";
            txtModificarDireccion.Text = "";
            txtModificarEmail.Text = "";
            txtModificarTelefono.Text = "";
            txtModificarFechaNac.Text = "";
            txtModificarTipoUsuario.Text = "";
        }

        // Función necesaria para filtrar solo números en TextBox
        private void FiltrarSoloNumeros(TextBox textBox)
        {
            if (textBox == null) return;

            string texto = textBox.Text;
            string textoFiltrado = "";

            // Filtrar solo números
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    textoFiltrado += c;
                }
            }

            // Si el texto cambió, actualizar el TextBox
            if (texto != textoFiltrado)
            {
                textBox.Text = textoFiltrado;
                textBox.SelectionStart = textoFiltrado.Length; // Posicionar cursor al final
            }
        }

        private void panelModificar_Paint(object sender, PaintEventArgs e)
        {
            // Evento Paint corregido - no debe contener lógica de TextBox
            // Este evento se usa para personalizar el dibujo del panel si es necesario
        }

        // Modificar persona -> PUT /personas/{id}
        private async void btnModificarModificar_Click_1(object sender, EventArgs e)
        {
            var idText = txtIdModificar.Text;
            var nombre = txtModificarNombre.Text;
            var apellido = txtModificarApellido.Text;
            var direccion = txtModificarDireccion.Text;
            var email = txtModificarEmail.Text;
            var telefono = txtModificarTelefono.Text;
            var fechaNacText = txtModificarFechaNac.Text;
            var tipoUsuario = txtModificarTipoUsuario.Text;
            var idPlan = txtModificarIdPlan.Text; 

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }
            if (!int.TryParse(idPlan, out int idp))
            {
                MessageBox.Show("Ingrese un ID de plan válido");
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Nombre y apellido son requeridos");
                return;
            }

            DateTime fechaNac = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(fechaNacText))
            {
                DateTime.TryParse(fechaNacText, out fechaNac);
            }

            // Reemplaza la creación del DTO en btnModificarModificar_Click_1 por la versión correcta con 10 argumentos
            var dto = new PersonaDto(
                id,
                nombre,
                apellido,
                direccion,
                email,
                telefono,
                fechaNac,
                txtModificarLegajo.Text,
                tipoUsuario,
                idp
            );

            try
            {
                var resp = await _httpClient.PutAsJsonAsync($"/personas/{id}", dto);
                if (resp.IsSuccessStatusCode || resp.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show($"Modificado ID: {id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Persona no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al modificar persona: {resp.StatusCode} - {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdBorrar_TextChanged(object sender, EventArgs e)
        {
            var id = txtIdBorrar.Text;
            FiltrarSoloNumeros(txtIdBorrar);
            // Se evita mostrar MessageBox en cada cambio de texto. Dejamos el control para cuando el usuario haga clic en borrar.
        }

        // Eliminar -> DELETE /personas/{id}
        private async void btnBorrarBorrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBorrar.Text) || !int.TryParse(txtIdBorrar.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un Id válido para eliminar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var getResp = await _httpClient.GetAsync($"/personas/{id}");
                if (getResp.IsSuccessStatusCode)
                {
                    var persona = await getResp.Content.ReadFromJsonAsync<PersonaDto>();
                    var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar la persona Id {id} ({persona?.Nombre} {persona?.Apellido})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var delResp = await _httpClient.DeleteAsync($"/personas/{id}");
                        if (delResp.IsSuccessStatusCode || delResp.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show($"Persona con Id: {id} eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdBorrar.Clear();
                        }
                        else if (delResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Persona no encontrada al intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar persona: {delResp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (getResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"No se encontró ninguna persona con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();

        }
    }
}
