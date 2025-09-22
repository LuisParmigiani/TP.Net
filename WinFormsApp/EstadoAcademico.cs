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
    public partial class EstadoAcademico : Form
    {
        public EstadoAcademico()
        {
            InitializeComponent();
            CargarDatosAcademicos();
        }

        private void CargarDatosAcademicos()
        {
            // Configurar el DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            // Agregar datos de ejemplo que representen materias cursadas/en curso
            dataGridView1.Rows.Add(1, "Matemática I", "2024", "Plan 2025", "Aprobada");
            dataGridView1.Rows.Add(2, "Programación I", "2024", "Plan 2025", "Aprobada");
            dataGridView1.Rows.Add(3, "Historia", "2024", "Plan 2025", "Cursando");
            dataGridView1.Rows.Add(4, "Matemática II", "2025", "Plan 2025", "Inscripto");
            dataGridView1.Rows.Add(5, "Programación II", "2025", "Plan 2025", "Pendiente");
            dataGridView1.Rows.Add(6, "Base de Datos", "2025", "Plan 2025", "No Cursada");

            // Aplicar colores según el estado
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string estado = row.Cells["Estado"].Value?.ToString();
                switch (estado)
                {
                    case "Aprobada":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Cursando":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "Inscripto":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Pendiente":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                    case "No Cursada":
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            MenuAlumno menuAlumno = new MenuAlumno();
            menuAlumno.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar funcionalidad adicional si necesitas
            // manejar clicks en celdas específicas                             
        }
    }
}
