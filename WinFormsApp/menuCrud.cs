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
    public partial class menuCrud : Form
    {
        public menuCrud()
        {
            InitializeComponent();
        }

        private void AlumnoInscripcion_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionCrud alumnoInscripcionCrud = new AlumnoInscripcionCrud();
            alumnoInscripcionCrud.Show();
            this.Hide();
        }

        private void Materia_Click(object sender, EventArgs e)
        {
            MateriaCrud materiaCrud = new MateriaCrud();
            materiaCrud.Show();
            this.Hide();
        }

        private void Comision_Click(object sender, EventArgs e)
        {
            ComisionCrud comisionCrud = new ComisionCrud();
            comisionCrud.Show();
            this.Hide();
        }


        private void Curso_Click(object sender, EventArgs e)
        {
            CursoCrud cursoCrud = new CursoCrud();
            cursoCrud.Show();
            this.Hide();
        }

        private void Persona_Click(object sender, EventArgs e)
        {
           PersonaCrud personaCrud = new PersonaCrud();
              personaCrud.Show();
                this.Hide();
        }

        private void DocenteCurso_Click(object sender, EventArgs e)
        {
            DocenteCursoCrud docenteCursoCrud = new DocenteCursoCrud();
            docenteCursoCrud.Show();
            this.Hide();
        }

        private void Plan_Click(object sender, EventArgs e)
        {
            PlanCrud planCrud = new PlanCrud();
            planCrud.Show();
            this.Hide();
        }

        private void Especialidad_Click(object sender, EventArgs e)
        {
            EspecialidadCrud especialidadCrud = new EspecialidadCrud();
            especialidadCrud.Show();
            this.Hide();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            UsuarioCrud usuarioCrud = new UsuarioCrud();
            usuarioCrud.Show();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
