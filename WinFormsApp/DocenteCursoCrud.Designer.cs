namespace WinFormsApp
{
    partial class DocenteCursoCrud
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
            txtModificarCargo = new TextBox();
            txtModificarIdDocente = new TextBox();
            txtModificarIdCurso = new TextBox();
            labelModificarCargo = new Label();
            labelModificarIdDocente = new Label();
            labelModificarIdCurso = new Label();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            PanelBuscar = new Panel();
            txtBuscarCargo = new TextBox();
            txtBuscarIdDocente = new TextBox();
            txtBuscarIdCurso = new TextBox();
            labelBuscarCargo = new Label();
            labelBuscarIdDocente = new Label();
            labelBuscarIdCurso = new Label();
            txtBuscarBuscarId = new TextBox();
            btnBuscarBuscarId = new Button();
            labelBuscarId = new Label();
            PanelCrear = new Panel();
            txtCrearCargo = new TextBox();
            txtCrearIdDocente = new TextBox();
            txtCrearIdCurso = new TextBox();
            labelCrearCargo = new Label();
            labelCrearIdDocente = new Label();
            labelCrearIdCurso = new Label();
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
            PanelEliminar.Location = new Point(3, 0);
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
            PanelModificar.Controls.Add(txtModificarCargo);
            PanelModificar.Controls.Add(txtModificarIdDocente);
            PanelModificar.Controls.Add(txtModificarIdCurso);
            PanelModificar.Controls.Add(labelModificarCargo);
            PanelModificar.Controls.Add(labelModificarIdDocente);
            PanelModificar.Controls.Add(labelModificarIdCurso);
            PanelModificar.Controls.Add(btnModificarModificar);
            PanelModificar.Controls.Add(txtModificarId);
            PanelModificar.Controls.Add(labelModificarId);
            PanelModificar.Controls.Add(btnModificarBuscar);
            PanelModificar.Location = new Point(21, 74);
            PanelModificar.Name = "PanelModificar";
            PanelModificar.Size = new Size(679, 245);
            PanelModificar.TabIndex = 6;
            PanelModificar.Visible = false;
            // 
            // txtModificarCargo
            // 
            txtModificarCargo.Location = new Point(157, 135);
            txtModificarCargo.Name = "txtModificarCargo";
            txtModificarCargo.Size = new Size(471, 23);
            txtModificarCargo.TabIndex = 12;
            // 
            // txtModificarIdDocente
            // 
            txtModificarIdDocente.Location = new Point(157, 100);
            txtModificarIdDocente.Name = "txtModificarIdDocente";
            txtModificarIdDocente.Size = new Size(471, 23);
            txtModificarIdDocente.TabIndex = 11;
            txtModificarIdDocente.TextChanged += txtModificarIdDocente_TextChanged;
            // 
            // txtModificarIdCurso
            // 
            txtModificarIdCurso.Location = new Point(157, 66);
            txtModificarIdCurso.Name = "txtModificarIdCurso";
            txtModificarIdCurso.Size = new Size(471, 23);
            txtModificarIdCurso.TabIndex = 10;
            txtModificarIdCurso.TextChanged += txtModificarIdCurso_TextChanged;
            // 
            // labelModificarCargo
            // 
            labelModificarCargo.AutoSize = true;
            labelModificarCargo.Location = new Point(34, 138);
            labelModificarCargo.Name = "labelModificarCargo";
            labelModificarCargo.Size = new Size(39, 15);
            labelModificarCargo.TabIndex = 9;
            labelModificarCargo.Text = "Cargo";
            // 
            // labelModificarIdDocente
            // 
            labelModificarIdDocente.AutoSize = true;
            labelModificarIdDocente.Location = new Point(35, 103);
            labelModificarIdDocente.Name = "labelModificarIdDocente";
            labelModificarIdDocente.Size = new Size(61, 15);
            labelModificarIdDocente.TabIndex = 8;
            labelModificarIdDocente.Text = "IdDocente";
            // 
            // labelModificarIdCurso
            // 
            labelModificarIdCurso.AutoSize = true;
            labelModificarIdCurso.Location = new Point(33, 68);
            labelModificarIdCurso.Name = "labelModificarIdCurso";
            labelModificarIdCurso.Size = new Size(48, 15);
            labelModificarIdCurso.TabIndex = 7;
            labelModificarIdCurso.Text = "IdCurso";
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
            PanelBuscar.Controls.Add(txtBuscarCargo);
            PanelBuscar.Controls.Add(txtBuscarIdDocente);
            PanelBuscar.Controls.Add(txtBuscarIdCurso);
            PanelBuscar.Controls.Add(labelBuscarCargo);
            PanelBuscar.Controls.Add(labelBuscarIdDocente);
            PanelBuscar.Controls.Add(labelBuscarIdCurso);
            PanelBuscar.Controls.Add(txtBuscarBuscarId);
            PanelBuscar.Controls.Add(btnBuscarBuscarId);
            PanelBuscar.Controls.Add(labelBuscarId);
            PanelBuscar.Location = new Point(24, 77);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.Size = new Size(679, 245);
            PanelBuscar.TabIndex = 5;
            PanelBuscar.Visible = false;
            // 
            // txtBuscarCargo
            // 
            txtBuscarCargo.Enabled = false;
            txtBuscarCargo.Location = new Point(145, 128);
            txtBuscarCargo.Name = "txtBuscarCargo";
            txtBuscarCargo.Size = new Size(471, 23);
            txtBuscarCargo.TabIndex = 12;
            // 
            // txtBuscarIdDocente
            // 
            txtBuscarIdDocente.Enabled = false;
            txtBuscarIdDocente.Location = new Point(145, 93);
            txtBuscarIdDocente.Name = "txtBuscarIdDocente";
            txtBuscarIdDocente.Size = new Size(471, 23);
            txtBuscarIdDocente.TabIndex = 11;
            // 
            // txtBuscarIdCurso
            // 
            txtBuscarIdCurso.Enabled = false;
            txtBuscarIdCurso.Location = new Point(145, 59);
            txtBuscarIdCurso.Name = "txtBuscarIdCurso";
            txtBuscarIdCurso.Size = new Size(471, 23);
            txtBuscarIdCurso.TabIndex = 10;
            txtBuscarIdCurso.TextChanged += txtBuscarIdCurso_TextChanged;
            // 
            // labelBuscarCargo
            // 
            labelBuscarCargo.AutoSize = true;
            labelBuscarCargo.Location = new Point(22, 131);
            labelBuscarCargo.Name = "labelBuscarCargo";
            labelBuscarCargo.Size = new Size(39, 15);
            labelBuscarCargo.TabIndex = 9;
            labelBuscarCargo.Text = "Cargo";
            // 
            // labelBuscarIdDocente
            // 
            labelBuscarIdDocente.AutoSize = true;
            labelBuscarIdDocente.Location = new Point(23, 96);
            labelBuscarIdDocente.Name = "labelBuscarIdDocente";
            labelBuscarIdDocente.Size = new Size(61, 15);
            labelBuscarIdDocente.TabIndex = 8;
            labelBuscarIdDocente.Text = "IdDocente";
            // 
            // labelBuscarIdCurso
            // 
            labelBuscarIdCurso.AutoSize = true;
            labelBuscarIdCurso.Location = new Point(21, 61);
            labelBuscarIdCurso.Name = "labelBuscarIdCurso";
            labelBuscarIdCurso.Size = new Size(48, 15);
            labelBuscarIdCurso.TabIndex = 7;
            labelBuscarIdCurso.Text = "IdCurso";
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
            PanelCrear.Controls.Add(PanelEliminar);
            PanelCrear.Controls.Add(txtCrearCargo);
            PanelCrear.Controls.Add(txtCrearIdDocente);
            PanelCrear.Controls.Add(txtCrearIdCurso);
            PanelCrear.Controls.Add(labelCrearCargo);
            PanelCrear.Controls.Add(labelCrearIdDocente);
            PanelCrear.Controls.Add(labelCrearIdCurso);
            PanelCrear.Controls.Add(btnCrearCrear);
            PanelCrear.Location = new Point(27, 80);
            PanelCrear.Name = "PanelCrear";
            PanelCrear.Size = new Size(679, 245);
            PanelCrear.TabIndex = 4;
            // 
            // txtCrearCargo
            // 
            txtCrearCargo.Location = new Point(157, 90);
            txtCrearCargo.Name = "txtCrearCargo";
            txtCrearCargo.Size = new Size(471, 23);
            txtCrearCargo.TabIndex = 6;
            // 
            // txtCrearIdDocente
            // 
            txtCrearIdDocente.Location = new Point(157, 55);
            txtCrearIdDocente.Name = "txtCrearIdDocente";
            txtCrearIdDocente.Size = new Size(471, 23);
            txtCrearIdDocente.TabIndex = 5;
            txtCrearIdDocente.TextChanged += txtCrearIdDocente_TextChanged;
            // 
            // txtCrearIdCurso
            // 
            txtCrearIdCurso.Location = new Point(157, 21);
            txtCrearIdCurso.Name = "txtCrearIdCurso";
            txtCrearIdCurso.Size = new Size(471, 23);
            txtCrearIdCurso.TabIndex = 4;
            txtCrearIdCurso.TextChanged += txtCrearIdCurso_TextChanged;
            // 
            // labelCrearCargo
            // 
            labelCrearCargo.AutoSize = true;
            labelCrearCargo.Location = new Point(34, 93);
            labelCrearCargo.Name = "labelCrearCargo";
            labelCrearCargo.Size = new Size(39, 15);
            labelCrearCargo.TabIndex = 3;
            labelCrearCargo.Text = "Cargo";
            // 
            // labelCrearIdDocente
            // 
            labelCrearIdDocente.AutoSize = true;
            labelCrearIdDocente.Location = new Point(35, 58);
            labelCrearIdDocente.Name = "labelCrearIdDocente";
            labelCrearIdDocente.Size = new Size(61, 15);
            labelCrearIdDocente.TabIndex = 2;
            labelCrearIdDocente.Text = "IdDocente";
            // 
            // labelCrearIdCurso
            // 
            labelCrearIdCurso.AutoSize = true;
            labelCrearIdCurso.Location = new Point(33, 23);
            labelCrearIdCurso.Name = "labelCrearIdCurso";
            labelCrearIdCurso.Size = new Size(48, 15);
            labelCrearIdCurso.TabIndex = 1;
            labelCrearIdCurso.Text = "IdCurso";
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
            Volver.Location = new Point(24, 363);
            Volver.Name = "Volver";
            Volver.Size = new Size(685, 23);
            Volver.TabIndex = 7;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // DocenteCursoCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 623);
            Controls.Add(Volver);
            Controls.Add(PanelModificar);
            Controls.Add(PanelBuscar);
            Controls.Add(PanelCrear);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Name = "DocenteCursoCrud";
            Text = "DocenteCursoCrud";
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
        private Label labelCrearCargo;
        private Label labelCrearIdDocente;
        private Label labelCrearIdCurso;
        private TextBox txtCrearCargo;
        private TextBox txtCrearIdDocente;
        private TextBox txtCrearIdCurso;
        private TextBox txtModificarCargo;
        private TextBox txtModificarIdDocente;
        private TextBox txtModificarIdCurso;
        private Label labelModificarCargo;
        private Label labelModificarIdDocente;
        private Label labelModificarIdCurso;
        private TextBox txtBuscarCargo;
        private TextBox txtBuscarIdDocente;
        private TextBox txtBuscarIdCurso;
        private Label labelBuscarCargo;
        private Label labelBuscarIdDocente;
        private Label labelBuscarIdCurso;
        private Button Volver;
    }
}