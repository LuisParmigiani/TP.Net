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
    public partial class EspecialidadCrud : Form
    {
        public EspecialidadCrud()
        {
            InitializeComponent();
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }

        private void panelCrear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = textBox1.Text;
            MessageBox.Show($"Especialidad '{descripcion}' creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 50)
            {
                textBox1.Text = textBox1.Text.Substring(0, 50);
                textBox1.SelectionStart = textBox1.Text.Length;
                MessageBox.Show("Máximo 50 caracteres permitidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    txtModificarId.Text = "1";
                    txtModificarDescripcion.Text = "Especialidad Ejemplo";
                    MessageBox.Show($"Especialidad con ID {id} encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtBuscarId.SelectionStart = txtBuscarId.Text.Length;
            }
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    txtModificarId.Text = "1";
                    txtModificarDescripcion.Text = "Especialidad Ejemplo";
                    MessageBox.Show($"Especialidad con ID {id} encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtBuscarId.SelectionStart = txtBuscarId.Text.Length;
            }
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular modificación en base de datos
                MessageBox.Show($"Especialidad con ID {id} modificada a '{descripcion}' con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarId.Text;
            if (!string.IsNullOrEmpty(texto) && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarId.Text = new string(texto.Where(char.IsDigit).ToArray());
                txtBuscarId.SelectionStart = txtBuscarId.Text.Length;
            }
        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    txtEliminarId.Text = "1";
                    MessageBox.Show($"Especialidad con ID {id} encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Especialidad con ID {id} no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
