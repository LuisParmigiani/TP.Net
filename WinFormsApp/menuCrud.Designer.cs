namespace WinFormsApp
{
    partial class menuCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AlumnoInscripcion = new Button();
            Comision = new Button();
            Curso = new Button();
            DocenteCurso = new Button();
            Especialidad = new Button();
            Materia = new Button();
            Modulo = new Button();
            Persona = new Button();
            Plan = new Button();
            Usuarios = new Button();
            Volver = new Button();
            SuspendLayout();
            // 
            // AlumnoInscripcion
            // 
            AlumnoInscripcion.Location = new Point(91, 68);
            AlumnoInscripcion.Name = "AlumnoInscripcion";
            AlumnoInscripcion.Size = new Size(279, 23);
            AlumnoInscripcion.TabIndex = 1;
            AlumnoInscripcion.Text = "AlumnoInscripcion";
            AlumnoInscripcion.UseVisualStyleBackColor = true;
            AlumnoInscripcion.Click += AlumnoInscripcion_Click;
            // 
            // Comision
            // 
            Comision.Location = new Point(91, 101);
            Comision.Name = "Comision";
            Comision.Size = new Size(279, 23);
            Comision.TabIndex = 2;
            Comision.Text = "Comision";
            Comision.UseVisualStyleBackColor = true;
            Comision.Click += Comision_Click;
            // 
            // Curso
            // 
            Curso.Location = new Point(91, 134);
            Curso.Name = "Curso";
            Curso.Size = new Size(279, 23);
            Curso.TabIndex = 3;
            Curso.Text = "Curso";
            Curso.UseVisualStyleBackColor = true;
            Curso.Click += Curso_Click;
            // 
            // DocenteCurso
            // 
            DocenteCurso.Location = new Point(91, 170);
            DocenteCurso.Name = "DocenteCurso";
            DocenteCurso.Size = new Size(279, 23);
            DocenteCurso.TabIndex = 4;
            DocenteCurso.Text = "DocenteCurso";
            DocenteCurso.UseVisualStyleBackColor = true;
            DocenteCurso.Click += DocenteCurso_Click;
            // 
            // Especialidad
            // 
            Especialidad.Location = new Point(91, 209);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(279, 23);
            Especialidad.TabIndex = 5;
            Especialidad.Text = "Especialidad";
            Especialidad.UseVisualStyleBackColor = true;
            Especialidad.Click += Especialidad_Click;
            // 
            // Materia
            // 
            Materia.Location = new Point(407, 68);
            Materia.Name = "Materia";
            Materia.Size = new Size(279, 23);
            Materia.TabIndex = 6;
            Materia.Text = "Materia";
            Materia.UseVisualStyleBackColor = true;
            Materia.Click += Materia_Click;
           
            // 
            // Persona
            // 
            Persona.Location = new Point(407, 134);
            Persona.Name = "Persona";
            Persona.Size = new Size(279, 23);
            Persona.TabIndex = 9;
            Persona.Text = "Persona";
            Persona.UseVisualStyleBackColor = true;
            Persona.Click += Persona_Click;
            // 
            // Plan
            // 
            Plan.Location = new Point(407, 170);
            Plan.Name = "Plan";
            Plan.Size = new Size(279, 23);
            Plan.TabIndex = 10;
            Plan.Text = "Plan";
            Plan.UseVisualStyleBackColor = true;
            Plan.Click += Plan_Click;
            // 
            // Usuarios
            // 
            Usuarios.Location = new Point(407, 209);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(279, 23);
            Usuarios.TabIndex = 11;
            Usuarios.Text = "Usuarios";
            Usuarios.UseVisualStyleBackColor = true;
            Usuarios.Click += Usuarios_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(91, 339);
            Volver.Name = "Volver";
            Volver.Size = new Size(595, 61);
            Volver.TabIndex = 12;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // menuCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(Usuarios);
            Controls.Add(Plan);
            Controls.Add(Persona);
            Controls.Add(Modulo);
            Controls.Add(Materia);
            Controls.Add(Especialidad);
            Controls.Add(DocenteCurso);
            Controls.Add(Curso);
            Controls.Add(Comision);
            Controls.Add(AlumnoInscripcion);
            Name = "menuCrud";
            Text = "menuCrud";
            ResumeLayout(false);
        }

        #endregion

        private Button AlumnoInscripcion;
        private Button Comision;
        private Button Curso;
        private Button DocenteCurso;
        private Button Especialidad;
        private Button Materia;
        private Button Modulo;
        private Button Persona;
        private Button Plan;
        private Button Usuarios;
        private Button Volver;
    }
}