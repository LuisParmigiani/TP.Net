namespace WinFormsApp
{
    partial class MenuProfesor
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
            lblHeader = new Label();
            lblAviso = new Label();
            pnlCursos = new Panel();
            dgvListaCursos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colCom = new DataGridViewTextBoxColumn();
            btnVer = new DataGridViewButtonColumn();
            pnlAlumnos = new Panel();
            btnVolver = new Button();
            lblTitleAlumnos = new Label();
            dgvListaAlumnos = new DataGridView();
            colLeg = new DataGridViewTextBoxColumn();
            colNom = new DataGridViewTextBoxColumn();
            colNota = new DataGridViewTextBoxColumn();
            btnGuardar = new DataGridViewButtonColumn();
            pnlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).BeginInit();
            pnlAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.Location = new Point(16, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(146, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Menu Profesor";
            // 
            // lblAviso
            // 
            lblAviso.BackColor = Color.FromArgb(236, 253, 245);
            lblAviso.ForeColor = Color.FromArgb(6, 95, 70);
            lblAviso.Location = new Point(16, 50);
            lblAviso.Name = "lblAviso";
            lblAviso.Padding = new Padding(8);
            lblAviso.Size = new Size(940, 40);
            lblAviso.TabIndex = 1;
            lblAviso.Visible = false;
            // 
            // pnlCursos
            // 
            pnlCursos.Controls.Add(dgvListaCursos);
            pnlCursos.Location = new Point(16, 100);
            pnlCursos.Name = "pnlCursos";
            pnlCursos.Size = new Size(940, 480);
            pnlCursos.TabIndex = 2;
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.AllowUserToAddRows = false;
            dgvListaCursos.AllowUserToDeleteRows = false;
            dgvListaCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCursos.Columns.AddRange(new DataGridViewColumn[] { colId, colDesc, colAnio, colCom, btnVer });
            dgvListaCursos.Location = new Point(0, 0);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.Size = new Size(940, 420);
            dgvListaCursos.TabIndex = 0;
            dgvListaCursos.CellContentClick += dgvListaCursos_CellContentClick_1;
            // 
            // colId
            // 
            colId.FillWeight = 15F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            // 
            // colDesc
            // 
            colDesc.FillWeight = 45F;
            colDesc.HeaderText = "Curso";
            colDesc.Name = "colDesc";
            // 
            // colAnio
            // 
            colAnio.FillWeight = 15F;
            colAnio.HeaderText = "Año";
            colAnio.Name = "colAnio";
            // 
            // colCom
            // 
            colCom.FillWeight = 15F;
            colCom.HeaderText = "Comisión";
            colCom.Name = "colCom";
            // 
            // btnVer
            // 
            btnVer.FillWeight = 10F;
            btnVer.HeaderText = "Acciones";
            btnVer.Name = "btnVer";
            btnVer.Text = "Ver Alumnos";
            btnVer.UseColumnTextForButtonValue = true;
            // 
            // pnlAlumnos
            // 
            pnlAlumnos.Controls.Add(btnVolver);
            pnlAlumnos.Controls.Add(lblTitleAlumnos);
            pnlAlumnos.Controls.Add(dgvListaAlumnos);
            pnlAlumnos.Location = new Point(16, 100);
            pnlAlumnos.Name = "pnlAlumnos";
            pnlAlumnos.Size = new Size(940, 480);
            pnlAlumnos.TabIndex = 3;
            pnlAlumnos.Visible = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.BackColor = Color.FromArgb(239, 68, 68);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(820, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 34);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblTitleAlumnos
            // 
            lblTitleAlumnos.AutoSize = true;
            lblTitleAlumnos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleAlumnos.Location = new Point(6, 10);
            lblTitleAlumnos.Name = "lblTitleAlumnos";
            lblTitleAlumnos.Size = new Size(138, 19);
            lblTitleAlumnos.TabIndex = 1;
            lblTitleAlumnos.Text = "Listado de alumnos";
            // 
            // dgvListaAlumnos
            // 
            dgvListaAlumnos.AllowUserToAddRows = false;
            dgvListaAlumnos.AllowUserToDeleteRows = false;
            dgvListaAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLeg, colNom, colNota, btnGuardar });
            dgvListaAlumnos.Location = new Point(0, 50);
            dgvListaAlumnos.Name = "dgvListaAlumnos";
            dgvListaAlumnos.Size = new Size(940, 420);
            dgvListaAlumnos.TabIndex = 2;
            // 
            // colLeg
            // 
            colLeg.FillWeight = 15F;
            colLeg.HeaderText = "Leg";
            colLeg.Name = "colLeg";
            // 
            // colNom
            // 
            colNom.FillWeight = 45F;
            colNom.HeaderText = "Nombre y Apellido";
            colNom.Name = "colNom";
            // 
            // colNota
            // 
            colNota.FillWeight = 25F;
            colNota.HeaderText = "Nota (-1 libre, 0 regular, 6-10 aprobado)";
            colNota.Name = "colNota";
            // 
            // btnGuardar
            // 
            btnGuardar.FillWeight = 15F;
            btnGuardar.HeaderText = "Acción";
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseColumnTextForButtonValue = true;
            // 
            // MenuProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(980, 600);
            Controls.Add(lblHeader);
            Controls.Add(lblAviso);
            Controls.Add(pnlCursos);
            Controls.Add(pnlAlumnos);
            MinimumSize = new Size(800, 480);
            Name = "MenuProfesor";
            Text = "MenuProfesor";
            pnlCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaCursos).EndInit();
            pnlAlumnos.ResumeLayout(false);
            pnlAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Controls
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pnlCursos;
        private System.Windows.Forms.DataGridView dgvListaCursos;
        private System.Windows.Forms.Panel pnlAlumnos;
        private System.Windows.Forms.DataGridView dgvListaAlumnos;
        private System.Windows.Forms.Button btnVolver;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colCom;
        private DataGridViewButtonColumn btnVer;
        private Label lblTitleAlumnos;
        private DataGridViewTextBoxColumn colLeg;
        private DataGridViewTextBoxColumn colNom;
        private DataGridViewTextBoxColumn colNota;
        private DataGridViewButtonColumn btnGuardar;
    }
}