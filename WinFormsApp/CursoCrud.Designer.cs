namespace WinFormsApp
{
    partial class CursoCrud
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
            txtModificarDescripcion = new TextBox();
            labelModificarDescripcion = new Label();
            txtModificarCupo = new TextBox();
            txtModificarAnioCalendario = new TextBox();
            txtModificarIdComision = new TextBox();
            txtModificarIdMateria = new TextBox();
            labelModificarCupo = new Label();
            labelModificarAnioCalendario = new Label();
            labelModificarIdComision = new Label();
            btnModificarModificar = new Button();
            labelModificarIdMateria = new Label();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscar = new Panel();
            txtBuscarDescripcion = new TextBox();
            labelBuscarDescripcion = new Label();
            txtBuscarCupo = new TextBox();
            txtBuscarAnioCalendario = new TextBox();
            txtBuscarIdComision = new TextBox();
            txtBuscarIdMateria = new TextBox();
            labelBuscarCupo = new Label();
            labelBuscarAnioCalendario = new Label();
            labelBuscarIdComision = new Label();
            labelBuscarIdMateria = new Label();
            txtBuscarBuscarId = new TextBox();
            btnBuscarBuscarId = new Button();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            txtCrearDescripcion = new TextBox();
            labelCrearDescripcion = new Label();
            txtCrearCupo = new TextBox();
            txtCrearAnioCalendario = new TextBox();
            txtCrearIdComision = new TextBox();
            txtCrearIdMateria = new TextBox();
            labelCrearCupo = new Label();
            labelCrearAnioCalendario = new Label();
            labelCrearIdComision = new Label();
            labelCrearIdMateria = new Label();
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
            PanelEliminar.Location = new Point(12, 77);
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
            btnEliminarBuscar.Click += btnEliminarBuscar_Click;
            // 
            // PanelModificar
            // 
            PanelModificar.Controls.Add(txtModificarDescripcion);
            PanelModificar.Controls.Add(labelModificarDescripcion);
            PanelModificar.Controls.Add(txtModificarCupo);
            PanelModificar.Controls.Add(txtModificarAnioCalendario);
            PanelModificar.Controls.Add(txtModificarIdComision);
            PanelModificar.Controls.Add(txtModificarIdMateria);
            PanelModificar.Controls.Add(labelModificarCupo);
            PanelModificar.Controls.Add(labelModificarAnioCalendario);
            PanelModificar.Controls.Add(labelModificarIdComision);
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(labelModificarIdMateria);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Location = new Point(850, 339);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(679, 253);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // txtModificarDescripcion
            // 
            txtModificarDescripcion.Location = new Point(115, 182);
            txtModificarDescripcion.Name = "txtModificarDescripcion";
            txtModificarDescripcion.Size = new Size(544, 23);
            txtModificarDescripcion.TabIndex = 18;
            // 
            // labelModificarDescripcion
            // 
            labelModificarDescripcion.AutoSize = true;
            labelModificarDescripcion.Location = new Point(30, 189);
            labelModificarDescripcion.Name = "labelModificarDescripcion";
            labelModificarDescripcion.Size = new Size(69, 15);
            labelModificarDescripcion.TabIndex = 17;
            labelModificarDescripcion.Text = "Descripcion";
            // 
            // txtModificarCupo
            // 
            txtModificarCupo.Location = new Point(115, 153);
            txtModificarCupo.Name = "txtModificarCupo";
            txtModificarCupo.Size = new Size(544, 23);
            txtModificarCupo.TabIndex = 16;
            txtModificarCupo.TextChanged += txtModificarCupo_TextChanged;
            // 
            // txtModificarAnioCalendario
            // 
            txtModificarAnioCalendario.Location = new Point(114, 119);
            txtModificarAnioCalendario.Name = "txtModificarAnioCalendario";
            txtModificarAnioCalendario.Size = new Size(545, 23);
            txtModificarAnioCalendario.TabIndex = 15;
            txtModificarAnioCalendario.TextChanged += txtModificarAnioCalendario_TextChanged;
            // 
            // txtModificarIdComision
            // 
            txtModificarIdComision.Location = new Point(114, 87);
            txtModificarIdComision.Name = "txtModificarIdComision";
            txtModificarIdComision.Size = new Size(545, 23);
            txtModificarIdComision.TabIndex = 14;
            txtModificarIdComision.TextChanged += txtModificarIdComision_TextChanged;
            // 
            // txtModificarIdMateria
            // 
            txtModificarIdMateria.Location = new Point(114, 52);
            txtModificarIdMateria.Name = "txtModificarIdMateria";
            txtModificarIdMateria.Size = new Size(545, 23);
            txtModificarIdMateria.TabIndex = 13;
            txtModificarIdMateria.TextChanged += txtModificarIdMateria_TextChanged;
            // 
            // labelModificarCupo
            // 
            labelModificarCupo.AutoSize = true;
            labelModificarCupo.Location = new Point(30, 161);
            labelModificarCupo.Name = "labelModificarCupo";
            labelModificarCupo.Size = new Size(36, 15);
            labelModificarCupo.TabIndex = 12;
            labelModificarCupo.Text = "Cupo";
            // 
            // labelModificarAnioCalendario
            // 
            labelModificarAnioCalendario.AutoSize = true;
            labelModificarAnioCalendario.Location = new Point(9, 127);
            labelModificarAnioCalendario.Name = "labelModificarAnioCalendario";
            labelModificarAnioCalendario.Size = new Size(89, 15);
            labelModificarAnioCalendario.TabIndex = 11;
            labelModificarAnioCalendario.Text = "AnioCalendario";
            // 
            // labelModificarIdComision
            // 
            labelModificarIdComision.AutoSize = true;
            labelModificarIdComision.Location = new Point(30, 95);
            labelModificarIdComision.Name = "labelModificarIdComision";
            labelModificarIdComision.Size = new Size(68, 15);
            labelModificarIdComision.TabIndex = 10;
            labelModificarIdComision.Text = "IdComision";
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(86, 222);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(590, 23);
            btnModificarModificar.TabIndex = 3;
            btnModificarModificar.Text = "Modificar";
            btnModificarModificar.UseVisualStyleBackColor = true;
            btnModificarModificar.Click += btnModificarModificar_Click;
            // 
            // labelModificarIdMateria
            // 
            labelModificarIdMateria.AutoSize = true;
            labelModificarIdMateria.Location = new Point(30, 65);
            labelModificarIdMateria.Name = "labelModificarIdMateria";
            labelModificarIdMateria.Size = new Size(57, 15);
            labelModificarIdMateria.TabIndex = 9;
            labelModificarIdMateria.Text = "IdMateria";
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
            labelModificarId.Location = new Point(30, 17);
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
            PanelBuscar.Controls.Add(txtBuscarDescripcion);
            PanelBuscar.Controls.Add(labelBuscarDescripcion);
            PanelBuscar.Controls.Add(txtBuscarCupo);
            PanelBuscar.Controls.Add(txtBuscarAnioCalendario);
            PanelBuscar.Controls.Add(txtBuscarIdComision);
            PanelBuscar.Controls.Add(txtBuscarIdMateria);
            PanelBuscar.Controls.Add(labelBuscarCupo);
            PanelBuscar.Controls.Add(labelBuscarAnioCalendario);
            PanelBuscar.Controls.Add(labelBuscarIdComision);
            PanelBuscar.Controls.Add(labelBuscarIdMateria);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(labelBuscarId);
            PanelBuscar.Location = new Point(850, 77);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 5;
            PanelBuscar.Visible = false;
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.Location = new Point(115, 197);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(544, 23);
            txtBuscarDescripcion.TabIndex = 18;
            // 
            // labelBuscarDescripcion
            // 
            labelBuscarDescripcion.AutoSize = true;
            labelBuscarDescripcion.Enabled = false;
            labelBuscarDescripcion.Location = new Point(34, 197);
            labelBuscarDescripcion.Name = "labelBuscarDescripcion";
            labelBuscarDescripcion.Size = new Size(69, 15);
            labelBuscarDescripcion.TabIndex = 17;
            labelBuscarDescripcion.Text = "Descripcion";
            // 
            // txtBuscarCupo
            // 
            txtBuscarCupo.Enabled = false;
            txtBuscarCupo.Location = new Point(115, 161);
            txtBuscarCupo.Name = "txtBuscarCupo";
            txtBuscarCupo.Size = new Size(544, 23);
            txtBuscarCupo.TabIndex = 16;
            txtBuscarCupo.TextChanged += txtBuscarCupo_TextChanged;
            // 
            // txtBuscarAnioCalendario
            // 
            txtBuscarAnioCalendario.Enabled = false;
            txtBuscarAnioCalendario.Location = new Point(114, 127);
            txtBuscarAnioCalendario.Name = "txtBuscarAnioCalendario";
            txtBuscarAnioCalendario.Size = new Size(545, 23);
            txtBuscarAnioCalendario.TabIndex = 15;
            txtBuscarAnioCalendario.TextChanged += txtBuscarAnioCalendario_TextChanged;
            // 
            // txtBuscarIdComision
            // 
            txtBuscarIdComision.Enabled = false;
            txtBuscarIdComision.Location = new Point(114, 95);
            txtBuscarIdComision.Name = "txtBuscarIdComision";
            txtBuscarIdComision.Size = new Size(545, 23);
            txtBuscarIdComision.TabIndex = 14;
            txtBuscarIdComision.TextChanged += txtBuscarIdComision_TextChanged;
            // 
            // txtBuscarIdMateria
            // 
            txtBuscarIdMateria.Enabled = false;
            txtBuscarIdMateria.Location = new Point(114, 60);
            txtBuscarIdMateria.Name = "txtBuscarIdMateria";
            txtBuscarIdMateria.Size = new Size(545, 23);
            txtBuscarIdMateria.TabIndex = 13;
            txtBuscarIdMateria.TextChanged += txtBuscarIdMateria_TextChanged;
            // 
            // labelBuscarCupo
            // 
            labelBuscarCupo.AutoSize = true;
            labelBuscarCupo.Location = new Point(34, 161);
            labelBuscarCupo.Name = "labelBuscarCupo";
            labelBuscarCupo.Size = new Size(36, 15);
            labelBuscarCupo.TabIndex = 12;
            labelBuscarCupo.Text = "Cupo";
            // 
            // labelBuscarAnioCalendario
            // 
            labelBuscarAnioCalendario.AutoSize = true;
            labelBuscarAnioCalendario.Location = new Point(19, 127);
            labelBuscarAnioCalendario.Name = "labelBuscarAnioCalendario";
            labelBuscarAnioCalendario.Size = new Size(89, 15);
            labelBuscarAnioCalendario.TabIndex = 11;
            labelBuscarAnioCalendario.Text = "AnioCalendario";
            // 
            // labelBuscarIdComision
            // 
            labelBuscarIdComision.AutoSize = true;
            labelBuscarIdComision.Location = new Point(30, 95);
            labelBuscarIdComision.Name = "labelBuscarIdComision";
            labelBuscarIdComision.Size = new Size(68, 15);
            labelBuscarIdComision.TabIndex = 10;
            labelBuscarIdComision.Text = "IdComision";
            // 
            // labelBuscarIdMateria
            // 
            labelBuscarIdMateria.AutoSize = true;
            labelBuscarIdMateria.Location = new Point(30, 65);
            labelBuscarIdMateria.Name = "labelBuscarIdMateria";
            labelBuscarIdMateria.Size = new Size(57, 15);
            labelBuscarIdMateria.TabIndex = 9;
            labelBuscarIdMateria.Text = "IdMateria";
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
            PanelCrear.Controls.Add(txtCrearDescripcion);
            PanelCrear.Controls.Add(labelCrearDescripcion);
            PanelCrear.Controls.Add(txtCrearCupo);
            PanelCrear.Controls.Add(txtCrearAnioCalendario);
            PanelCrear.Controls.Add(txtCrearIdComision);
            PanelCrear.Controls.Add(txtCrearIdMateria);
            PanelCrear.Controls.Add(labelCrearCupo);
            PanelCrear.Controls.Add(labelCrearAnioCalendario);
            PanelCrear.Controls.Add(labelCrearIdComision);
            PanelCrear.Controls.Add(labelCrearIdMateria);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(12, 339);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            // 
            // txtCrearDescripcion
            // 
            txtCrearDescripcion.Location = new Point(106, 153);
            txtCrearDescripcion.Name = "txtCrearDescripcion";
            txtCrearDescripcion.Size = new Size(546, 23);
            txtCrearDescripcion.TabIndex = 10;
            txtCrearDescripcion.TextChanged += txtCrearDescripcion_TextChanged;
            // 
            // labelCrearDescripcion
            // 
            labelCrearDescripcion.AutoSize = true;
            labelCrearDescripcion.Location = new Point(27, 161);
            labelCrearDescripcion.Name = "labelCrearDescripcion";
            labelCrearDescripcion.Size = new Size(69, 15);
            labelCrearDescripcion.TabIndex = 9;
            labelCrearDescripcion.Text = "Descripcion";
            // 
            // txtCrearCupo
            // 
            txtCrearCupo.Location = new Point(108, 121);
            txtCrearCupo.Name = "txtCrearCupo";
            txtCrearCupo.Size = new Size(544, 23);
            txtCrearCupo.TabIndex = 8;
            txtCrearCupo.TextChanged += txtCrearCupo_TextChanged;
            // 
            // txtCrearAnioCalendario
            // 
            txtCrearAnioCalendario.Location = new Point(107, 87);
            txtCrearAnioCalendario.Name = "txtCrearAnioCalendario";
            txtCrearAnioCalendario.Size = new Size(545, 23);
            txtCrearAnioCalendario.TabIndex = 7;
            txtCrearAnioCalendario.TextChanged += txtCrearAnioCalendario_TextChanged;
            // 
            // txtCrearIdComision
            // 
            txtCrearIdComision.Location = new Point(107, 55);
            txtCrearIdComision.Name = "txtCrearIdComision";
            txtCrearIdComision.Size = new Size(545, 23);
            txtCrearIdComision.TabIndex = 6;
            txtCrearIdComision.TextChanged += txtCrearIdComision_TextChanged;
            // 
            // txtCrearIdMateria
            // 
            txtCrearIdMateria.Location = new Point(107, 20);
            txtCrearIdMateria.Name = "txtCrearIdMateria";
            txtCrearIdMateria.Size = new Size(545, 23);
            txtCrearIdMateria.TabIndex = 5;
            txtCrearIdMateria.TextChanged += txtCrearIdMateria_TextChanged;
            // 
            // labelCrearCupo
            // 
            labelCrearCupo.AutoSize = true;
            labelCrearCupo.Location = new Point(27, 121);
            labelCrearCupo.Name = "labelCrearCupo";
            labelCrearCupo.Size = new Size(36, 15);
            labelCrearCupo.TabIndex = 4;
            labelCrearCupo.Text = "Cupo";
            // 
            // labelCrearAnioCalendario
            // 
            labelCrearAnioCalendario.AutoSize = true;
            labelCrearAnioCalendario.Location = new Point(12, 87);
            labelCrearAnioCalendario.Name = "labelCrearAnioCalendario";
            labelCrearAnioCalendario.Size = new Size(89, 15);
            labelCrearAnioCalendario.TabIndex = 3;
            labelCrearAnioCalendario.Text = "AnioCalendario";
            // 
            // labelCrearIdComision
            // 
            labelCrearIdComision.AutoSize = true;
            labelCrearIdComision.Location = new Point(23, 55);
            labelCrearIdComision.Name = "labelCrearIdComision";
            labelCrearIdComision.Size = new Size(68, 15);
            labelCrearIdComision.TabIndex = 2;
            labelCrearIdComision.Text = "IdComision";
            // 
            // labelCrearIdMateria
            // 
            labelCrearIdMateria.AutoSize = true;
            labelCrearIdMateria.Location = new Point(23, 25);
            labelCrearIdMateria.Name = "labelCrearIdMateria";
            labelCrearIdMateria.Size = new Size(57, 15);
            labelCrearIdMateria.TabIndex = 1;
            labelCrearIdMateria.Text = "IdMateria";
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(27, 189);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(564, 45);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "Crear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            btnCrearCrear.Click += btnCrearCrear_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(838, 25);
            Volver.Name = "Volver";
            Volver.Size = new Size(671, 23);
            Volver.TabIndex = 8;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // CursoCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 623);
            Controls.Add(Volver);
            Controls.Add(PanelBuscar);
            Controls.Add(PanelModificar);
            Controls.Add(PanelCrear);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Controls.Add(PanelEliminar);
            Name = "CursoCrud";
            Text = "CursoCrud";
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
        private TextBox txtCrearCupo;
        private TextBox txtCrearAnioCalendario;
        private TextBox txtCrearIdComision;
        private TextBox txtCrearIdMateria;
        private Label labelCrearCupo;
        private Label labelCrearAnioCalendario;
        private Label labelCrearIdComision;
        private Label labelCrearIdMateria;
        private TextBox txtModificarCupo;
        private TextBox txtModificarAnioCalendario;
        private TextBox txtModificarIdComision;
        private TextBox txtModificarIdMateria;
        private Label labelModificarCupo;
        private Label labelModificarAnioCalendario;
        private Label labelModificarIdComision;
        private Label labelModificarIdMateria;
        private TextBox txtBuscarCupo;
        private TextBox txtBuscarAnioCalendario;
        private TextBox txtBuscarIdComision;
        private TextBox txtBuscarIdMateria;
        private Label labelBuscarCupo;
        private Label labelBuscarAnioCalendario;
        private Label labelBuscarIdComision;
        private Label labelBuscarIdMateria;
        private Button Volver;
        
    }
}