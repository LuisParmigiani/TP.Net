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
    public partial class ComisionCrud : Form
    {
        public ComisionCrud()
        {
            InitializeComponent();
        }

        private void txtCrearDescripcion_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                if (txt.Text.Length > 50)
                {
                    MessageBox.Show("La descripción debe tener menos de 50 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    int selStart = txt.SelectionStart;
                    txt.Text = txt.Text.Substring(0, 50);
                    txt.SelectionStart = selStart > 50 ? 50 : selStart;
                }
            }
        }

        private void txtCrearAnoEspecialidad_TextChanged(object sender, EventArgs e)
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

        private void txtCrearIdPlan_TextChanged(object sender, EventArgs e)
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

        private void txtBusarAnoEspecialidad_TextChanged(object sender, EventArgs e)
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

        private void txtBusarIdPlan_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdPlan_TextChanged(object sender, EventArgs e)
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

        private void txtModificarAnoEspecialidad_TextChanged(object sender, EventArgs e)
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

        private void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                if (txt.Text.Length > 50)
                {
                    MessageBox.Show("La descripción debe tener menos de 50 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    int selStart = txt.SelectionStart;
                    txt.Text = txt.Text.Substring(0, 50);
                    txt.SelectionStart = selStart > 50 ? 50 : selStart;
                }
            }
        }

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var descripcion = txtCrearDescripcion.Text;
            var anioEspecialidadText = txtCrearAnoEspecialidad.Text;
            var idPlanText = txtCrearIdPlan.Text;
            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(anioEspecialidadText) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(anioEspecialidadText, out int anioEspecialidad) || !int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("Año de Especialidad e ID de Plan deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Aquí iría la lógica para crear la comisión en la base de datos
            MessageBox.Show("Comisión creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Aquí iría la lógica para buscar la comisión en la base de datos
            MessageBox.Show("Comisión encontrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var descripcion = "Descripción de ejemplo";
            var anioEspecialidad = 2;
            var idPlan = 1;
            txtModificarDescripcion.Text = descripcion;
            txtModificarAnoEspecialidad.Text = anioEspecialidad.ToString();
            txtModificarIdPlan.Text = idPlan.ToString();

        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var descripcion = txtModificarDescripcion.Text;
            var anioEspecialidadText = txtModificarAnoEspecialidad.Text;
            var idPlanText = txtModificarIdPlan.Text;
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(anioEspecialidadText) || string.IsNullOrWhiteSpace(idPlanText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idText, out int id) || !int.TryParse(anioEspecialidadText, out int anioEspecialidad) || !int.TryParse(idPlanText, out int idPlan))
            {
                MessageBox.Show("ID, Año de Especialidad e ID de Plan deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Aquí iría la lógica para modificar la comisión en la base de datos
            MessageBox.Show("Comisión modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idText) && !int.TryParse(idText, out _))
            {
                MessageBox.Show("ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtBusarDescripcion.Text = "ejemplo";
            txtBusarAnoEspecialidad.Text = "2";
            txtBusarIdPlan.Text = "1";

        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtEliminarId.Text;
            if (string.IsNullOrWhiteSpace(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Aquí iría la lógica para buscar la comisión en la base de datos
            MessageBox.Show("Comisión encontrada y eliminada con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PanelCrear_Paint(object sender, PaintEventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud
            .Show();
            this.Hide();
        }
    }
}

