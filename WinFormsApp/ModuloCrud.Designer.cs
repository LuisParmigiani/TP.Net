namespace WinFormsApp
{
    partial class ModuloCrud
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
            btnElimina = new Button();
            panelEliminar = new Panel();
            panel2 = new Panel();
            txtEliminarId = new TextBox();
            id = new Label();
            btnEliminarBuscar = new Button();
            panelModificar = new Panel();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            panelBuscar = new Panel();
            txtBuscarId = new TextBox();
            btnBuscarId = new Button();
            labelBuscarId = new Label();
            panelCrear = new Panel();
            btnCrearCrear = new Button();
            Volver = new Button();
            panelEliminar.SuspendLayout();
            panelModificar.SuspendLayout();
            panelBuscar.SuspendLayout();
            panelCrear.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(24, 24);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(105, 34);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(148, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 34);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(275, 24);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 34);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(406, 24);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(97, 34);
            btnElimina.TabIndex = 3;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // panelEliminar
            // 
            panelEliminar.Controls.Add(panel2);
            panelEliminar.Controls.Add(txtEliminarId);
            panelEliminar.Controls.Add(id);
            panelEliminar.Controls.Add(btnEliminarBuscar);
            panelEliminar.Location = new Point(24, 90);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(747, 278);
            panelEliminar.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(58, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(873, 80);
            panel2.TabIndex = 6;
            // 
            // txtEliminarId
            // 
            txtEliminarId.Location = new Point(124, 25);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(215, 23);
            txtEliminarId.TabIndex = 2;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(31, 28);
            id.Name = "id";
            id.Size = new Size(17, 15);
            id.TabIndex = 1;
            id.Text = "id";
            // 
            // btnEliminarBuscar
            // 
            btnEliminarBuscar.Location = new Point(382, 28);
            btnEliminarBuscar.Name = "btnEliminarBuscar";
            btnEliminarBuscar.Size = new Size(97, 23);
            btnEliminarBuscar.TabIndex = 0;
            btnEliminarBuscar.Text = "EliminarBuscar";
            btnEliminarBuscar.UseVisualStyleBackColor = true;
            // 
            // panelModificar
            // 
            panelModificar.Controls.Add(btnModificarModificar);
            panelModificar.Controls.Add(txtModificarId);
            panelModificar.Controls.Add(labelModificarId);
            panelModificar.Controls.Add(btnModificarBuscar);
            panelModificar.Location = new Point(24, 394);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(747, 278);
            panelModificar.TabIndex = 7;
            panelModificar.Visible = false;
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(31, 185);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(664, 70);
            btnModificarModificar.TabIndex = 4;
            btnModificarModificar.Text = "ModificarModificar";
            btnModificarModificar.UseVisualStyleBackColor = true;
            // 
            // txtModificarId
            // 
            txtModificarId.Location = new Point(108, 29);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(371, 23);
            txtModificarId.TabIndex = 2;
            // 
            // labelModificarId
            // 
            labelModificarId.AutoSize = true;
            labelModificarId.Location = new Point(31, 32);
            labelModificarId.Name = "labelModificarId";
            labelModificarId.Size = new Size(68, 15);
            labelModificarId.TabIndex = 1;
            labelModificarId.Text = "ModificarId";
            // 
            // btnModificarBuscar
            // 
            btnModificarBuscar.Location = new Point(555, 30);
            btnModificarBuscar.Name = "btnModificarBuscar";
            btnModificarBuscar.Size = new Size(140, 23);
            btnModificarBuscar.TabIndex = 0;
            btnModificarBuscar.Text = "ModificarBuscar";
            btnModificarBuscar.UseVisualStyleBackColor = true;
            // 
            // panelBuscar
            // 
            panelBuscar.Controls.Add(txtBuscarId);
            panelBuscar.Controls.Add(btnBuscarId);
            panelBuscar.Controls.Add(labelBuscarId);
            panelBuscar.Location = new Point(794, 406);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(747, 278);
            panelBuscar.TabIndex = 8;
            panelBuscar.Visible = false;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(143, 26);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(443, 23);
            txtBuscarId.TabIndex = 2;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(632, 25);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(75, 23);
            btnBuscarId.TabIndex = 1;
            btnBuscarId.Text = "BuscarId";
            btnBuscarId.UseVisualStyleBackColor = true;
            // 
            // labelBuscarId
            // 
            labelBuscarId.AutoSize = true;
            labelBuscarId.Location = new Point(29, 29);
            labelBuscarId.Name = "labelBuscarId";
            labelBuscarId.Size = new Size(52, 15);
            labelBuscarId.TabIndex = 0;
            labelBuscarId.Text = "BuscarId";
            // 
            // panelCrear
            // 
            panelCrear.Controls.Add(btnCrearCrear);
            panelCrear.Location = new Point(789, 90);
            panelCrear.Name = "panelCrear";
            panelCrear.Size = new Size(750, 275);
            panelCrear.TabIndex = 5;
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(28, 224);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(700, 31);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "CrearCrear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            // 
            // Volver
            // 
            Volver.Location = new Point(12, 738);
            Volver.Name = "Volver";
            Volver.Size = new Size(743, 37);
            Volver.TabIndex = 9;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            // 
            // UsuarioCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 842);
            Controls.Add(panelCrear);
            Controls.Add(Volver);
            Controls.Add(panelBuscar);
            Controls.Add(panelModificar);
            Controls.Add(panelEliminar);
            Controls.Add(btnElimina);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);

            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
            panelModificar.ResumeLayout(false);
            panelModificar.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelCrear.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Button btnCrear;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnElimina;
        private Panel panelEliminar;
        private TextBox txtEliminarId;
        private Label id;
        private Button btnEliminarBuscar;
        private Panel panel2;
        private Panel panelModificar;

        private Button btnModificarModificar;
        private TextBox txtModificarId;
        private Label labelModificarId;
        private Button btnModificarBuscar;
        private Panel panelBuscar;
        private TextBox txtBuscarId;
        private Button btnBuscarId;
        private Label labelBuscarId;
        private Panel panelCrear;
        private Button btnCrearCrear;
        private Button Volver;


        private void btnCrear_Click(object sender, EventArgs e)
        {
            panelCrear.Visible = true;
            panelBuscar.Visible = false;
            panelModificar.Visible = false;
            panelEliminar.Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = true;
            panelModificar.Visible = false;
            panelEliminar.Visible = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = false;
            panelModificar.Visible = true;
            panelEliminar.Visible = false;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = false;
            panelModificar.Visible = false;
            panelEliminar.Visible = true;
        }


    }
}