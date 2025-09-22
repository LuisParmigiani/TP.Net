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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void mail_Click(object sender, EventArgs e)
        {
            textboxmail.Focus();
        }

        private void registrarme_Click(object sender, EventArgs e)
        {
            // Lógica para registrar al usuario
            string email = textboxmail.Text;
            string password = textboxpasw.Text;
            string nombre = textboxnom.Text;
            string apellido = textboxape.Text;
            string direccion = textboxdir.Text;
            string nombreUsuario = textboxNombreUsuario.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string tipoUsuario = Profesor.Checked ? "Profesor" : Alumno.Checked ? "Alumno" : "";
            // Validar campos (puedes agregar más validaciones según tus necesidades)
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(tipoUsuario))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            // Aquí puedes agregar la lógica para guardar los datos del usuario en una base de datos o archivo
            MessageBox.Show("Registro exitoso.");
            this.Close(); // Cierra el formulario de registro después de un registro exitoso
        }

        private void textboxmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxpasw_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxape_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxdir_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {
            textboxnom.Focus();
        }

        private void apellido_Click(object sender, EventArgs e)
        {
            textboxape.Focus();
        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {
            textboxNombreUsuario.Focus();
        }

        private void direccion_Click(object sender, EventArgs e)
        {
            textboxdir.Focus();
        }

        private void fechaNac_Click(object sender, EventArgs e)
        {
            fechaNac.Focus();
        }

        private void password_Click(object sender, EventArgs e)
        {
            textboxpasw.Focus();
        }
    }
}
