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
    public partial class DocenteCursoCrud : Form
    {
        public DocenteCursoCrud()
        {
            InitializeComponent();
        }

        private void txtCrearIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtCrearIdDocente_TextChanged(object sender, EventArgs e)
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

        private void txtBuscarIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdDocente_TextChanged(object sender, EventArgs e)
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

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var idCursoText = txtCrearIdCurso.Text;
            var idDocenteText = txtCrearIdDocente.Text;
            var cargo = txtCrearCargo.Text;
            if (string.IsNullOrWhiteSpace(idCursoText) || string.IsNullOrWhiteSpace(idDocenteText) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            MessageBox.Show("DocenteCurso creado exitosamente.");
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }
            if (idText == "1")
            {
                txtModificarIdCurso.Text = "101";
                txtModificarIdDocente.Text = "202";
                txtModificarCargo.Text = "Profesor";
            }
            else
            {
                MessageBox.Show("DocenteCurso no encontrado.");
            }
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var idCursoText = txtModificarIdCurso.Text;
            var idDocenteText = txtModificarIdDocente.Text;
            var cargo = txtModificarCargo.Text;
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(idCursoText) || string.IsNullOrWhiteSpace(idDocenteText) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            MessageBox.Show("DocenteCurso modificado exitosamente.");
        }

        private void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }
            if (idText == "1")
            {
                txtBuscarIdCurso.Text = "101";
                txtBuscarIdDocente.Text = "202";
                txtBuscarCargo.Text = "Profesor";
            }
            else
            {
                MessageBox.Show("DocenteCurso no encontrado.");
            }
        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }
            if (idText == "1")
            {
                MessageBox.Show("DocenteCurso eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("DocenteCurso no encontrado.");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
