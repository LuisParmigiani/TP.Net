namespace WinFormsApp
{
    partial class PlanCrud
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
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscar = new Panel();
            txtBuscarDescripcion = new TextBox();
            labelBuscarDescripcion = new Label();
            txtBuscarBuscarId = new TextBox();
            btnBuscarBuscarId = new Button();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            labelCrearDescripcion = new Label();
            txtCrearDescripcion = new TextBox();
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
            PanelEliminar.Location = new Point(27, 80);
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
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Location = new Point(27, 80);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(679, 245);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // txtModificarDescripcion
            // 
            txtModificarDescripcion.Location = new Point(121, 64);
            txtModificarDescripcion.Name = "txtModificarDescripcion";
            txtModificarDescripcion.Size = new Size(346, 23);
            txtModificarDescripcion.TabIndex = 5;
            txtModificarDescripcion.TextChanged += txtModificarDescripcion_TextChanged;
            // 
            // labelModificarDescripcion
            // 
            labelModificarDescripcion.AutoSize = true;
            labelModificarDescripcion.Location = new Point(32, 72);
            labelModificarDescripcion.Name = "labelModificarDescripcion";
            labelModificarDescripcion.Size = new Size(69, 15);
            labelModificarDescripcion.TabIndex = 4;
            labelModificarDescripcion.Text = "Descripcion";
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
            PanelBuscar.Controls.Add(txtBuscarDescripcion);
            PanelBuscar.Controls.Add(labelBuscarDescripcion);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(labelBuscarId);
            PanelBuscar.Location = new Point(27, 80);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 5;
            PanelBuscar.Visible = false;
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.Location = new Point(92, 58);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(411, 23);
            txtBuscarDescripcion.TabIndex = 4;
            txtBuscarDescripcion.TextChanged += txtBuscarDescripcion_TextChanged;
            // 
            // labelBuscarDescripcion
            // 
            labelBuscarDescripcion.AutoSize = true;
            labelBuscarDescripcion.Location = new Point(25, 61);
            labelBuscarDescripcion.Name = "labelBuscarDescripcion";
            labelBuscarDescripcion.Size = new Size(69, 15);
            labelBuscarDescripcion.TabIndex = 3;
            labelBuscarDescripcion.Text = "Descripcion";
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
            PanelCrear.Controls.Add(labelCrearDescripcion);
            PanelCrear.Controls.Add(txtCrearDescripcion);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(27, 80);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            // 
            // labelCrearDescripcion
            // 
            labelCrearDescripcion.AutoSize = true;
            labelCrearDescripcion.Location = new Point(3, 107);
            labelCrearDescripcion.Name = "labelCrearDescripcion";
            labelCrearDescripcion.Size = new Size(69, 15);
            labelCrearDescripcion.TabIndex = 2;
            labelCrearDescripcion.Text = "Descripcion";
            // 
            // txtCrearDescripcion
            // 
            txtCrearDescripcion.Location = new Point(92, 104);
            txtCrearDescripcion.Name = "txtCrearDescripcion";
            txtCrearDescripcion.Size = new Size(495, 23);
            txtCrearDescripcion.TabIndex = 1;
            txtCrearDescripcion.TextChanged += txtCrearDescripcion_TextChanged;
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
            Volver.Location = new Point(27, 347);
            Volver.Name = "Volver";
            Volver.Size = new Size(679, 23);
            Volver.TabIndex = 8;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // PlanCrud
            // 
            ClientSize = new Size(736, 415);
            Controls.Add(Volver);
            Controls.Add(PanelEliminar);
            Controls.Add(PanelModificar);
            Controls.Add(PanelBuscar);
            Controls.Add(PanelCrear);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Name = "PlanCrud";
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
        private Button Volver;
    }
}