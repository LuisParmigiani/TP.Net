using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class InscripcionMaterias : Form
    {
        public InscripcionMaterias()
        {
            InitializeComponent();

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
            dataGridView1.Rows.Add(false, 1, "Plan 2025", "Matemática", 1, 6);
            dataGridView1.Rows.Add(false, 2, "Plan 2025", "Historia", 2, 4);
            dataGridView1.Rows.Add(false, 3, "Plan 2025", "Programación", 1, 8);

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
                string materia = selectedRow.Cells["Column2"].Value.ToString(); // Nombre de la materia
                MessageBox.Show($"Te has inscrito a la materia: {materia}", "Inscripción Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                InscripcionCurso inscripcionCurso = new InscripcionCurso();
                inscripcionCurso.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una materia para inscribirte.",
                                "Ninguna Materia Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            MenuAlumno menuAlumno = new MenuAlumno();
            menuAlumno.Show();
            this.Hide();
        }
    }
}
