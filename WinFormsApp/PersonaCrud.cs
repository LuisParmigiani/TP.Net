using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class PersonaCrud : Form
    {
        // Propiedades para almacenar los datos de la persona
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefono { get; set; } = "";
        public DateTime FechaNac { get; set; }
        public string TipoUsuario { get; set; } = "";

        public PersonaCrud()
        {
            InitializeComponent();
        }

        // Método para el botón Guardar/Cargar del panel Crear
        private void btnGuardarCrear_Click_1(object sender, EventArgs e)
        {
            // Validar campos antes de asignar
            if (!ValidarCamposCrear())
            {
                return; // Detener ejecución si hay errores
            }

            // Asignar valores de los controles a las propiedades
            Nombre = txtNombreCrear.Text;
            Apellido = txtCrearApellido.Text;
            Direccion = txtCrearDireccion.Text;
            Email = txtCrearEmail.Text;
            Telefono = txtCrearTelefono.Text;
            FechaNac = dateTimePicker1.Value;

            // Determinar el tipo de usuario basado en los RadioButtons
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

            MessageBox.Show($"Persona creada:\nNombre: {Nombre}\nApellido: {Apellido}\nTipo: {TipoUsuario}");
        }

        // Función necesaria para validar campos del formulario Crear
        private bool ValidarCamposCrear()
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombreCrear.Text) ||
                        string.IsNullOrWhiteSpace(txtCrearApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCrearDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCrearEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCrearTelefono.Text))
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

        private void btnBuscarBuscar_Click_1(object sender, EventArgs e)
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

        private void BuscarModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdModificar.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }

            if (id == 1)
            {
                // Simular búsqueda de datos para ID = 1
                txtModificarNombre.Text = "Juan";
                txtModificarApellido.Text = "Pérez";
                txtModificarDireccion.Text = "Calle Principal 123";
                txtModificarEmail.Text = "juan.perez@email.com";
                txtModificarTelefono.Text = "5551234567";
                txtModificarFechaNac.Text = new DateTime(1990, 5, 15).ToShortDateString();
                // Nota: Los RadioButtons necesitarían ser agregados al diseñador para funcionar correctamente
                // radioModificarProfesor.Checked = true;
                // radioAlumnoModificar.Checked = false;
            }
            else
            {
                MessageBox.Show("ID no encontrado");
                // Limpiar campos si no se encuentra el ID
                LimpiarCamposModificar();
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

        private void btnModificarModificar_Click_1(object sender, EventArgs e)
        {
            var idText = txtIdModificar.Text;
            var nombre = txtModificarNombre.Text;
            var apellido = txtModificarApellido.Text;
            var direccion = txtModificarDireccion.Text;
            var email = txtModificarEmail.Text;
            var telefono = txtModificarTelefono.Text;
            var fechaNacText = txtModificarFechaNac.Text;
            var tipoUsuario = txtModificarTipoUsuario.Text;

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }
            MessageBox.Show($"Modificando ID: {id}\nNombre: {nombre}\nApellido: {apellido}\nDirección: {direccion}\nEmail: {email}\nTeléfono: {telefono}\nFecha Nac: {fechaNacText}\nTipo Usuario: {tipoUsuario}");
        }

        private void txtIdBorrar_TextChanged(object sender, EventArgs e)
        {
            var id = txtIdBorrar.Text;
            FiltrarSoloNumeros(txtIdBorrar);
            MessageBox.Show("ID a borrar: " + id);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();

        }
    }
}
