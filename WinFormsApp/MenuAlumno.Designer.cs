namespace WinFormsApp
{
    partial class MenuAlumno
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
            inscr = new Button();
            EstadoAcademico = new Button();
            InscripcionExamenes = new Button();
            SuspendLayout();
            // 
            // inscr
            // 
            inscr.Location = new Point(260, 120);
            inscr.Name = "inscr";
            inscr.Size = new Size(273, 23);
            inscr.TabIndex = 0;
            inscr.Text = "Inscripciones a materias";
            inscr.UseVisualStyleBackColor = true;
            inscr.Click += inscr_Click;
            // 
            // EstadoAcademico
            // 
            EstadoAcademico.Location = new Point(260, 160);
            EstadoAcademico.Name = "EstadoAcademico";
            EstadoAcademico.Size = new Size(273, 24);
            EstadoAcademico.TabIndex = 1;
            EstadoAcademico.Text = "Estado Academico";
            EstadoAcademico.UseVisualStyleBackColor = true;
            EstadoAcademico.Click += EstadoAcademico_Click;
            // 
            // InscripcionExamenes
            // 
            InscripcionExamenes.Location = new Point(260, 201);
            InscripcionExamenes.Name = "InscripcionExamenes";
            InscripcionExamenes.Size = new Size(273, 23);
            InscripcionExamenes.TabIndex = 2;
            InscripcionExamenes.Text = "Inscripcion a Examenes";
            InscripcionExamenes.UseVisualStyleBackColor = true;
            InscripcionExamenes.Click += InscripcionExamenes_Click;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InscripcionExamenes);
            Controls.Add(EstadoAcademico);
            Controls.Add(inscr);
            Name = "MenuAlumno";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button inscr;
        private Button EstadoAcademico;
        private Button InscripcionExamenes;
    }
}