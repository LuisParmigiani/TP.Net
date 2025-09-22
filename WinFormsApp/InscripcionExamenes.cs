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
    public partial class InscripcionExamenes : Form
    {
        public InscripcionExamenes()
        {
            InitializeComponent();
            CargarExamenes();
        }

        private void CargarExamenes()
        {
            // Configurar el DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Agregar datos de ejemplo de exámenes disponibles
            dataGridView1.Rows.Add(1, "Matemática I", "15/12/2024", "Plan 2025", "2024");
            dataGridView1.Rows.Add(2, "Programación I", "18/12/2024", "Plan 2025", "2024");
            dataGridView1.Rows.Add(3, "Historia", "20/12/2024", "Plan 2025", "2024");
            dataGridView1.Rows.Add(4, "Física I", "22/12/2024", "Plan 2025", "2024");
            dataGridView1.Rows.Add(5, "Química General", "10/01/2025", "Plan 2025", "2025");
            dataGridView1.Rows.Add(6, "Matemática II", "15/01/2025", "Plan 2025", "2025");

            // Aplicar formato alternado a las filas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            // Configurar el estilo del botón
            dataGridView1.Columns["Inscribirse"].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.Columns["Inscribirse"].DefaultCellStyle.ForeColor = Color.DarkBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en la columna de botones
            if (e.ColumnIndex == dataGridView1.Columns["Inscribirse"].Index && e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idExamen = row.Cells["Id"].Value.ToString();
                string materia = row.Cells["Materia"].Value.ToString();
                string fecha = row.Cells["Fecha"].Value.ToString();
                string plan = row.Cells["Plan"].Value.ToString();
                string año = row.Cells["Año"].Value.ToString();

                // Mostrar mensaje de confirmación
                DialogResult resultado = MessageBox.Show(
                    $"¿Deseas inscribirte al examen de {materia}?\n\n" +
                    $"Fecha: {fecha}\n" +
                    $"Plan: {plan}\n" +
                    $"Año: {año}",
                    "Confirmar Inscripción",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Simular inscripción exitosa
                    MessageBox.Show(
                        $"¡Te has inscrito exitosamente al examen de {materia}!\n\n" +
                        $"Fecha del examen: {fecha}\n" +
                        $"Recuerda presentarte 15 minutos antes.",
                        "Inscripción Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Cambiar el color de la fila para indicar que ya está inscrito
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    
                    // Deshabilitar el botón de inscripción para esta fila
                    row.Cells["Inscribirse"].Value = "Inscrito";
                    row.Cells["Inscribirse"].Style.BackColor = Color.LightGreen;
                    row.Cells["Inscribirse"].ReadOnly = true;
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            MenuAlumno menuAlumno = new MenuAlumno();
            menuAlumno.Show();
            this.Hide();
        }
    }
}
