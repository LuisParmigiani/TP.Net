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
            pnlCambioContrasena = new Panel();
            lblTituloCambio = new Label();
            lblNuevaContrasena = new Label();
            txtNuevaContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            btnGuardarContrasena = new Button();
            btnCancelarCambio = new Button();
            btnCambiarContrasena = new Button();
            dgvListaCursos = new DataGridView();
            pnlAlumnos = new Panel();
            btnVolver = new Button();
            lblTitleAlumnos = new Label();
            dgvListaAlumnos = new DataGridView();
            colLeg = new DataGridViewTextBoxColumn();
            colNom = new DataGridViewTextBoxColumn();
            colNota = new DataGridViewTextBoxColumn();
            btnGuardar = new DataGridViewButtonColumn();
            colId = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colCom = new DataGridViewTextBoxColumn();
            btnVer = new DataGridViewButtonColumn();
            BotonRep = new DataGridViewButtonColumn();
            pnlCursos.SuspendLayout();
            pnlCambioContrasena.SuspendLayout();
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
            pnlCursos.Controls.Add(pnlCambioContrasena);
            pnlCursos.Controls.Add(btnCambiarContrasena);
            pnlCursos.Controls.Add(dgvListaCursos);
            pnlCursos.Location = new Point(16, 100);
            pnlCursos.Name = "pnlCursos";
            pnlCursos.Size = new Size(940, 480);
            pnlCursos.TabIndex = 2;
            // 
            // pnlCambioContrasena
            // 
            pnlCambioContrasena.BackColor = Color.White;
            pnlCambioContrasena.BorderStyle = BorderStyle.FixedSingle;
            pnlCambioContrasena.Controls.Add(lblTituloCambio);
            pnlCambioContrasena.Controls.Add(lblNuevaContrasena);
            pnlCambioContrasena.Controls.Add(txtNuevaContrasena);
            pnlCambioContrasena.Controls.Add(lblConfirmarContrasena);
            pnlCambioContrasena.Controls.Add(txtConfirmarContrasena);
            pnlCambioContrasena.Controls.Add(btnGuardarContrasena);
            pnlCambioContrasena.Controls.Add(btnCancelarCambio);
            pnlCambioContrasena.Location = new Point(90, 85);
            pnlCambioContrasena.Name = "pnlCambioContrasena";
            pnlCambioContrasena.Size = new Size(940, 430);
            pnlCambioContrasena.TabIndex = 4;
            pnlCambioContrasena.Visible = false;
            pnlCambioContrasena.Paint += pnlCambioContrasena_Paint;
            // 
            // lblTituloCambio
            // 
            lblTituloCambio.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloCambio.ForeColor = Color.FromArgb(33, 150, 243);
            lblTituloCambio.Location = new Point(270, 50);
            lblTituloCambio.Name = "lblTituloCambio";
            lblTituloCambio.Size = new Size(400, 35);
            lblTituloCambio.TabIndex = 0;
            lblTituloCambio.Text = "Cambiar Contraseña";
            lblTituloCambio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNuevaContrasena
            // 
            lblNuevaContrasena.Font = new Font("Segoe UI", 11F);
            lblNuevaContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            lblNuevaContrasena.Location = new Point(270, 120);
            lblNuevaContrasena.Name = "lblNuevaContrasena";
            lblNuevaContrasena.Size = new Size(200, 25);
            lblNuevaContrasena.TabIndex = 1;
            lblNuevaContrasena.Text = "Nueva Contraseña:";
            lblNuevaContrasena.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Font = new Font("Segoe UI", 11F);
            txtNuevaContrasena.Location = new Point(270, 148);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(400, 27);
            txtNuevaContrasena.TabIndex = 2;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.Font = new Font("Segoe UI", 11F);
            lblConfirmarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirmarContrasena.Location = new Point(270, 190);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(200, 25);
            lblConfirmarContrasena.TabIndex = 3;
            lblConfirmarContrasena.Text = "Confirmar Contraseña:";
            lblConfirmarContrasena.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Font = new Font("Segoe UI", 11F);
            txtConfirmarContrasena.Location = new Point(270, 218);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(400, 27);
            txtConfirmarContrasena.TabIndex = 4;
            // 
            // btnGuardarContrasena
            // 
            btnGuardarContrasena.BackColor = Color.FromArgb(76, 175, 80);
            btnGuardarContrasena.Cursor = Cursors.Hand;
            btnGuardarContrasena.FlatAppearance.BorderSize = 0;
            btnGuardarContrasena.FlatStyle = FlatStyle.Flat;
            btnGuardarContrasena.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuardarContrasena.ForeColor = Color.White;
            btnGuardarContrasena.Location = new Point(460, 270);
            btnGuardarContrasena.Name = "btnGuardarContrasena";
            btnGuardarContrasena.Size = new Size(100, 40);
            btnGuardarContrasena.TabIndex = 5;
            btnGuardarContrasena.Text = "Guardar";
            btnGuardarContrasena.UseVisualStyleBackColor = false;
            btnGuardarContrasena.Click += btnGuardarContrasena_Click;
            // 
            // btnCancelarCambio
            // 
            btnCancelarCambio.BackColor = Color.FromArgb(158, 158, 158);
            btnCancelarCambio.Cursor = Cursors.Hand;
            btnCancelarCambio.FlatAppearance.BorderSize = 0;
            btnCancelarCambio.FlatStyle = FlatStyle.Flat;
            btnCancelarCambio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelarCambio.ForeColor = Color.White;
            btnCancelarCambio.Location = new Point(570, 270);
            btnCancelarCambio.Name = "btnCancelarCambio";
            btnCancelarCambio.Size = new Size(100, 40);
            btnCancelarCambio.TabIndex = 6;
            btnCancelarCambio.Text = "Cancelar";
            btnCancelarCambio.UseVisualStyleBackColor = false;
            btnCancelarCambio.Click += btnCancelarCambio_Click;
            // 
            // btnCambiarContrasena
            // 
            btnCambiarContrasena.BackColor = Color.FromArgb(255, 152, 0);
            btnCambiarContrasena.Cursor = Cursors.Hand;
            btnCambiarContrasena.FlatAppearance.BorderSize = 0;
            btnCambiarContrasena.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasena.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCambiarContrasena.ForeColor = Color.White;
            btnCambiarContrasena.Location = new Point(370, 390);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Padding = new Padding(8);
            btnCambiarContrasena.Size = new Size(200, 40);
            btnCambiarContrasena.TabIndex = 1;
            btnCambiarContrasena.Text = "Cambiar Contraseña";
            btnCambiarContrasena.UseVisualStyleBackColor = false;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click;
            // 
            // botonReporte
            // 
            
            // 
            // dgvListaCursos
            // 
            dgvListaCursos.AllowUserToAddRows = false;
            dgvListaCursos.AllowUserToDeleteRows = false;
            dgvListaCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCursos.Columns.AddRange(new DataGridViewColumn[] { colId, colDesc, colAnio, colCom, btnVer, BotonRep });
            dgvListaCursos.Location = new Point(0, 0);
            dgvListaCursos.Name = "dgvListaCursos";
            dgvListaCursos.Size = new Size(940, 380);
            dgvListaCursos.TabIndex = 0;
            dgvListaCursos.CellContentClick += DgvListaCursos_CellContentClick;
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
            // colId
            // 
            colId.FillWeight = 8.961928F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            // 
            // colDesc
            // 
            colDesc.FillWeight = 26.8857861F;
            colDesc.HeaderText = "Curso";
            colDesc.Name = "colDesc";
            // 
            // colAnio
            // 
            colAnio.FillWeight = 8.961928F;
            colAnio.HeaderText = "Año";
            colAnio.Name = "colAnio";
            // 
            // colCom
            // 
            colCom.FillWeight = 8.961928F;
            colCom.HeaderText = "Comisión";
            colCom.Name = "colCom";
            // 
            // btnVer
            // 
            btnVer.FillWeight = 5.974619F;
            btnVer.HeaderText = "Acciones";
            btnVer.Name = "btnVer";
            btnVer.Text = "Ver Alumnos";
            btnVer.UseColumnTextForButtonValue = true;
            // 
            // BotonRep
            // 
            BotonRep.FillWeight = 5.974619F;
            BotonRep.HeaderText = "Reporte";
            BotonRep.Name = "BotonRep";
            BotonRep.Text = "Reporte";
            BotonRep.UseColumnTextForButtonValue = true;

            // 
            // MenuProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1022, 600);
            Controls.Add(lblHeader);
            Controls.Add(lblAviso);
            Controls.Add(pnlCursos);
            Controls.Add(pnlAlumnos);
            MinimumSize = new Size(800, 480);
            Name = "MenuProfesor";
            Text = "MenuProfesor";
            Load += MenuProfesor_Load;
            pnlCursos.ResumeLayout(false);
            pnlCambioContrasena.ResumeLayout(false);
            pnlCambioContrasena.PerformLayout();
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
        private Button btnCambiarContrasena;
        private Panel pnlCambioContrasena;
        private Label lblTituloCambio;
        private Label lblNuevaContrasena;
        private TextBox txtNuevaContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Button btnGuardarContrasena;
        private Button btnCancelarCambio;
        private DataGridViewButtonColumn BotonRep;
    }
}