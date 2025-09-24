namespace WinFormsApp
{
    partial class AlumnoInscripcionCrud
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
            btnCrear = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            PanelEliminar = new Panel();
            txtEliminarId = new TextBox();
            LabelEliminarId = new Label();
            btnEliminarBuscar = new Button();
            PanelModificar = new Panel();
            radioMoificarRegular = new RadioButton();
            radioMoificarLibre = new RadioButton();
            radioMoificarAprobado = new RadioButton();
            txtModificarIdNota = new TextBox();
            txtModificarIdCurso = new TextBox();
            txtModificarIdAlumno = new TextBox();
            labelModificarNota = new Label();
            labelModificarCondicion = new Label();
            labelModificarIdCurso = new Label();
            labelModificarIdAlumno = new Label();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscar = new Panel();
            RadioBuscarRegular = new RadioButton();
            RadioBuscarLibre = new RadioButton();
            RadioBuscarAprobado = new RadioButton();
            txtBuscarNota = new TextBox();
            txtBuscarIdCurso = new TextBox();
            txtBuscarIdAlumno = new TextBox();
            LabelBuscarNota = new Label();
            LabelBuscarCondicion = new Label();
            LabelBuscarIdCurso = new Label();
            LabelBuscarIdAlumno = new Label();
            txtBuscarBuscarId = new TextBox();
            btnBuscarBuscarId = new Button();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            radioCrearRegular = new RadioButton();
            radioCrearLibre = new RadioButton();
            radioCrearAprobado = new RadioButton();
            txtCrearNota = new TextBox();
            txtCrearIdCurso = new TextBox();
            txtCrearIdAlumno = new TextBox();
            labelCrearNota = new Label();
            labelCrearCondicion = new Label();
            labelCrearIdCurso = new Label();
            labelCrearIdAlumno = new Label();
            btnCrearCrear = new Button();
            Volver = new Button();
            PanelEliminar.SuspendLayout();
            PanelModificar.SuspendLayout();
            PanelBuscar.SuspendLayout();
            PanelCrear.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(39, 25);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(116, 34);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(207, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 34);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(352, 25);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 34);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(521, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // PanelEliminar
            // 
            PanelEliminar.Controls.Add(txtEliminarId);
            PanelEliminar.Controls.Add(LabelEliminarId);
            PanelEliminar.Controls.Add(btnEliminarBuscar);
            PanelEliminar.Location = new Point(37, 74);
            PanelEliminar.Name = "PanelEliminar";
            PanelEliminar.Size = new Size(679, 245);
            PanelEliminar.TabIndex = 7;
            PanelEliminar.Visible = false;
            // 
            // txtEliminarId
            // 
            txtEliminarId.Location = new Point(106, 21);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(397, 23);
            txtEliminarId.TabIndex = 2;
            txtEliminarId.TextChanged += txtEliminarId_TextChanged;
            // 
            // LabelEliminarId
            // 
            LabelEliminarId.AutoSize = true;
            LabelEliminarId.Location = new Point(12, 25);
            LabelEliminarId.Name = "LabelEliminarId";
            LabelEliminarId.Size = new Size(17, 15);
            LabelEliminarId.TabIndex = 1;
            LabelEliminarId.Text = "Id";
            // 
            // btnEliminarBuscar
            // 
            btnEliminarBuscar.Location = new Point(519, 21);
            btnEliminarBuscar.Name = "btnEliminarBuscar";
            btnEliminarBuscar.Size = new Size(122, 23);
            btnEliminarBuscar.TabIndex = 0;
            btnEliminarBuscar.Text = "Buscar";
            btnEliminarBuscar.UseVisualStyleBackColor = true;
            // 
            // PanelModificar
            // 
            PanelModificar.Controls.Add(radioMoificarRegular);
            PanelModificar.Controls.Add(radioMoificarLibre);
            PanelModificar.Controls.Add(radioMoificarAprobado);
            PanelModificar.Controls.Add(txtModificarIdNota);
            PanelModificar.Controls.Add(txtModificarIdCurso);
            PanelModificar.Controls.Add(txtModificarIdAlumno);
            PanelModificar.Controls.Add(labelModificarNota);
            PanelModificar.Controls.Add(labelModificarCondicion);
            PanelModificar.Controls.Add(labelModificarIdCurso);
            PanelModificar.Controls.Add(labelModificarIdAlumno);
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Location = new Point(31, 74);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(679, 245);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // radioMoificarRegular
            // 
            radioMoificarRegular.AutoSize = true;
            radioMoificarRegular.Location = new Point(545, 119);
            radioMoificarRegular.Name = "radioMoificarRegular";
            radioMoificarRegular.Size = new Size(65, 19);
            radioMoificarRegular.TabIndex = 22;
            radioMoificarRegular.TabStop = true;
            radioMoificarRegular.Text = "Regular";
            radioMoificarRegular.UseVisualStyleBackColor = true;
            // 
            // radioMoificarLibre
            // 
            radioMoificarLibre.AutoSize = true;
            radioMoificarLibre.Location = new Point(343, 119);
            radioMoificarLibre.Name = "radioMoificarLibre";
            radioMoificarLibre.Size = new Size(51, 19);
            radioMoificarLibre.TabIndex = 21;
            radioMoificarLibre.TabStop = true;
            radioMoificarLibre.Text = "Libre";
            radioMoificarLibre.UseVisualStyleBackColor = true;
            // 
            // radioMoificarAprobado
            // 
            radioMoificarAprobado.AutoSize = true;
            radioMoificarAprobado.Location = new Point(120, 119);
            radioMoificarAprobado.Name = "radioMoificarAprobado";
            radioMoificarAprobado.Size = new Size(78, 19);
            radioMoificarAprobado.TabIndex = 20;
            radioMoificarAprobado.TabStop = true;
            radioMoificarAprobado.Text = "Aprobado";
            radioMoificarAprobado.UseVisualStyleBackColor = true;
            // 
            // txtModificarIdNota
            // 
            txtModificarIdNota.Location = new Point(95, 144);
            txtModificarIdNota.Name = "txtModificarIdNota";
            txtModificarIdNota.Size = new Size(544, 23);
            txtModificarIdNota.TabIndex = 19;
            txtModificarIdNota.TextChanged += txtModificarIdNota_TextChanged;
            // 
            // txtModificarIdCurso
            // 
            txtModificarIdCurso.Location = new Point(96, 86);
            txtModificarIdCurso.Name = "txtModificarIdCurso";
            txtModificarIdCurso.Size = new Size(543, 23);
            txtModificarIdCurso.TabIndex = 18;
            txtModificarIdCurso.TextChanged += txtModificarIdCurso_TextChanged;
            // 
            // txtModificarIdAlumno
            // 
            txtModificarIdAlumno.Location = new Point(95, 57);
            txtModificarIdAlumno.Name = "txtModificarIdAlumno";
            txtModificarIdAlumno.Size = new Size(544, 23);
            txtModificarIdAlumno.TabIndex = 17;
            txtModificarIdAlumno.TextChanged += txtModificarIdAlumno_TextChanged;
            // 
            // labelModificarNota
            // 
            labelModificarNota.AutoSize = true;
            labelModificarNota.Location = new Point(23, 144);
            labelModificarNota.Name = "labelModificarNota";
            labelModificarNota.Size = new Size(33, 15);
            labelModificarNota.TabIndex = 16;
            labelModificarNota.Text = "Nota";
            // 
            // labelModificarCondicion
            // 
            labelModificarCondicion.AutoSize = true;
            labelModificarCondicion.Location = new Point(13, 119);
            labelModificarCondicion.Name = "labelModificarCondicion";
            labelModificarCondicion.Size = new Size(62, 15);
            labelModificarCondicion.TabIndex = 15;
            labelModificarCondicion.Text = "Condicion";
            // 
            // labelModificarIdCurso
            // 
            labelModificarIdCurso.AutoSize = true;
            labelModificarIdCurso.Location = new Point(15, 83);
            labelModificarIdCurso.Name = "labelModificarIdCurso";
            labelModificarIdCurso.Size = new Size(48, 15);
            labelModificarIdCurso.TabIndex = 14;
            labelModificarIdCurso.Text = "IdCurso";
            // 
            // labelModificarIdAlumno
            // 
            labelModificarIdAlumno.AutoSize = true;
            labelModificarIdAlumno.Location = new Point(17, 57);
            labelModificarIdAlumno.Name = "labelModificarIdAlumno";
            labelModificarIdAlumno.Size = new Size(60, 15);
            labelModificarIdAlumno.TabIndex = 13;
            labelModificarIdAlumno.Text = "IdAlumno";
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(38, 180);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(590, 23);
            btnModificarModificar.TabIndex = 3;
            btnModificarModificar.Text = "Modificar";
            btnModificarModificar.UseVisualStyleBackColor = true;
            btnModificarModificar.Click += btnModificarModificar_Click;
            // 
            // txtModificarId
            // 
            txtModificarId.Location = new Point(121, 17);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(346, 23);
            txtModificarId.TabIndex = 2;
            txtModificarId.TextChanged += txtModificarId_TextChanged;
            // 
            // labelModificarId
            // 
            labelModificarId.AutoSize = true;
            labelModificarId.Location = new Point(27, 17);
            labelModificarId.Name = "labelModificarId";
            labelModificarId.Size = new Size(17, 15);
            labelModificarId.TabIndex = 1;
            labelModificarId.Text = "Id";
            // 
            // btnModificarBuscar
            // 
            btnModificarBuscar.Location = new Point(524, 17);
            btnModificarBuscar.Name = "btnModificarBuscar";
            btnModificarBuscar.Size = new Size(104, 23);
            btnModificarBuscar.TabIndex = 0;
            btnModificarBuscar.Text = "Buscar";
            btnModificarBuscar.UseVisualStyleBackColor = true;
            btnModificarBuscar.Click += btnModificarBuscar_Click;
            // 
            // PanelBuscar
            // 
            PanelBuscar.Controls.Add(RadioBuscarRegular);
            PanelBuscar.Controls.Add(RadioBuscarLibre);
            PanelBuscar.Controls.Add(RadioBuscarAprobado);
            PanelBuscar.Controls.Add(txtBuscarNota);
            PanelBuscar.Controls.Add(txtBuscarIdCurso);
            PanelBuscar.Controls.Add(txtBuscarIdAlumno);
            PanelBuscar.Controls.Add(LabelBuscarNota);
            PanelBuscar.Controls.Add(LabelBuscarCondicion);
            PanelBuscar.Controls.Add(LabelBuscarIdCurso);
            PanelBuscar.Controls.Add(LabelBuscarIdAlumno);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(labelBuscarId);
            PanelBuscar.Location = new Point(31, 74);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 5;
            PanelBuscar.Visible = false;
            // 
            // RadioBuscarRegular
            // 
            RadioBuscarRegular.AutoSize = true;
            RadioBuscarRegular.Enabled = false;
            RadioBuscarRegular.Location = new Point(564, 129);
            RadioBuscarRegular.Name = "RadioBuscarRegular";
            RadioBuscarRegular.Size = new Size(65, 19);
            RadioBuscarRegular.TabIndex = 22;
            RadioBuscarRegular.TabStop = true;
            RadioBuscarRegular.Text = "Regular";
            RadioBuscarRegular.UseVisualStyleBackColor = true;
            // 
            // RadioBuscarLibre
            // 
            RadioBuscarLibre.AutoSize = true;
            RadioBuscarLibre.Enabled = false;
            RadioBuscarLibre.Location = new Point(362, 129);
            RadioBuscarLibre.Name = "RadioBuscarLibre";
            RadioBuscarLibre.Size = new Size(51, 19);
            RadioBuscarLibre.TabIndex = 21;
            RadioBuscarLibre.TabStop = true;
            RadioBuscarLibre.Text = "Libre";
            RadioBuscarLibre.UseVisualStyleBackColor = true;
            // 
            // RadioBuscarAprobado
            // 
            RadioBuscarAprobado.AutoSize = true;
            RadioBuscarAprobado.Enabled = false;
            RadioBuscarAprobado.Location = new Point(139, 129);
            RadioBuscarAprobado.Name = "RadioBuscarAprobado";
            RadioBuscarAprobado.Size = new Size(78, 19);
            RadioBuscarAprobado.TabIndex = 20;
            RadioBuscarAprobado.TabStop = true;
            RadioBuscarAprobado.Text = "Aprobado";
            RadioBuscarAprobado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNota
            // 
            txtBuscarNota.Enabled = false;
            txtBuscarNota.Location = new Point(114, 154);
            txtBuscarNota.Name = "txtBuscarNota";
            txtBuscarNota.Size = new Size(544, 23);
            txtBuscarNota.TabIndex = 19;
            // 
            // txtBuscarIdCurso
            // 
            txtBuscarIdCurso.Enabled = false;
            txtBuscarIdCurso.Location = new Point(115, 96);
            txtBuscarIdCurso.Name = "txtBuscarIdCurso";
            txtBuscarIdCurso.Size = new Size(543, 23);
            txtBuscarIdCurso.TabIndex = 18;
            // 
            // txtBuscarIdAlumno
            // 
            txtBuscarIdAlumno.Enabled = false;
            txtBuscarIdAlumno.Location = new Point(114, 67);
            txtBuscarIdAlumno.Name = "txtBuscarIdAlumno";
            txtBuscarIdAlumno.Size = new Size(544, 23);
            txtBuscarIdAlumno.TabIndex = 17;
            // 
            // LabelBuscarNota
            // 
            LabelBuscarNota.AutoSize = true;
            LabelBuscarNota.Location = new Point(20, 157);
            LabelBuscarNota.Name = "LabelBuscarNota";
            LabelBuscarNota.Size = new Size(33, 15);
            LabelBuscarNota.TabIndex = 16;
            LabelBuscarNota.Text = "Nota";
            // 
            // LabelBuscarCondicion
            // 
            LabelBuscarCondicion.AutoSize = true;
            LabelBuscarCondicion.Location = new Point(20, 131);
            LabelBuscarCondicion.Name = "LabelBuscarCondicion";
            LabelBuscarCondicion.Size = new Size(62, 15);
            LabelBuscarCondicion.TabIndex = 15;
            LabelBuscarCondicion.Text = "Condicion";
            // 
            // LabelBuscarIdCurso
            // 
            LabelBuscarIdCurso.AutoSize = true;
            LabelBuscarIdCurso.Location = new Point(34, 93);
            LabelBuscarIdCurso.Name = "LabelBuscarIdCurso";
            LabelBuscarIdCurso.Size = new Size(48, 15);
            LabelBuscarIdCurso.TabIndex = 14;
            LabelBuscarIdCurso.Text = "IdCurso";
            // 
            // LabelBuscarIdAlumno
            // 
            LabelBuscarIdAlumno.AutoSize = true;
            LabelBuscarIdAlumno.Location = new Point(36, 67);
            LabelBuscarIdAlumno.Name = "LabelBuscarIdAlumno";
            LabelBuscarIdAlumno.Size = new Size(60, 15);
            LabelBuscarIdAlumno.TabIndex = 13;
            LabelBuscarIdAlumno.Text = "IdAlumno";
            // 
            // txtBuscarBuscarId
            // 
            txtBuscarBuscarId.Location = new Point(92, 19);
            txtBuscarBuscarId.Name = "txtBuscarBuscarId";
            txtBuscarBuscarId.Size = new Size(411, 23);
            txtBuscarBuscarId.TabIndex = 2;
            txtBuscarBuscarId.TextChanged += txtBuscarBuscarId_TextChanged;
            // 
            // btnBuscarBuscarId
            // 
            btnBuscarBuscarId.Location = new Point(574, 21);
            btnBuscarBuscarId.Name = "btnBuscarBuscarId";
            btnBuscarBuscarId.Size = new Size(75, 23);
            btnBuscarBuscarId.TabIndex = 1;
            btnBuscarBuscarId.Text = "BuscarId";
            btnBuscarBuscarId.UseVisualStyleBackColor = true;
            btnBuscarBuscarId.Click += btnBuscarBuscarId_Click;
            // 
            // labelBuscarId
            // 
            labelBuscarId.AutoSize = true;
            labelBuscarId.Location = new Point(23, 24);
            labelBuscarId.Name = "labelBuscarId";
            labelBuscarId.Size = new Size(17, 15);
            labelBuscarId.TabIndex = 0;
            labelBuscarId.Text = "Id";
            // 
            // PanelCrear
            // 
            PanelCrear.Controls.Add(radioCrearRegular);
            PanelCrear.Controls.Add(radioCrearLibre);
            PanelCrear.Controls.Add(radioCrearAprobado);
            PanelCrear.Controls.Add(txtCrearNota);
            PanelCrear.Controls.Add(txtCrearIdCurso);
            PanelCrear.Controls.Add(txtCrearIdAlumno);
            PanelCrear.Controls.Add(labelCrearNota);
            PanelCrear.Controls.Add(labelCrearCondicion);
            PanelCrear.Controls.Add(labelCrearIdCurso);
            PanelCrear.Controls.Add(labelCrearIdAlumno);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(28, 74);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            // 
            // radioCrearRegular
            // 
            radioCrearRegular.AutoSize = true;
            radioCrearRegular.Location = new Point(557, 74);
            radioCrearRegular.Name = "radioCrearRegular";
            radioCrearRegular.Size = new Size(65, 19);
            radioCrearRegular.TabIndex = 12;
            radioCrearRegular.TabStop = true;
            radioCrearRegular.Text = "Regular";
            radioCrearRegular.UseVisualStyleBackColor = true;
            // 
            // radioCrearLibre
            // 
            radioCrearLibre.AutoSize = true;
            radioCrearLibre.Location = new Point(355, 74);
            radioCrearLibre.Name = "radioCrearLibre";
            radioCrearLibre.Size = new Size(51, 19);
            radioCrearLibre.TabIndex = 11;
            radioCrearLibre.TabStop = true;
            radioCrearLibre.Text = "Libre";
            radioCrearLibre.UseVisualStyleBackColor = true;
            // 
            // radioCrearAprobado
            // 
            radioCrearAprobado.AutoSize = true;
            radioCrearAprobado.Location = new Point(132, 74);
            radioCrearAprobado.Name = "radioCrearAprobado";
            radioCrearAprobado.Size = new Size(78, 19);
            radioCrearAprobado.TabIndex = 10;
            radioCrearAprobado.TabStop = true;
            radioCrearAprobado.Text = "Aprobado";
            radioCrearAprobado.UseVisualStyleBackColor = true;
            // 
            // txtCrearNota
            // 
            txtCrearNota.Location = new Point(107, 99);
            txtCrearNota.Name = "txtCrearNota";
            txtCrearNota.Size = new Size(544, 23);
            txtCrearNota.TabIndex = 9;
            txtCrearNota.TextChanged += txtCrearNota_TextChanged;
            // 
            // txtCrearIdCurso
            // 
            txtCrearIdCurso.Location = new Point(107, 41);
            txtCrearIdCurso.Name = "txtCrearIdCurso";
            txtCrearIdCurso.Size = new Size(543, 23);
            txtCrearIdCurso.TabIndex = 7;
            txtCrearIdCurso.TextChanged += txtCrearIdCurso_TextChanged;
            // 
            // txtCrearIdAlumno
            // 
            txtCrearIdAlumno.Location = new Point(107, 12);
            txtCrearIdAlumno.Name = "txtCrearIdAlumno";
            txtCrearIdAlumno.Size = new Size(544, 23);
            txtCrearIdAlumno.TabIndex = 6;
            txtCrearIdAlumno.TextChanged += txtCrearIdAlumno_TextChanged;
            // 
            // labelCrearNota
            // 
            labelCrearNota.AutoSize = true;
            labelCrearNota.Location = new Point(13, 102);
            labelCrearNota.Name = "labelCrearNota";
            labelCrearNota.Size = new Size(33, 15);
            labelCrearNota.TabIndex = 4;
            labelCrearNota.Text = "Nota";
            // 
            // labelCrearCondicion
            // 
            labelCrearCondicion.AutoSize = true;
            labelCrearCondicion.Location = new Point(13, 76);
            labelCrearCondicion.Name = "labelCrearCondicion";
            labelCrearCondicion.Size = new Size(62, 15);
            labelCrearCondicion.TabIndex = 3;
            labelCrearCondicion.Text = "Condicion";
            // 
            // labelCrearIdCurso
            // 
            labelCrearIdCurso.AutoSize = true;
            labelCrearIdCurso.Location = new Point(27, 38);
            labelCrearIdCurso.Name = "labelCrearIdCurso";
            labelCrearIdCurso.Size = new Size(48, 15);
            labelCrearIdCurso.TabIndex = 2;
            labelCrearIdCurso.Text = "IdCurso";
            // 
            // labelCrearIdAlumno
            // 
            labelCrearIdAlumno.AutoSize = true;
            labelCrearIdAlumno.Location = new Point(29, 12);
            labelCrearIdAlumno.Name = "labelCrearIdAlumno";
            labelCrearIdAlumno.Size = new Size(60, 15);
            labelCrearIdAlumno.TabIndex = 1;
            labelCrearIdAlumno.Text = "IdAlumno";
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(58, 158);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(564, 45);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "Crear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            btnCrearCrear.Click += btnCrearCrear_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(48, 343);
            Volver.Name = "Volver";
            Volver.Size = new Size(655, 23);
            Volver.TabIndex = 8;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // AlumnoInscripcionCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 663);
            Controls.Add(PanelCrear);
            Controls.Add(Volver);
            Controls.Add(PanelModificar);
            Controls.Add(PanelBuscar);
            Controls.Add(PanelEliminar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Name = "AlumnoInscripcionCrud";
            Text = "AlumnoInscripcionCrud";
            PanelEliminar.ResumeLayout(false);
            PanelEliminar.PerformLayout();
            PanelModificar.ResumeLayout(false);
            PanelModificar.PerformLayout();
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            PanelCrear.ResumeLayout(false);
            PanelCrear.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Panel PanelEliminar;
        private Label LabelEliminarId;
        private Button btnEliminarBuscar;
        private TextBox txtEliminarId;
        private Panel PanelModificar;
        private TextBox txtModificarId;
        private Label labelModificarId;
        private Button btnModificarBuscar;
        private TextBox txtModificarDescripcion;
        private Label labelModificarDescripcion;
        private Button btnModificarModificar;
        private Panel PanelBuscar;
        private TextBox txtBuscarDescripcion;
        private Label labelBuscarDescripcion;
        private TextBox txtBuscarBuscarId;
        private Button btnBuscarBuscarId;
        private Label labelBuscarId;
        private Panel PanelCrear;
        private Label labelCrearDescripcion;
        private TextBox txtCrearDescripcion;
        private Button btnCrearCrear;

        // Event handlers for main buttons
        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = true;
            PanelBuscar.Visible = false;
            PanelModificar.Visible = false;
            PanelEliminar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscar.Visible = true;
            PanelModificar.Visible = false;
            PanelEliminar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscar.Visible = false;
            PanelModificar.Visible = true;
            PanelEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscar.Visible = false;
            PanelModificar.Visible = false;
            PanelEliminar.Visible = true;
        }
        private Label labelCrearNota;
        private Label labelCrearCondicion;
        private Label labelCrearIdCurso;
        private Label labelCrearIdAlumno;
        private TextBox txtCrearNota;
        private TextBox txtCrearIdCurso;
        private TextBox txtCrearIdAlumno;
        private RadioButton radioCrearRegular;
        private RadioButton radioCrearLibre;
        private RadioButton radioCrearAprobado;
        private RadioButton radioMoificarRegular;
        private RadioButton radioMoificarLibre;
        private RadioButton radioMoificarAprobado;
        private TextBox txtModificarIdNota;
        private TextBox txtModificarIdCurso;
        private TextBox txtModificarIdAlumno;
        private Label labelModificarNota;
        private Label labelModificarCondicion;
        private Label labelModificarIdCurso;
        private Label labelModificarIdAlumno;
        private RadioButton RadioBuscarRegular;
        private RadioButton RadioBuscarLibre;
        private RadioButton RadioBuscarAprobado;
        private TextBox txtBuscarNota;
        private TextBox txtBuscarIdCurso;
        private TextBox txtBuscarIdAlumno;
        private Label LabelBuscarNota;
        private Label LabelBuscarCondicion;
        private Label LabelBuscarIdCurso;
        private Label LabelBuscarIdAlumno;
        private Button Volver;
    }
}