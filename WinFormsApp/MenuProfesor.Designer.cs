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
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 600);
            Text = "MenuProfesor";
            // 
            // lblHeader
            // 
            lblHeader = new Label();
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.Location = new Point(16, 16);
            lblHeader.Text = "Menu Profesor";
            Controls.Add(lblHeader);
            // 
            // lblAviso
            // Mensaje de estado / aviso temporal
            // 
            lblAviso = new Label();
            lblAviso.AutoSize = false;
            lblAviso.Size = new Size(940, 40);
            lblAviso.Location = new Point(16, 50);
            lblAviso.BackColor = Color.FromArgb(236, 253, 245);
            lblAviso.ForeColor = Color.FromArgb(6, 95, 70);
            lblAviso.Padding = new Padding(8);
            lblAviso.Visible = false;
            Controls.Add(lblAviso);
            // 
            // pnlCursos
            // Panel que contiene la lista de cursos (vista principal)
            // 
            pnlCursos = new Panel();
            pnlCursos.Location = new Point(16, 100);
            pnlCursos.Size = new Size(940, 480);
            pnlCursos.BorderStyle = BorderStyle.None;
            Controls.Add(pnlCursos);
            // 
            // dgvListaCursos
            // DataGridView que muestra cursos disponibles y un botón para ver alumnos
            // 
            dgvListaCursos = new DataGridView();
            dgvListaCursos.AllowUserToAddRows = false;
            dgvListaCursos.AllowUserToDeleteRows = false;
            dgvListaCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCursos.Location = new Point(0, 0);
            dgvListaCursos.Size = new Size(940, 420);
            dgvListaCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Columns: Id, Curso, Año, Comision, Accion button
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.FillWeight = 15;
            dgvListaCursos.Columns.Add(colId);
            DataGridViewTextBoxColumn colDesc = new DataGridViewTextBoxColumn();
            colDesc.Name = "Descripcion";
            colDesc.HeaderText = "Curso";
            colDesc.FillWeight = 45;
            dgvListaCursos.Columns.Add(colDesc);
            DataGridViewTextBoxColumn colAnio = new DataGridViewTextBoxColumn();
            colAnio.Name = "Anio";
            colAnio.HeaderText = "Año";
            colAnio.FillWeight = 15;
            dgvListaCursos.Columns.Add(colAnio);
            DataGridViewTextBoxColumn colCom = new DataGridViewTextBoxColumn();
            colCom.Name = "Comision";
            colCom.HeaderText = "Comisión";
            colCom.FillWeight = 15;
            dgvListaCursos.Columns.Add(colCom);
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "ColVerAlumnos";
            btnVer.HeaderText = "Acciones";
            btnVer.Text = "Ver Alumnos";
            btnVer.UseColumnTextForButtonValue = true;
            btnVer.FillWeight = 10;
            dgvListaCursos.Columns.Add(btnVer);
            pnlCursos.Controls.Add(dgvListaCursos);
            // 
            // pnlAlumnos
            // Panel que muestra listado de alumnos y permite subir notas
            // 
            pnlAlumnos = new Panel();
            pnlAlumnos.Location = new Point(16, 100);
            pnlAlumnos.Size = new Size(940, 480);
            pnlAlumnos.BorderStyle = BorderStyle.None;
            pnlAlumnos.Visible = false;
            Controls.Add(pnlAlumnos);
            // 
            // btnVolver
            // Botón para volver de la vista de alumnos a la lista de cursos
            // 
            btnVolver = new Button();
            btnVolver.Text = "Volver";
            btnVolver.BackColor = Color.FromArgb(239, 68, 68);
            btnVolver.ForeColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(820, 6);
            btnVolver.Size = new Size(100, 34);
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAlumnos.Controls.Add(btnVolver);
            // 
            // lblTitleAlumnos
            // Encabezado de la vista de alumnos
            // 
            Label lblTitleAlumnos = new Label();
            lblTitleAlumnos.Text = "Listado de alumnos";
            lblTitleAlumnos.Location = new Point(6, 10);
            lblTitleAlumnos.AutoSize = true;
            lblTitleAlumnos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pnlAlumnos.Controls.Add(lblTitleAlumnos);
            // 
            // dgvListaAlumnos
            // DataGridView para mostrar alumnos y permitir ingreso de nota y guardado
            // 
            dgvListaAlumnos = new DataGridView();
            dgvListaAlumnos.AllowUserToAddRows = false;
            dgvListaAlumnos.AllowUserToDeleteRows = false;
            dgvListaAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaAlumnos.Location = new Point(0, 50);
            dgvListaAlumnos.Size = new Size(940, 420);
            dgvListaAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewTextBoxColumn colLeg = new DataGridViewTextBoxColumn();
            colLeg.Name = "Legajo";
            colLeg.HeaderText = "Leg";
            colLeg.FillWeight = 15;
            dgvListaAlumnos.Columns.Add(colLeg);
            DataGridViewTextBoxColumn colNom = new DataGridViewTextBoxColumn();
            colNom.Name = "NombreApellido";
            colNom.HeaderText = "Nombre y Apellido";
            colNom.FillWeight = 45;
            dgvListaAlumnos.Columns.Add(colNom);
            // Nota column as editable text box
            DataGridViewTextBoxColumn colNota = new DataGridViewTextBoxColumn();
            colNota.Name = "Nota";
            colNota.HeaderText = "Nota (-1 libre, 0 regular, 6-10 aprobado)";
            colNota.FillWeight = 25;
            dgvListaAlumnos.Columns.Add(colNota);
            DataGridViewButtonColumn btnGuardar = new DataGridViewButtonColumn();
            btnGuardar.Name = "ColGuardarNota";
            btnGuardar.HeaderText = "Acción";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseColumnTextForButtonValue = true;
            btnGuardar.FillWeight = 15;
            dgvListaAlumnos.Columns.Add(btnGuardar);
            pnlAlumnos.Controls.Add(dgvListaAlumnos);
            // Add simple styling
            BackColor = Color.WhiteSmoke;
            MinimumSize = new Size(800, 480);
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
    }
}