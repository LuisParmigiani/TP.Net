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
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }

        private void inscr_Click(object sender, EventArgs e)
        {
            InscripcionMaterias inscripcionMaterias = new InscripcionMaterias();
            inscripcionMaterias.Show();
            this.Hide();
        }

        private void EstadoAcademico_Click(object sender, EventArgs e)
        {
            EstadoAcademico estadoAcademico = new EstadoAcademico();
            estadoAcademico.Show();
            this.Hide();
        }

        private void InscripcionExamenes_Click(object sender, EventArgs e)
        {
            InscripcionExamenes inscripcionExamenes = new InscripcionExamenes();
            inscripcionExamenes.Show();
            this.Hide();
        }
    }
}
