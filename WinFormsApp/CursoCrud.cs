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
    public partial class CursoCrud : Form
    {
        public CursoCrud()
        {
            InitializeComponent();
        }

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

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCrearIdMateria.Text) ||
                string.IsNullOrWhiteSpace(txtCrearIdComision.Text) ||
                string.IsNullOrWhiteSpace(txtCrearAnioCalendario.Text) ||
                string.IsNullOrWhiteSpace(txtCrearCupo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para crear un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var idMateria = int.Parse(txtCrearIdMateria.Text);
            var idComision = int.Parse(txtCrearIdComision.Text);
            var anioCalendario = int.Parse(txtCrearAnioCalendario.Text);
            var cupo = int.Parse(txtCrearCupo.Text);

            MessageBox.Show($"Crear Curso con IdMateria: {idMateria}, IdComision: {idComision}, AnioCalendario: {anioCalendario}, Cupo: {cupo}");
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

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var id = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un Id para buscar el curso a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (id == "1")
            {
                txtModificarIdMateria.Text = "2";
                txtModificarIdComision.Text = "3";
                txtModificarAnioCalendario.Text = "2023";
                txtModificarCupo.Text = "30";
            }
            else
            {
                MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Buscar Curso con Id: {id}");

        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var id = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un Id para modificar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var idMateria = txtModificarIdMateria.Text;
            var idComision = txtModificarIdComision.Text;
            var anioCalendario = txtModificarAnioCalendario.Text;
            var cupo = txtModificarCupo.Text;
            if (string.IsNullOrWhiteSpace(idMateria) ||
                string.IsNullOrWhiteSpace(idComision) ||
                string.IsNullOrWhiteSpace(anioCalendario) ||
                string.IsNullOrWhiteSpace(cupo))
            {
                MessageBox.Show("Por favor, complete todos los campos para modificar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Modificar Curso con Id: {id}, IdMateria: {idMateria}, IdComision: {idComision}, AnioCalendario: {anioCalendario}, Cupo: {cupo}");
        }

        private void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var id = txtBuscarBuscarId.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un Id para buscar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (id == "1")
            {
                txtBuscarIdMateria.Text = "2";
                txtBuscarIdComision.Text = "3";
                txtBuscarAnioCalendario.Text = "2023";
                txtBuscarCupo.Text = "30";
            }
            else
            {
                MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminarId.Text))
            {
                MessageBox.Show("Por favor, ingrese un Id para buscar el curso a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = txtEliminarId.Text;
            if (id == "1")
            {
                var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el curso con Id: {id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show($"Curso con Id: {id} eliminado exitosamente.");
                    txtEliminarId.Clear();
                }
            }
            else
            {
                MessageBox.Show($"No se encontró ningún curso con Id: {id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud
                = new menuCrud();
            menuCrud.Show();
            this.Close();
        }
    }
}
