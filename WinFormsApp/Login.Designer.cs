namespace WinFormsApp
{
    partial class Login
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
            usuario = new TextBox();
            password = new TextBox();
            usuarioLabel = new Label();
            passLabel = new Label();
            LogIni = new Button();
            SuspendLayout();
            // 
            // usuario
            // 
            usuario.Location = new Point(129, 142);
            usuario.Name = "usuario";
            usuario.Size = new Size(538, 23);
            usuario.TabIndex = 1;
            usuario.TextChanged += usuario_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(129, 226);
            password.Name = "password";
            password.Size = new Size(538, 23);
            password.TabIndex = 2;
            password.TextChanged += password_TextChanged;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(129, 124);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(46, 15);
            usuarioLabel.TabIndex = 5;
            usuarioLabel.Text = "usuario";
            usuarioLabel.Click += usuarioLabel_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(133, 208);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(67, 15);
            passLabel.TabIndex = 6;
            passLabel.Text = "Contraseña";
            passLabel.Click += passLabel_Click;
            // 
            // LogIni
            // 
            LogIni.Location = new Point(129, 328);
            LogIni.Name = "LogIni";
            LogIni.Size = new Size(538, 32);
            LogIni.TabIndex = 4;
            LogIni.Text = "Iniciar sesion";
            LogIni.UseVisualStyleBackColor = true;
            LogIni.Click += LogIni_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogIni);
            Controls.Add(passLabel);
            Controls.Add(usuarioLabel);
            Controls.Add(password);
            Controls.Add(usuario);
            Name = "Login";
            Text = "Iniciar sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox usuario;
        private TextBox password;
        private Label usuarioLabel;
        private Label passLabel;
        private Button LogIni;
    }
}