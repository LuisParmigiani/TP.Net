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
    public partial class PlanCrud : Form
    {
        public PlanCrud()
        {
            InitializeComponent();
        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    MessageBox.Show($"Plan con ID {id} encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
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
                    txtModificarDescripcion.Text = "Plan Ejemplo";
                    MessageBox.Show($"Plan con ID {id} encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
            }
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            if (int.TryParse(idText, out int id))
            {
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Simular actualización en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    MessageBox.Show($"Plan con ID {id} modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    txtBuscarBuscarId.Text = "1";
                    txtBuscarDescripcion.Text = "Plan Ejemplo";
                    MessageBox.Show($"Plan con ID {id} encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Plan con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarBuscarId_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            string originalText = textBox.Text;
            string filteredText = new string(originalText.Where(char.IsDigit).ToArray());

            if (originalText != filteredText)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = filteredText;
                textBox.SelectionStart = Math.Min(selectionStart, filteredText.Length);
            }
        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            // Deshabilitar edición
            textBox.ReadOnly = true;
        }

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = txtCrearDescripcion.Text;
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Simular creación en base de datos
                MessageBox.Show($"Plan '{descripcion}' creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            const int maxLength = 50;
            if (textBox.Text.Length > maxLength)
            {
                int selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = Math.Min(selectionStart, maxLength);
                MessageBox.Show($"No se permiten más de {maxLength} caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
