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
    public partial class AlumnoInscripcionCrud : Form
    {
        // Agrega la declaración del ComboBox 'cmbModificarCondicion' como un campo de la clase AlumnoInscripcionCrud.
        // Esto soluciona el error CS0103 asegurando que el control exista en el contexto actual.
        // Si el control ya existe en el diseñador, asegúrate de que su nombre coincida exactamente.

        private ComboBox cmbModificarCondicion;
        // Agrega la declaración del ComboBox 'cmbCrearCondicion' como un campo de la clase AlumnoInscripcionCrud.
        // Esto soluciona el error CS0103 asegurando que el control exista en el contexto actual.
        // Si el control ya existe en el diseñador, asegúrate de que su nombre coincida exactamente.

        private ComboBox cmbCrearCondicion;

        public AlumnoInscripcionCrud()
        {
            InitializeComponent();


        }

        private void txtCrearIdAlumno_TextChanged(object sender, EventArgs e)
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

        private void txtCrearIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtCrearNota_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                int valor = 0;
                if (!string.IsNullOrEmpty(soloNumeros))
                {
                    valor = int.Parse(soloNumeros);
                    if (valor > 10)
                    {
                        soloNumeros = "10";
                        valor = 10;
                    }
                }
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

        private void txtModificarIdAlumno_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdCurso_TextChanged(object sender, EventArgs e)
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

        private void txtModificarIdNota_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                string soloNumeros = new string(txt.Text.Where(char.IsDigit).ToArray());
                int valor = 0;
                if (!string.IsNullOrEmpty(soloNumeros))
                {
                    valor = int.Parse(soloNumeros);
                    if (valor > 10)
                    {
                        soloNumeros = "10";
                        valor = 10;
                    }
                }
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

        private void btnCrearCrear_Click(object sender, EventArgs e)
        {
            var idAlumnoText = txtCrearIdAlumno.Text;
            var idCursoText = txtCrearIdCurso.Text;
            var notaText = txtCrearNota.Text;
            string condicion = null; // Declarar la variable 'condicion' antes de usarla

            if (radioCrearRegular.Checked)
            {
                condicion = "regular";
            }
            else if (radioCrearLibre.Checked)
            {
                condicion = "libre";
            }
            else if (radioCrearAprobado.Checked)
            {
                condicion = "aprobado";
            }
            if (string.IsNullOrEmpty(idAlumnoText) || string.IsNullOrEmpty(idCursoText) || string.IsNullOrEmpty(notaText) || string.IsNullOrEmpty(condicion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            int idAlumno = int.Parse(idAlumnoText);
            int idCurso = int.Parse(idCursoText);
            int nota = int.Parse(notaText);
            // Aquí puedes agregar la lógica para crear la inscripción del alumno
            MessageBox.Show($"Inscripción creada:\nID Alumno: {idAlumno}\nID Curso: {idCurso}\nNota: {nota}\nCondición: {condicion}");
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            int id = int.Parse(idText);
            // Aquí puedes agregar la lógica para buscar la inscripción del alumno por ID
            txtModificarIdAlumno.Text = "1"; // Ejemplo de ID Alumno
            txtModificarIdCurso.Text = "101"; // Ejemplo de ID Curso
            txtModificarIdNota.Text = "8"; // Ejemplo de Nota
            string condicion = "aprobado";

            if (condicion == "regular")
            {
                radioMoificarRegular.Checked = true;
                radioMoificarRegular.Checked = false;
                radioMoificarAprobado.Checked = false;
            }
            else if (condicion == "libre")
            {
                radioMoificarRegular.Checked = false;
                radioMoificarLibre.Checked = true;
                radioMoificarAprobado.Checked = false;
            }
            else if (condicion == "aprobado")
            {
                radioMoificarRegular.Checked = false;
                radioMoificarLibre.Checked = false;
                radioMoificarAprobado.Checked = true;
            }

        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            var idText = txtModificarId.Text;
            var idAlumnoText = txtModificarIdAlumno.Text;
            var idCursoText = txtModificarIdCurso.Text;
            var notaText = txtModificarIdNota.Text;
            string condicion = null; // Declarar la variable 'condicion' antes de usarla

            if (radioMoificarRegular.Checked)
            {
                condicion = "regular";
            }
            else if (radioMoificarLibre.Checked)
            {
                condicion = "libre";
            }
            else if (radioMoificarAprobado.Checked)
            {
                condicion = "aprobado";
            }
            if (string.IsNullOrEmpty(idText) || string.IsNullOrEmpty(idAlumnoText) || string.IsNullOrEmpty(idCursoText) || string.IsNullOrEmpty(notaText) || string.IsNullOrEmpty(condicion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            int id = int.Parse(idText);
            int idAlumno = int.Parse(idAlumnoText);
            int idCurso = int.Parse(idCursoText);
            int nota = int.Parse(notaText);
            // Aquí puedes agregar la lógica para modificar la inscripción del alumno
            MessageBox.Show($"Inscripción modificada:\nID: {id}\nID Alumno: {idAlumno}\nID Curso: {idCurso}\nNota: {nota}\nCondición: {condicion}");

        }

        private void btnBuscarBuscarId_Click(object sender, EventArgs e)
        {
            var idText = txtBuscarBuscarId.Text;
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            int id = int.Parse(idText);
            txtBuscarIdAlumno.Text = "1"; // Ejemplo de ID Alumno
            txtBuscarIdCurso.Text = "101"; // Ejemplo de ID Curso
            txtBuscarNota.Text = "8"; // Ejemplo de Nota
            string condicion = "aprobado";

            if (condicion == "regular")
            {
                RadioBuscarRegular.Checked = true;
                RadioBuscarRegular.Checked = false;
                RadioBuscarAprobado.Checked = false;
            }
            else if (condicion == "libre")
            {
                RadioBuscarRegular.Checked = false;
                RadioBuscarLibre.Checked = true;
                RadioBuscarAprobado.Checked = false;
            }
            else if (condicion == "aprobado")
            {
                RadioBuscarRegular.Checked = false;
                RadioBuscarLibre.Checked = false;
                RadioBuscarAprobado.Checked = true;
            }


        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            var id = txtEliminarId;
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.");
                return;
            }
            int idEliminar = int.Parse(id.Text);
            // Aquí puedes agregar la lógica para buscar la inscripción del alumno por ID
            MessageBox.Show($"Inscripción con ID {idEliminar} encontrada.");

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
}
