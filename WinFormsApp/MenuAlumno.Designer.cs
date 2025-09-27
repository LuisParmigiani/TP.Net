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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            inscr = new Button();
            EstadoAcademico = new Button();
            panelMenuAlumno = new Panel();
            panelMaterias = new Panel();
            dataGridView1 = new DataGridView();
            Materia = new DataGridViewTextBoxColumn();
            Inscribirme = new DataGridViewButtonColumn();
            VolverMaterias = new Button();
            panelCursos = new Panel();
            VolverCursos = new Button();
            GridCurso = new DataGridView();
            Curso = new DataGridViewTextBoxColumn();
            CursoDescripcion = new DataGridViewTextBoxColumn();
            Anotarme = new DataGridViewButtonColumn();
            panelEsatdoAcademico = new Panel();
            VolverEstadoAcademico = new Button();
            GridEstadoAcademico = new DataGridView();
            EsatdoAcademicoMateria = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            ComisionEsatdoAcademico = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelMenuAlumno.SuspendLayout();
            panelMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCurso).BeginInit();
            panelEsatdoAcademico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridEstadoAcademico).BeginInit();
            SuspendLayout();
            // 
            // inscr
            // 
            inscr.BackColor = Color.FromArgb(33, 150, 243);
            inscr.Cursor = Cursors.Hand;
            inscr.FlatAppearance.BorderSize = 0;
            inscr.FlatStyle = FlatStyle.Flat;
            inscr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            inscr.ForeColor = Color.White;
            inscr.Location = new Point(40, 16);
            inscr.Name = "inscr";
            inscr.Padding = new Padding(8);
            inscr.Size = new Size(420, 56);
            inscr.TabIndex = 0;
            inscr.Text = "Inscripciones a materias";
            inscr.UseVisualStyleBackColor = false;
            inscr.Click += inscr_Click;
            // 
            // EstadoAcademico
            // 
            EstadoAcademico.BackColor = Color.FromArgb(76, 175, 80);
            EstadoAcademico.Cursor = Cursors.Hand;
            EstadoAcademico.FlatAppearance.BorderSize = 0;
            EstadoAcademico.FlatStyle = FlatStyle.Flat;
            EstadoAcademico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EstadoAcademico.ForeColor = Color.White;
            EstadoAcademico.Location = new Point(40, 80);
            EstadoAcademico.Name = "EstadoAcademico";
            EstadoAcademico.Padding = new Padding(8);
            EstadoAcademico.Size = new Size(420, 48);
            EstadoAcademico.TabIndex = 1;
            EstadoAcademico.Text = "Estado académico";
            EstadoAcademico.UseVisualStyleBackColor = false;
            EstadoAcademico.Click += EstadoAcademico_Click;
            // 
            // panelMenuAlumno
            // 
            panelMenuAlumno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMenuAlumno.BackColor = Color.White;
            panelMenuAlumno.BorderStyle = BorderStyle.FixedSingle;
            panelMenuAlumno.Controls.Add(inscr);
            panelMenuAlumno.Controls.Add(EstadoAcademico);
            panelMenuAlumno.Location = new Point(31, 31);
            panelMenuAlumno.Name = "panelMenuAlumno";
            panelMenuAlumno.Size = new Size(530, 140);
            panelMenuAlumno.TabIndex = 2;
            // 
            // panelMaterias
            // 
            panelMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMaterias.BackColor = Color.White;
            panelMaterias.BorderStyle = BorderStyle.FixedSingle;
            panelMaterias.Controls.Add(dataGridView1);
            panelMaterias.Controls.Add(VolverMaterias);
            panelMaterias.Location = new Point(32, 31);
            panelMaterias.Name = "panelMaterias";
            panelMaterias.Size = new Size(530, 226);
            panelMaterias.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Materia, Inscribirme });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 34;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(515, 175);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            // 
            // Inscribirme
            // 
            Inscribirme.HeaderText = "Inscribirme";
            Inscribirme.Name = "Inscribirme";
            Inscribirme.Text = "Inscribirme";
            Inscribirme.UseColumnTextForButtonValue = true;
            // 
            // VolverMaterias
            // 
            VolverMaterias.BackColor = Color.FromArgb(96, 125, 139);
            VolverMaterias.Cursor = Cursors.Hand;
            VolverMaterias.FlatAppearance.BorderSize = 0;
            VolverMaterias.FlatStyle = FlatStyle.Flat;
            VolverMaterias.ForeColor = Color.White;
            VolverMaterias.Location = new Point(3, 184);
            VolverMaterias.Name = "VolverMaterias";
            VolverMaterias.Size = new Size(517, 26);
            VolverMaterias.TabIndex = 1;
            VolverMaterias.Text = "Volver";
            VolverMaterias.UseVisualStyleBackColor = false;
            // 
            // panelCursos
            // 
            panelCursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCursos.BackColor = Color.White;
            panelCursos.BorderStyle = BorderStyle.FixedSingle;
            panelCursos.Controls.Add(VolverCursos);
            panelCursos.Controls.Add(GridCurso);
            panelCursos.Location = new Point(31, 31);
            panelCursos.Name = "panelCursos";
            panelCursos.Size = new Size(530, 226);
            panelCursos.TabIndex = 4;
            // 
            // VolverCursos
            // 
            VolverCursos.BackColor = Color.FromArgb(96, 125, 139);
            VolverCursos.Cursor = Cursors.Hand;
            VolverCursos.FlatAppearance.BorderSize = 0;
            VolverCursos.FlatStyle = FlatStyle.Flat;
            VolverCursos.ForeColor = Color.White;
            VolverCursos.Location = new Point(3, 180);
            VolverCursos.Name = "VolverCursos";
            VolverCursos.Size = new Size(517, 26);
            VolverCursos.TabIndex = 1;
            VolverCursos.Text = "Volver";
            VolverCursos.UseVisualStyleBackColor = false;
            // 
            // GridCurso
            // 
            GridCurso.AllowUserToAddRows = false;
            GridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridCurso.BackgroundColor = Color.White;
            GridCurso.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GridCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCurso.Columns.AddRange(new DataGridViewColumn[] { Curso, CursoDescripcion, Anotarme });
            GridCurso.EnableHeadersVisualStyles = false;
            GridCurso.GridColor = Color.FromArgb(230, 230, 230);
            GridCurso.Location = new Point(0, 3);
            GridCurso.Name = "GridCurso";
            GridCurso.RowTemplate.Height = 34;
            GridCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridCurso.Size = new Size(523, 171);
            GridCurso.TabIndex = 0;
            // 
            // Curso
            // 
            Curso.HeaderText = "Curso";
            Curso.Name = "Curso";
            // 
            // CursoDescripcion
            // 
            CursoDescripcion.HeaderText = "Descripción";
            CursoDescripcion.Name = "CursoDescripcion";
            CursoDescripcion.ReadOnly = true;
            // 
            // Anotarme
            // 
            Anotarme.HeaderText = "Acción";
            Anotarme.Name = "Anotarme";
            Anotarme.Text = "Anotarme";
            Anotarme.UseColumnTextForButtonValue = true;
            // 
            // panelEsatdoAcademico
            // 
            panelEsatdoAcademico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEsatdoAcademico.BackColor = Color.White;
            panelEsatdoAcademico.BorderStyle = BorderStyle.FixedSingle;
            panelEsatdoAcademico.Controls.Add(VolverEstadoAcademico);
            panelEsatdoAcademico.Controls.Add(GridEstadoAcademico);
            panelEsatdoAcademico.Location = new Point(32, 31);
            panelEsatdoAcademico.Name = "panelEsatdoAcademico";
            panelEsatdoAcademico.Size = new Size(530, 226);
            panelEsatdoAcademico.TabIndex = 5;
            // 
            // VolverEstadoAcademico
            // 
            VolverEstadoAcademico.BackColor = Color.FromArgb(96, 125, 139);
            VolverEstadoAcademico.Cursor = Cursors.Hand;
            VolverEstadoAcademico.FlatAppearance.BorderSize = 0;
            VolverEstadoAcademico.FlatStyle = FlatStyle.Flat;
            VolverEstadoAcademico.ForeColor = Color.White;
            VolverEstadoAcademico.Location = new Point(2, 194);
            VolverEstadoAcademico.Name = "VolverEstadoAcademico";
            VolverEstadoAcademico.Size = new Size(517, 26);
            VolverEstadoAcademico.TabIndex = 2;
            VolverEstadoAcademico.Text = "Volver";
            VolverEstadoAcademico.UseVisualStyleBackColor = false;
            VolverEstadoAcademico.Click += VolverEstadoAcademico_Click;
            // 
            // GridEstadoAcademico
            // 
            GridEstadoAcademico.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 250, 250);
            GridEstadoAcademico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            GridEstadoAcademico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridEstadoAcademico.BackgroundColor = Color.White;
            GridEstadoAcademico.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            GridEstadoAcademico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            GridEstadoAcademico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridEstadoAcademico.Columns.AddRange(new DataGridViewColumn[] { EsatdoAcademicoMateria, Condicion, ComisionEsatdoAcademico });
            GridEstadoAcademico.EnableHeadersVisualStyles = false;
            GridEstadoAcademico.GridColor = Color.FromArgb(230, 230, 230);
            GridEstadoAcademico.Location = new Point(0, 0);
            GridEstadoAcademico.Name = "GridEstadoAcademico";
            GridEstadoAcademico.ReadOnly = true;
            GridEstadoAcademico.RowTemplate.Height = 34;
            GridEstadoAcademico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridEstadoAcademico.Size = new Size(523, 188);
            GridEstadoAcademico.TabIndex = 0;
            // 
            // EsatdoAcademicoMateria
            // 
            EsatdoAcademicoMateria.HeaderText = "Materia";
            EsatdoAcademicoMateria.Name = "EsatdoAcademicoMateria";
            EsatdoAcademicoMateria.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.HeaderText = "Condición";
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // ComisionEsatdoAcademico
            // 
            ComisionEsatdoAcademico.HeaderText = "Comisión";
            ComisionEsatdoAcademico.Name = "ComisionEsatdoAcademico";
            ComisionEsatdoAcademico.ReadOnly = true;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(592, 291);
            Controls.Add(panelEsatdoAcademico);
            Controls.Add(panelCursos);
            Controls.Add(panelMaterias);
            Controls.Add(panelMenuAlumno);
            Font = new Font("Segoe UI", 9.75F);
            Name = "MenuAlumno";
            Text = "Menú Alumno";
            panelMenuAlumno.ResumeLayout(false);
            panelMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridCurso).EndInit();
            panelEsatdoAcademico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridEstadoAcademico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button inscr;
        private Button EstadoAcademico;
        private Panel panelMenuAlumno;
        private Panel panelMaterias;

        private Button VolverMaterias;
        private Panel panelCursos;
        private Button VolverCursos;
        private DataGridView        GridCurso;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn CursoDescripcion;
        private Panel panelEsatdoAcademico;
        private DataGridView GridEstadoAcademico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewButtonColumn Anotarme;
        private DataGridViewTextBoxColumn EsatdoAcademicoMateria;
        private DataGridViewTextBoxColumn Condicion;
        private DataGridViewTextBoxColumn ComisionEsatdoAcademico;
        private DataGridView dataGridView1;
        private Button VolverEstadoAcademico;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewButtonColumn Inscribirme;
    }
}