namespace WinFormsApp
{
    partial class ComisionCrud
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
            txtModificarIdPlan = new TextBox();
            txtModificarAnoEspecialidad = new TextBox();
            txtModificarDescripcion = new TextBox();
            labelModificarIdPlan = new Label();
            labelModificarAnoEspecialidad = new Label();
            labelModificarDescripcion = new Label();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscar = new Panel();
            txtBusarIdPlan = new TextBox();
            txtBusarAnoEspecialidad = new TextBox();
            txtBusarDescripcion = new TextBox();
            labelBuscarAnoEspecialidad = new Label();
            labelBuscarIdPlan = new Label();
            labelBuscarDescripcion = new Label();
            txtBuscarBuscarId = new TextBox();
            btnBuscarBuscarId = new Button();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            txtCrearIdPlan = new TextBox();
            txtCrearAnoEspecialidad = new TextBox();
            txtCrearDescripcion = new TextBox();
            labelCrearidPlan = new Label();
            labelCrearAnoEspecialidad = new Label();
            labelCrearDecripcion = new Label();
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
            PanelEliminar.Location = new Point(39, 89);
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
            PanelModificar.Controls.Add(txtModificarIdPlan);
            PanelModificar.Controls.Add(txtModificarAnoEspecialidad);
            PanelModificar.Controls.Add(txtModificarDescripcion);
            PanelModificar.Controls.Add(labelModificarIdPlan);
            PanelModificar.Controls.Add(labelModificarAnoEspecialidad);
            PanelModificar.Controls.Add(labelModificarDescripcion);
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Location = new Point(39, 92);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(679, 245);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // txtModificarIdPlan
            // 
            txtModificarIdPlan.Location = new Point(196, 145);
            txtModificarIdPlan.Name = "txtModificarIdPlan";
            txtModificarIdPlan.Size = new Size(396, 23);
            txtModificarIdPlan.TabIndex = 12;
            txtModificarIdPlan.TextChanged += txtModificarIdPlan_TextChanged;
            // 
            // txtModificarAnoEspecialidad
            // 
            txtModificarAnoEspecialidad.Location = new Point(196, 110);
            txtModificarAnoEspecialidad.Name = "txtModificarAnoEspecialidad";
            txtModificarAnoEspecialidad.Size = new Size(396, 23);
            txtModificarAnoEspecialidad.TabIndex = 11;
            txtModificarAnoEspecialidad.TextChanged += txtModificarAnoEspecialidad_TextChanged;
            // 
            // txtModificarDescripcion
            // 
            txtModificarDescripcion.Location = new Point(196, 76);
            txtModificarDescripcion.Name = "txtModificarDescripcion";
            txtModificarDescripcion.Size = new Size(396, 23);
            txtModificarDescripcion.TabIndex = 10;
            txtModificarDescripcion.TextChanged += txtModificarDescripcion_TextChanged;
            // 
            // labelModificarIdPlan
            // 
            labelModificarIdPlan.AutoSize = true;
            labelModificarIdPlan.Location = new Point(86, 145);
            labelModificarIdPlan.Name = "labelModificarIdPlan";
            labelModificarIdPlan.Size = new Size(40, 15);
            labelModificarIdPlan.TabIndex = 9;
            labelModificarIdPlan.Text = "idPlan";
            // 
            // labelModificarAnoEspecialidad
            // 
            labelModificarAnoEspecialidad.AutoSize = true;
            labelModificarAnoEspecialidad.Location = new Point(86, 110);
            labelModificarAnoEspecialidad.Name = "labelModificarAnoEspecialidad";
            labelModificarAnoEspecialidad.Size = new Size(94, 15);
            labelModificarAnoEspecialidad.TabIndex = 8;
            labelModificarAnoEspecialidad.Text = "AnoEspecialidad";
            // 
            // labelModificarDescripcion
            // 
            labelModificarDescripcion.AutoSize = true;
            labelModificarDescripcion.Location = new Point(86, 79);
            labelModificarDescripcion.Name = "labelModificarDescripcion";
            labelModificarDescripcion.Size = new Size(64, 15);
            labelModificarDescripcion.TabIndex = 7;
            labelModificarDescripcion.Text = "Decripcion";
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
            PanelBuscar.Controls.Add(txtBusarIdPlan);
            PanelBuscar.Controls.Add(txtBusarAnoEspecialidad);
            PanelBuscar.Controls.Add(txtBusarDescripcion);
            PanelBuscar.Controls.Add(labelBuscarAnoEspecialidad);
            PanelBuscar.Controls.Add(labelBuscarIdPlan);
            PanelBuscar.Controls.Add(labelBuscarDescripcion);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(labelBuscarId);
            PanelBuscar.Location = new Point(42, 89);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 5;
            PanelBuscar.Visible = false;
            // 
            // txtBusarIdPlan
            // 
            txtBusarIdPlan.Enabled = false;
            txtBusarIdPlan.Location = new Point(130, 131);
            txtBusarIdPlan.Name = "txtBusarIdPlan";
            txtBusarIdPlan.Size = new Size(396, 23);
            txtBusarIdPlan.TabIndex = 12;
            txtBusarIdPlan.TextChanged += txtBusarIdPlan_TextChanged;
            // 
            // txtBusarAnoEspecialidad
            // 
            txtBusarAnoEspecialidad.Enabled = false;
            txtBusarAnoEspecialidad.Location = new Point(130, 96);
            txtBusarAnoEspecialidad.Name = "txtBusarAnoEspecialidad";
            txtBusarAnoEspecialidad.Size = new Size(396, 23);
            txtBusarAnoEspecialidad.TabIndex = 11;
            txtBusarAnoEspecialidad.TextChanged += txtBusarAnoEspecialidad_TextChanged;
            // 
            // txtBusarDescripcion
            // 
            txtBusarDescripcion.Enabled = false;
            txtBusarDescripcion.Location = new Point(130, 57);
            txtBusarDescripcion.Name = "txtBusarDescripcion";
            txtBusarDescripcion.Size = new Size(396, 23);
            txtBusarDescripcion.TabIndex = 10;
            // 
            // labelBuscarAnoEspecialidad
            // 
            labelBuscarAnoEspecialidad.AutoSize = true;
            labelBuscarAnoEspecialidad.Location = new Point(20, 96);
            labelBuscarAnoEspecialidad.Name = "labelBuscarAnoEspecialidad";
            labelBuscarAnoEspecialidad.Size = new Size(94, 15);
            labelBuscarAnoEspecialidad.TabIndex = 8;
            labelBuscarAnoEspecialidad.Text = "AnoEspecialidad";
            // 
            // labelBuscarIdPlan
            // 
            labelBuscarIdPlan.AutoSize = true;
            labelBuscarIdPlan.Location = new Point(35, 139);
            labelBuscarIdPlan.Name = "labelBuscarIdPlan";
            labelBuscarIdPlan.Size = new Size(40, 15);
            labelBuscarIdPlan.TabIndex = 9;
            labelBuscarIdPlan.Text = "idPlan";
            // 
            // labelBuscarDescripcion
            // 
            labelBuscarDescripcion.AutoSize = true;
            labelBuscarDescripcion.Location = new Point(20, 65);
            labelBuscarDescripcion.Name = "labelBuscarDescripcion";
            labelBuscarDescripcion.Size = new Size(64, 15);
            labelBuscarDescripcion.TabIndex = 7;
            labelBuscarDescripcion.Text = "Decripcion";
            // 
            // txtBuscarBuscarId
            // 
            txtBuscarBuscarId.Location = new Point(130, 19);
            txtBuscarBuscarId.Name = "txtBuscarBuscarId";
            txtBuscarBuscarId.Size = new Size(396, 23);
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
            PanelCrear.Controls.Add(txtCrearIdPlan);
            PanelCrear.Controls.Add(txtCrearAnoEspecialidad);
            PanelCrear.Controls.Add(txtCrearDescripcion);
            PanelCrear.Controls.Add(labelCrearidPlan);
            PanelCrear.Controls.Add(labelCrearAnoEspecialidad);
            PanelCrear.Controls.Add(labelCrearDecripcion);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(39, 89);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            PanelCrear.Paint += PanelCrear_Paint;
            // 
            // txtCrearIdPlan
            // 
            txtCrearIdPlan.Location = new Point(132, 90);
            txtCrearIdPlan.Name = "txtCrearIdPlan";
            txtCrearIdPlan.Size = new Size(396, 23);
            txtCrearIdPlan.TabIndex = 6;
            txtCrearIdPlan.TextChanged += txtCrearIdPlan_TextChanged;
            // 
            // txtCrearAnoEspecialidad
            // 
            txtCrearAnoEspecialidad.Location = new Point(132, 55);
            txtCrearAnoEspecialidad.Name = "txtCrearAnoEspecialidad";
            txtCrearAnoEspecialidad.Size = new Size(396, 23);
            txtCrearAnoEspecialidad.TabIndex = 5;
            txtCrearAnoEspecialidad.TextChanged += txtCrearAnoEspecialidad_TextChanged;
            // 
            // txtCrearDescripcion
            // 
            txtCrearDescripcion.Location = new Point(132, 21);
            txtCrearDescripcion.Name = "txtCrearDescripcion";
            txtCrearDescripcion.Size = new Size(396, 23);
            txtCrearDescripcion.TabIndex = 4;
            txtCrearDescripcion.TextChanged += txtCrearDescripcion_TextChanged;
            // 
            // labelCrearidPlan
            // 
            labelCrearidPlan.AutoSize = true;
            labelCrearidPlan.Location = new Point(22, 90);
            labelCrearidPlan.Name = "labelCrearidPlan";
            labelCrearidPlan.Size = new Size(40, 15);
            labelCrearidPlan.TabIndex = 3;
            labelCrearidPlan.Text = "idPlan";
            // 
            // labelCrearAnoEspecialidad
            // 
            labelCrearAnoEspecialidad.AutoSize = true;
            labelCrearAnoEspecialidad.Location = new Point(22, 55);
            labelCrearAnoEspecialidad.Name = "labelCrearAnoEspecialidad";
            labelCrearAnoEspecialidad.Size = new Size(94, 15);
            labelCrearAnoEspecialidad.TabIndex = 2;
            labelCrearAnoEspecialidad.Text = "AnoEspecialidad";
            // 
            // labelCrearDecripcion
            // 
            labelCrearDecripcion.AutoSize = true;
            labelCrearDecripcion.Location = new Point(22, 24);
            labelCrearDecripcion.Name = "labelCrearDecripcion";
            labelCrearDecripcion.Size = new Size(64, 15);
            labelCrearDecripcion.TabIndex = 1;
            labelCrearDecripcion.Text = "Decripcion";
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(23, 167);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(564, 45);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "Crear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            btnCrearCrear.Click += btnCrearCrear_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(45, 358);
            Volver.Name = "Volver";
            Volver.Size = new Size(676, 23);
            Volver.TabIndex = 8;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            // 
            // ComisionCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 623);
            Controls.Add(Volver);
            Controls.Add(PanelCrear);
            Controls.Add(PanelEliminar);
            Controls.Add(PanelModificar);
            Controls.Add(PanelBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Name = "ComisionCrud";
            Text = "ComisionCrud";
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
        private TextBox txtCrearIdPlan;
        private TextBox txtCrearAnoEspecialidad;
        private TextBox txtCrearDescripcion;
        private Label labelCrearidPlan;
        private Label labelCrearAnoEspecialidad;
        private Label labelCrearDecripcion;
        private TextBox txtModificarIdPlan;
        private TextBox txtModificarAnoEspecialidad;
        private Label labelModificarIdPlan;
        private Label labelModificarAnoEspecialidad;
        private TextBox txtBusarIdPlan;
        private TextBox txtBusarAnoEspecialidad;
        private TextBox txtBusarDescripcion;
        private Label labelBuscarIdPlan;
        private Label labelBuscarAnoEspecialidad;
        private Button Volver;
    }
}