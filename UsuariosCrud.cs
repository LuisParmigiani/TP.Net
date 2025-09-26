namespace WinFormsApp
{
    partial class UsuariosCrud
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
            // Botones del menú principal
            Buscar = new Button();
            Crear = new Button();
            Modificar = new Button();
            Borrrar = new Button();
            Volver = new Button();
            
            // Controles para CREAR/MODIFICAR
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnVolverMenu = new Button();
            
            // Controles para BUSCAR
            lblBuscarId = new Label();
            txtBuscarId = new TextBox();
            btnBuscarUsuario = new Button();
            lblResultado = new Label();
            
            // Controles para BORRAR
            lblBorrarId = new Label();
            txtBorrarId = new TextBox();
            btnBorrarUsuario = new Button();
            
            SuspendLayout();
            
            // 
            // Botones del menú principal
            // 
            Buscar.Location = new Point(105, 136);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(580, 32);
            Buscar.TabIndex = 0;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            
            Crear.Location = new Point(105, 84);
            Crear.Name = "Crear";
            Crear.Size = new Size(580, 32);
            Crear.TabIndex = 1;
            Crear.Text = "Crear";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            
            Modificar.Location = new Point(105, 188);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(580, 32);
            Modificar.TabIndex = 2;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            
            Borrrar.Location = new Point(105, 242);
            Borrrar.Name = "Borrrar";
            Borrrar.Size = new Size(580, 32);
            Borrrar.TabIndex = 3;
            Borrrar.Text = "Borrar";
            Borrrar.UseVisualStyleBackColor = true;
            Borrrar.Click += Borrrar_Click;
            
            Volver.Location = new Point(70, 316);
            Volver.Name = "Volver";
            Volver.Size = new Size(680, 89);
            Volver.TabIndex = 5;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            
            // 
            // Controles para CREAR/MODIFICAR
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(105, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            lblNombre.Visible = false;
            
            txtNombre.Location = new Point(105, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 7;
            txtNombre.Visible = false;
            
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(105, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            lblEmail.Visible = false;
            
            txtEmail.Location = new Point(105, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 9;
            txtEmail.Visible = false;
            
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(105, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Contraseña:";
            lblPassword.Visible = false;
            
            txtPassword.Location = new Point(105, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Visible = false;
            
            btnGuardar.Location = new Point(105, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.Visible = false;
            
            btnActualizar.Location = new Point(105, 290);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 30);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            btnActualizar.Visible = false;
            
            btnVolverMenu.Location = new Point(220, 290);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(100, 30);
            btnVolverMenu.TabIndex = 14;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            btnVolverMenu.Visible = false;
            
            // 
            // Controles para BUSCAR
            //
            lblBuscarId.AutoSize = true;
            lblBuscarId.Location = new Point(105, 84);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(70, 15);
            lblBuscarId.TabIndex = 15;
            lblBuscarId.Text = "ID Usuario:";
            lblBuscarId.Visible = false;
            
            txtBuscarId.Location = new Point(105, 110);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(200, 23);
            txtBuscarId.TabIndex = 16;
            txtBuscarId.Visible = false;
            
            btnBuscarUsuario.Location = new Point(320, 109);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(100, 25);
            btnBuscarUsuario.TabIndex = 17;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            btnBuscarUsuario.Visible = false;
            
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(105, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 18;
            lblResultado.Visible = false;
            
            // 
            // Controles para BORRAR
            //
            lblBorrarId.AutoSize = true;
            lblBorrarId.Location = new Point(105, 84);
            lblBorrarId.Name = "lblBorrarId";
            lblBorrarId.Size = new Size(70, 15);
            lblBorrarId.TabIndex = 19;
            lblBorrarId.Text = "ID Usuario:";
            lblBorrarId.Visible = false;
            
            txtBorrarId.Location = new Point(105, 110);
            txtBorrarId.Name = "txtBorrarId";
            txtBorrarId.Size = new Size(200, 23);
            txtBorrarId.TabIndex = 20;
            txtBorrarId.Visible = false;
            
            btnBorrarUsuario.Location = new Point(320, 109);
            btnBorrarUsuario.Name = "btnBorrarUsuario";
            btnBorrarUsuario.Size = new Size(100, 25);
            btnBorrarUsuario.TabIndex = 21;
            btnBorrarUsuario.Text = "Borrar";
            btnBorrarUsuario.UseVisualStyleBackColor = true;
            btnBorrarUsuario.Click += btnBorrarUsuario_Click;
            btnBorrarUsuario.Visible = false;
            
            // 
            // UsuariosCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrarUsuario);
            Controls.Add(txtBorrarId);
            Controls.Add(lblBorrarId);
            Controls.Add(lblResultado);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtBuscarId);
            Controls.Add(lblBuscarId);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(Volver);
            Controls.Add(Borrrar);
            Controls.Add(Modificar);
            Controls.Add(Crear);
            Controls.Add(Buscar);
            Name = "UsuariosCrud";
            Text = "Gestión de Usuarios";
            Load += UsuarioCrud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Botones del menú principal
        private Button Buscar;
        private Button Crear;
        private Button Modificar;
        private Button Borrrar;
        private Button Volver;
        
        // Controles para CREAR/MODIFICAR
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnVolverMenu;
        
        // Controles para BUSCAR
        private Label lblBuscarId;
        private TextBox txtBuscarId;
        private Button btnBuscarUsuario;
        private Label lblResultado;
        
        // Controles para BORRAR
        private Label lblBorrarId;
        private TextBox txtBorrarId;
        private Button btnBorrarUsuario;
    }
}