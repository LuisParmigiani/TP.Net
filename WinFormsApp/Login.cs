using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que necesites cuando cambie el texto del password
            // Por ejemplo, validaciones o cambios de interfaz
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            // esto abre el formulario de registro
            Registro registroForm = new Registro();
            registroForm.Show();
            this.Hide(); // Oculto el login (opcional)
        }

        private bool EsValidoElMail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void LogIni_Click(object sender, EventArgs e)
        {
            string correo = mail.Text;
            string clave = password.Text;

            if (correo == "" || clave == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!EsValidoElMail(correo))
            {
                MessageBox.Show("Correo inválido. Por favor, ingrese un formato válido (ejemplo@dominio.com).");
                return;
            }

            // Por ahora, mostramos los datos en un MessageBox
            MessageBox.Show($"Correo: {correo}\nContraseña: {clave}");
            MenuAlumno menuAlumno = new MenuAlumno();
            menuAlumno.Show();
            this.Hide();
        }

        private void mailLabel_Click(object sender, EventArgs e)
        {
            mail.Focus();
        }

        private void passLabel_Click(object sender, EventArgs e)
        {
            password.Focus();
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cruds_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
