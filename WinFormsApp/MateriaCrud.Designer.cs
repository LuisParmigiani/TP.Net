namespace WinFormsApp
{
    partial class MateriaCrud
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
            PanelBuscar = new Panel();
            txtBuscarHsTotales = new NumericUpDown();
            txtBuscarHsSemanales = new NumericUpDown();
            txtBuscarIdPlan = new TextBox();
            labelBuscarIdPlan = new Label();
            labelBuscarHsTotales = new Label();
            labelBuscarHsSemanales = new Label();
            labelBuscarDescripcion = new Label();
            txtBuscarDescripcion = new TextBox();
            txtEliminarId = new TextBox();
            LabelEliminarId = new Label();
            btnEliminarBuscar = new Button();
            PanelModificar = new Panel();
            txtModificarHsTotales = new NumericUpDown();
            btnBuscarBuscarId = new Button();
            txtModificarHsSemanales = new NumericUpDown();
            txtModificarIdPlan = new TextBox();
            labelModifiacarIdPlan = new Label();
            labelModifiacarHsTotales = new Label();
            labelModifiacarHsSemanale = new Label();
            labelModifiacarDescripcion = new Label();
            txtModificarDescripcion = new TextBox();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscarliminar = new Panel();
            txtBuscarBuscarId = new TextBox();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            txtCrearHsTotales = new NumericUpDown();
            txtCrearHsSemanales = new NumericUpDown();
            txtCrearDescripcion = new TextBox();
            labelCrearIdPlan = new Label();
            labelCrearHsTotales = new Label();
            labelCrearHsSemanales = new Label();
            labelCrearDescripcion = new Label();
            txtCrearIdPlan = new TextBox();
            btnCrearCrear = new Button();
            Volver = new Button();
            PanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBuscarHsTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBuscarHsSemanales).BeginInit();
            PanelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtModificarHsTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtModificarHsSemanales).BeginInit();
            PanelBuscarliminar.SuspendLayout();
            PanelCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCrearHsTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCrearHsSemanales).BeginInit();
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
            btnEliminar.Location = new Point(620, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // PanelBuscar
            // 
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(txtBuscarHsTotales);
            PanelBuscar.Controls.Add(txtBuscarHsSemanales);
            PanelBuscar.Controls.Add(txtBuscarIdPlan);
            PanelBuscar.Controls.Add(labelBuscarIdPlan);
            PanelBuscar.Controls.Add(labelBuscarHsTotales);
            PanelBuscar.Controls.Add(labelBuscarHsSemanales);
            PanelBuscar.Controls.Add(labelBuscarDescripcion);
            PanelBuscar.Controls.Add(txtBuscarDescripcion);
            PanelBuscar.Controls.Add(LabelEliminarId);
            PanelBuscar.Location = new Point(12, 356);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 7;
            PanelBuscar.Visible = false;
            // 
            // txtBuscarHsTotales
            // 
            txtBuscarHsTotales.Enabled = false;
            txtBuscarHsTotales.Location = new Point(106, 126);
            txtBuscarHsTotales.Name = "txtBuscarHsTotales";
            txtBuscarHsTotales.Size = new Size(554, 23);
            txtBuscarHsTotales.TabIndex = 19;
            // 
            // txtBuscarHsSemanales
            // 
            txtBuscarHsSemanales.Enabled = false;
            txtBuscarHsSemanales.Location = new Point(106, 100);
            txtBuscarHsSemanales.Name = "txtBuscarHsSemanales";
            txtBuscarHsSemanales.Size = new Size(554, 23);
            txtBuscarHsSemanales.TabIndex = 18;
            // 
            // txtBuscarIdPlan
            // 
            txtBuscarIdPlan.Enabled = false;
            txtBuscarIdPlan.Location = new Point(106, 157);
            txtBuscarIdPlan.Name = "txtBuscarIdPlan";
            txtBuscarIdPlan.Size = new Size(554, 23);
            txtBuscarIdPlan.TabIndex = 17;
            txtBuscarIdPlan.TextChanged += txtBuscarIdPlan_TextChanged;
            // 
            // labelBuscarIdPlan
            // 
            labelBuscarIdPlan.AutoSize = true;
            labelBuscarIdPlan.Location = new Point(40, 157);
            labelBuscarIdPlan.Name = "labelBuscarIdPlan";
            labelBuscarIdPlan.Size = new Size(40, 15);
            labelBuscarIdPlan.TabIndex = 16;
            labelBuscarIdPlan.Text = "IdPlan";
            // 
            // labelBuscarHsTotales
            // 
            labelBuscarHsTotales.AutoSize = true;
            labelBuscarHsTotales.Location = new Point(25, 128);
            labelBuscarHsTotales.Name = "labelBuscarHsTotales";
            labelBuscarHsTotales.Size = new Size(58, 15);
            labelBuscarHsTotales.TabIndex = 15;
            labelBuscarHsTotales.Text = "HsTotales";
            // 
            // labelBuscarHsSemanales
            // 
            labelBuscarHsSemanales.AutoSize = true;
            labelBuscarHsSemanales.Location = new Point(21, 102);
            labelBuscarHsSemanales.Name = "labelBuscarHsSemanales";
            labelBuscarHsSemanales.Size = new Size(77, 15);
            labelBuscarHsSemanales.TabIndex = 14;
            labelBuscarHsSemanales.Text = "HsSemanales";
            // 
            // labelBuscarDescripcion
            // 
            labelBuscarDescripcion.AutoSize = true;
            labelBuscarDescripcion.Location = new Point(25, 69);
            labelBuscarDescripcion.Name = "labelBuscarDescripcion";
            labelBuscarDescripcion.Size = new Size(69, 15);
            labelBuscarDescripcion.TabIndex = 13;
            labelBuscarDescripcion.Text = "Descripcion";
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.Enabled = false;
            txtBuscarDescripcion.Location = new Point(106, 66);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(554, 23);
            txtBuscarDescripcion.TabIndex = 10;
            txtBuscarDescripcion.TextChanged += txtBuscarDescripcion_TextChanged;
            // 
            // txtEliminarId
            // 
            txtEliminarId.Location = new Point(85, 26);
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
            btnEliminarBuscar.Location = new Point(530, 26);
            btnEliminarBuscar.Name = "btnEliminarBuscar";
            btnEliminarBuscar.Size = new Size(122, 23);
            btnEliminarBuscar.TabIndex = 0;
            btnEliminarBuscar.Text = "Buscar";
            btnEliminarBuscar.UseVisualStyleBackColor = true;
            btnEliminarBuscar.Click += btnEliminarBuscar_Click;
            // 
            // PanelModificar
            // 
            PanelModificar.Controls.Add(txtModificarHsTotales);
            PanelModificar.Controls.Add(txtModificarHsSemanales);
            PanelModificar.Controls.Add(txtModificarIdPlan);
            PanelModificar.Controls.Add(labelModifiacarIdPlan);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Controls.Add(labelModifiacarHsTotales);
            PanelModificar.Controls.Add(labelModifiacarHsSemanale);
            PanelModificar.Controls.Add(labelModifiacarDescripcion);
            PanelModificar.Controls.Add(txtModificarDescripcion);
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Location = new Point(878, 83);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(682, 245);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // txtModificarHsTotales
            // 
            txtModificarHsTotales.Location = new Point(101, 121);
            txtModificarHsTotales.Name = "txtModificarHsTotales";
            txtModificarHsTotales.Size = new Size(551, 23);
            txtModificarHsTotales.TabIndex = 27;
            // 
            // btnBuscarBuscarId
            // 
            btnBuscarBuscarId.Location = new Point(542, 26);
            btnBuscarBuscarId.Name = "btnBuscarBuscarId";
            btnBuscarBuscarId.Size = new Size(75, 23);
            btnBuscarBuscarId.TabIndex = 1;
            btnBuscarBuscarId.Text = "BuscarId";
            btnBuscarBuscarId.UseVisualStyleBackColor = true;
            btnBuscarBuscarId.Click += btnBuscarBuscarId_Click;
            // 
            // txtModificarHsSemanales
            // 
            txtModificarHsSemanales.Location = new Point(101, 92);
            txtModificarHsSemanales.Name = "txtModificarHsSemanales";
            txtModificarHsSemanales.Size = new Size(551, 23);
            txtModificarHsSemanales.TabIndex = 26;
            // 
            // txtModificarIdPlan
            // 
            txtModificarIdPlan.Location = new Point(101, 150);
            txtModificarIdPlan.Name = "txtModificarIdPlan";
            txtModificarIdPlan.Size = new Size(554, 23);
            txtModificarIdPlan.TabIndex = 25;
            txtModificarIdPlan.TextChanged += txtModificarIdPlan_TextChanged;
            // 
            // labelModifiacarIdPlan
            // 
            labelModifiacarIdPlan.AutoSize = true;
            labelModifiacarIdPlan.Location = new Point(27, 153);
            labelModifiacarIdPlan.Name = "labelModifiacarIdPlan";
            labelModifiacarIdPlan.Size = new Size(40, 15);
            labelModifiacarIdPlan.TabIndex = 24;
            labelModifiacarIdPlan.Text = "IdPlan";
            // 
            // labelModifiacarHsTotales
            // 
            labelModifiacarHsTotales.AutoSize = true;
            labelModifiacarHsTotales.Location = new Point(12, 118);
            labelModifiacarHsTotales.Name = "labelModifiacarHsTotales";
            labelModifiacarHsTotales.Size = new Size(58, 15);
            labelModifiacarHsTotales.TabIndex = 23;
            labelModifiacarHsTotales.Text = "HsTotales";
            // 
            // labelModifiacarHsSemanale
            // 
            labelModifiacarHsSemanale.AutoSize = true;
            labelModifiacarHsSemanale.Location = new Point(8, 92);
            labelModifiacarHsSemanale.Name = "labelModifiacarHsSemanale";
            labelModifiacarHsSemanale.Size = new Size(77, 15);
            labelModifiacarHsSemanale.TabIndex = 22;
            labelModifiacarHsSemanale.Text = "HsSemanales";
            // 
            // labelModifiacarDescripcion
            // 
            labelModifiacarDescripcion.AutoSize = true;
            labelModifiacarDescripcion.Location = new Point(12, 59);
            labelModifiacarDescripcion.Name = "labelModifiacarDescripcion";
            labelModifiacarDescripcion.Size = new Size(69, 15);
            labelModifiacarDescripcion.TabIndex = 21;
            labelModifiacarDescripcion.Text = "Descripcion";
            // 
            // txtModificarDescripcion
            // 
            txtModificarDescripcion.Location = new Point(98, 56);
            txtModificarDescripcion.Name = "txtModificarDescripcion";
            txtModificarDescripcion.Size = new Size(554, 23);
            txtModificarDescripcion.TabIndex = 18;
            txtModificarDescripcion.TextChanged += txtModificarDescripcion_TextChanged;
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(54, 198);
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
            btnModificarBuscar.Location = new Point(516, 21);
            btnModificarBuscar.Name = "btnModificarBuscar";
            btnModificarBuscar.Size = new Size(104, 23);
            btnModificarBuscar.TabIndex = 0;
            btnModificarBuscar.Text = "Buscar";
            btnModificarBuscar.UseVisualStyleBackColor = true;
            btnModificarBuscar.Click += btnModificarBuscar_Click_1;
            // 
            // PanelBuscarliminar
            // 
            PanelBuscarliminar.Controls.Add(labelBuscarId);
            PanelBuscarliminar.Controls.Add(btnEliminarBuscar);
            PanelBuscarliminar.Controls.Add(txtEliminarId);
            PanelBuscarliminar.Location = new Point(878, 356);
            PanelBuscarliminar.Name = "PanelBuscarliminar";
            PanelBuscarliminar.Size = new Size(679, 245);
            PanelBuscarliminar.TabIndex = 5;
            PanelBuscarliminar.Visible = false;
            // 
            // txtBuscarBuscarId
            // 
            txtBuscarBuscarId.Location = new Point(90, 22);
            txtBuscarBuscarId.Name = "txtBuscarBuscarId";
            txtBuscarBuscarId.Size = new Size(411, 23);
            txtBuscarBuscarId.TabIndex = 2;
            txtBuscarBuscarId.TextChanged += txtBuscarBuscarId_TextChanged;
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
            PanelCrear.Controls.Add(txtCrearHsTotales);
            PanelCrear.Controls.Add(txtCrearHsSemanales);
            PanelCrear.Controls.Add(txtCrearDescripcion);
            PanelCrear.Controls.Add(labelCrearIdPlan);
            PanelCrear.Controls.Add(labelCrearHsTotales);
            PanelCrear.Controls.Add(labelCrearHsSemanales);
            PanelCrear.Controls.Add(labelCrearDescripcion);
            PanelCrear.Controls.Add(txtCrearIdPlan);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(12, 83);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            // 
            // txtCrearHsTotales
            // 
            txtCrearHsTotales.Location = new Point(90, 86);
            txtCrearHsTotales.Name = "txtCrearHsTotales";
            txtCrearHsTotales.Size = new Size(553, 23);
            txtCrearHsTotales.TabIndex = 10;
            // 
            // txtCrearHsSemanales
            // 
            txtCrearHsSemanales.Location = new Point(90, 59);
            txtCrearHsSemanales.Name = "txtCrearHsSemanales";
            txtCrearHsSemanales.Size = new Size(553, 23);
            txtCrearHsSemanales.TabIndex = 3;
            txtCrearHsSemanales.ValueChanged += txtCrearHsSemanales_ValueChanged;
            // 
            // txtCrearDescripcion
            // 
            txtCrearDescripcion.Location = new Point(90, 25);
            txtCrearDescripcion.Name = "txtCrearDescripcion";
            txtCrearDescripcion.Size = new Size(554, 23);
            txtCrearDescripcion.TabIndex = 9;
            txtCrearDescripcion.TextChanged += txtCrearDescripcion_TextChanged;
            // 
            // labelCrearIdPlan
            // 
            labelCrearIdPlan.AutoSize = true;
            labelCrearIdPlan.Location = new Point(27, 117);
            labelCrearIdPlan.Name = "labelCrearIdPlan";
            labelCrearIdPlan.Size = new Size(40, 15);
            labelCrearIdPlan.TabIndex = 8;
            labelCrearIdPlan.Text = "idPlan";
            // 
            // labelCrearHsTotales
            // 
            labelCrearHsTotales.AutoSize = true;
            labelCrearHsTotales.Location = new Point(12, 88);
            labelCrearHsTotales.Name = "labelCrearHsTotales";
            labelCrearHsTotales.Size = new Size(58, 15);
            labelCrearHsTotales.TabIndex = 7;
            labelCrearHsTotales.Text = "HsTotales";
            // 
            // labelCrearHsSemanales
            // 
            labelCrearHsSemanales.AutoSize = true;
            labelCrearHsSemanales.Location = new Point(8, 62);
            labelCrearHsSemanales.Name = "labelCrearHsSemanales";
            labelCrearHsSemanales.Size = new Size(77, 15);
            labelCrearHsSemanales.TabIndex = 6;
            labelCrearHsSemanales.Text = "HsSemanales";
            // 
            // labelCrearDescripcion
            // 
            labelCrearDescripcion.AutoSize = true;
            labelCrearDescripcion.Location = new Point(12, 29);
            labelCrearDescripcion.Name = "labelCrearDescripcion";
            labelCrearDescripcion.Size = new Size(69, 15);
            labelCrearDescripcion.TabIndex = 5;
            labelCrearDescripcion.Text = "Descripcion";
            // 
            // txtCrearIdPlan
            // 
            txtCrearIdPlan.Location = new Point(90, 117);
            txtCrearIdPlan.Name = "txtCrearIdPlan";
            txtCrearIdPlan.Size = new Size(554, 23);
            txtCrearIdPlan.TabIndex = 4;
            txtCrearIdPlan.TextChanged += txtCrearIdPlan_TextChanged;
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(23, 167);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(621, 45);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "Crear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            btnCrearCrear.Click += btnCrearCrear_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(867, 36);
            Volver.Name = "Volver";
            Volver.Size = new Size(655, 23);
            Volver.TabIndex = 8;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // MateriaCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 645);
            Controls.Add(Volver);
            Controls.Add(PanelModificar);
            Controls.Add(PanelBuscarliminar);
            Controls.Add(PanelBuscar);
            Controls.Add(PanelCrear);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Name = "MateriaCrud";
            Text = "MateriaCrud";
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBuscarHsTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBuscarHsSemanales).EndInit();
            PanelModificar.ResumeLayout(false);
            PanelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtModificarHsTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtModificarHsSemanales).EndInit();
            PanelBuscarliminar.ResumeLayout(false);
            PanelBuscarliminar.PerformLayout();
            PanelCrear.ResumeLayout(false);
            PanelCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCrearHsTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCrearHsSemanales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Panel PanelBuscar;
        private Label LabelEliminarId;
        private Button btnEliminarBuscar;
        private TextBox txtEliminarId;
        private Panel PanelModificar;
        private TextBox txtModificarId;
        private Label labelModificarId;
        private Button btnModificarBuscar;
        private Button btnModificarModificar;
        private Panel PanelBuscarliminar;
        private TextBox txtBuscarBuscarId;
        private Button btnBuscarBuscarId;
        private Label labelBuscarId;
        private Panel PanelCrear;
        private Button btnCrearCrear;

        private Label labelCrearIdPlan;
        private Label labelCrearHsTotales;
        private Label labelCrearHsSemanales;
        private Label labelCrearDescripcion;
        private TextBox txtCrearIdPlan;
        private TextBox txtCrearDescripcion;











        // Event handlers for main buttons
        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = true;
            PanelBuscarliminar.Visible = false;
            PanelModificar.Visible = false;
            PanelBuscar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscarliminar.Visible = false;
            PanelModificar.Visible = false;
            PanelBuscar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscarliminar.Visible = false;
            PanelModificar.Visible = true;
            PanelBuscar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelCrear.Visible = false;
            PanelBuscarliminar.Visible = true;
            PanelModificar.Visible = false;
            PanelBuscar.Visible = false;
        }
        private TextBox txtBuscarIdPlan;
        private Label labelBuscarIdPlan;
        private Label labelBuscarHsTotales;
        private Label labelBuscarHsSemanales;
        private Label labelBuscarDescripcion;
        private TextBox txtBuscarDescripcion;

        private TextBox txtModificarIdPlan;
        private Label labelModifiacarIdPlan;
        private Label labelModifiacarHsTotales;
        private Label labelModifiacarHsSemanale;
        private Label labelModifiacarDescripcion;
        private TextBox txtModificarDescripcion;
        private NumericUpDown txtBuscarHsTotales;
        private NumericUpDown txtBuscarHsSemanales;
        private NumericUpDown txtCrearHsTotales;
        private NumericUpDown txtCrearHsSemanales;
        private NumericUpDown txtModificarHsTotales;
        private NumericUpDown txtModificarHsSemanales;
        private Button Volver;
    }
}