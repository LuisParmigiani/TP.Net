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
    public partial class MateriaCrud : Form
    {
        public MateriaCrud()
        {
            InitializeComponent();
        }

        private void txtBuscarHsTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarIdPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsTotales_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarHsSemanales_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarIdPlan_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtModificarHsTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarHsSemanales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtModificarDescripcion.Text.Length > 50)
                MessageBox.Show("La descripción no puede exceder los 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = txtCrearDescripcion.Text;
            var hsSemanales = (int)txtCrearHsSemanales.Value;
            var hsTotales = (int)txtCrearHsTotales.Value;
            var idPlanText = txtCrearIdPlan.Text;
            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("Por favor, ingrese un ID de plan válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Simular creación en base de datos
            MessageBox.Show($"Materia '{descripcion}' creada con éxito.\nHoras Semanales: {hsSemanales}\nHoras Totales: {hsTotales}\nID Plan: {idPlan}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtCrearDescripcion.Text.Length > 50)
                txtCrearDescripcion.Text = txtCrearDescripcion.Text.Substring(0, 50);
        }

        private void txtCrearHsSemanales_ValueChanged(object sender, EventArgs e)
        {
            if (txtCrearHsSemanales.Value > 24)
            {
                MessageBox.Show("El valor máximo permitido es 24.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCrearIdPlan_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtBuscarDescripcion.Text = "Matemáticas";
                    txtBuscarHsSemanales.Text = "4";
                    txtBuscarHsTotales.Text = "64";
                    txtBuscarIdPlan.Text = "2";
                }
                else
                {
                    MessageBox.Show($"Materia con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarBuscarId_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Materia encontrada:\nDescripción: Matemáticas\nHoras Semanales: 4\nHoras Totales: 64\nID Plan: 2", "Borrada con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Materia con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarId_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números en el TextBox
            string texto = txtCrearIdPlan.Text;
            string soloNumeros = new string(texto.Where(char.IsDigit).ToArray());
            if (texto != soloNumeros)
            {
                int pos = txtCrearIdPlan.SelectionStart - 1;
                txtCrearIdPlan.Text = soloNumeros;
                txtCrearIdPlan.SelectionStart = Math.Max(pos, 0);
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarBuscar_Click_1(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (int.TryParse(idText, out int id))
            {
                // Simular búsqueda en base de datos
                if (id == 1) // Ejemplo: si el ID es 1, existe
                {
                    txtModificarDescripcion.Text = "Matemáticas";
                    txtModificarHsSemanales.Value = 4;
                    txtModificarHsTotales.Value = 64;
                    txtModificarIdPlan.Text = "2";
                }
                else
                {
                    MessageBox.Show($"Materia con ID {id} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            var hsSemanales = (int)txtModificarHsSemanales.Value;
            var hsTotales = (int)txtModificarHsTotales.Value;
            var idPlanText = txtModificarIdPlan.Text;
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idText, out int id) || !int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("Por favor, ingrese un ID y un ID de plan válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Simular modificación en base de datos
            MessageBox.Show($"Materia con ID {id} modificada con éxito.\nNueva Descripción: {descripcion}\nNuevas Horas Semanales: {hsSemanales}\nNuevas Horas Totales: {hsTotales}\nNuevo ID Plan: {idPlan}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
