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
    public partial class InscripcionCurso : Form
    {
        public InscripcionCurso()
        {
            
            InitializeComponent();
        }

        private void InscripcionMateria_Load(object sender, EventArgs e)
        {
            // Crear columna de selección
            DataGridViewCheckBoxColumn colElegir = new DataGridViewCheckBoxColumn();
            colElegir.HeaderText = "Elegir";
            colElegir.Name = "Elegir";
            dataGridView1.Columns.Insert(0, colElegir);
            // Configurar DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name != "Elegir")
                    col.ReadOnly = true; // solo la columna "Elegir" es editable
            }
            // Agregar datos de ejemplo (coincidiendo con las columnas)
            dataGridView1.Rows.Add(false, 1, "A", "08:00", "10:00");
            dataGridView1.Rows.Add(false, 2, "B", "10:00", "12:00");
            dataGridView1.Rows.Add(false, 3, "C", "14:00", "16:00");
            // Asociar evento
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // evitar cabecera
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Elegir")
            {
                // Desmarcar los demás
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                        row.Cells["Elegir"].Value = false;
                }
                // Alternar el valor de la fila seleccionada
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Elegir"].Value ?? false);
                dataGridView1.Rows[e.RowIndex].Cells["Elegir"].Value = !isChecked;
            }
        }
        private void confirmar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Elegir"].Value ?? false))
                {
                    selectedRow = row;
                    break;
                }
            }
            if (selectedRow != null)
            {
                MessageBox.Show($"Curso seleccionado: Id={selectedRow.Cells["Id"].Value}, Comision={selectedRow.Cells["Comision"].Value}, HoraDesde={selectedRow.Cells["HoraDesde"].Value}, HoraHasta={selectedRow.Cells["HoraHasta"].Value}");
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún curso.");
            }
        }
        private void Volver_Click(object sender, EventArgs e)
        {
            InscripcionMaterias inscripcionMaterias = new InscripcionMaterias();
            inscripcionMaterias.Show();
            this.Hide();
        }

    }
}
