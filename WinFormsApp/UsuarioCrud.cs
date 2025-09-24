using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class UsuarioCrud : Form
    {
        public UsuarioCrud()
        {
            InitializeComponent();
        }

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

        private void txtModificarNombreUsuario_TextChanged(object sender, EventArgs e)
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

        private void btnCrearCrear_Click(object sender, EventArgs e)
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

            MessageBox.Show("Usuario creado exitosamente.");
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            if (idText == "1")
            {
                txtModificarNombreUsuario.Text = "jdoe";
                txtModificarClave.Text = "password123";
                txtModificarNombre.Text = "John";
                txtModificarApellido.Text = "Doe";
                txtModificarMail.Text = "sjhdjaskjdjaskkh@email.com";
                radioModificarHabilitado.Checked = true;
                radioModificarCambioClave.Checked = false;
                txtModificarIdPersona.Text = "1001";
            }

        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var
                nombreUsuario = txtModificarNombreUsuario.Text;
            var clave = txtModificarClave.Text;
            var nombre = txtModificarNombre.Text;
            var apellido = txtModificarApellido.Text;
            var mail = txtModificarMail.Text;
            var idPersonaText = txtModificarIdPersona.Text;
            var habilitado = radioModificarHabilitado.Checked;
            var cambioClave = radioModificarCambioClave.Checked;
            var esMail = System.Text.RegularExpressions.Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!esMail)
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(idPersonaText))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            MessageBox.Show("Usuario modificado exitosamente.");
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarId.Text;
            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            if (idText == "1")
            {
                txtBuscarNombreUsuario.Text = "jdoe";
                txtBuscarClave.Text = "password123";
                txtBuscarNombre.Text = "John";
                txtBuscarApellido.Text = "Doe";
                txtBuscarMail.Text = " sdkjasdkasg@email.com";
                txtBuscarIdPersona.Text = "1001";
                radioBuscarHabilitado.Checked = true;
                radioBuscarCambioClave.Checked = false;
            }
            else
            {
                MessageBox.Show(idText + " no encontrado.");
            }

        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var id = txtEliminarId;
            if (id is null)
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            MessageBox.Show("Usuario eliminado exitosamente.");
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show(this);
            this.Hide();
        }
    }
}
