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
            registrarse = new Button();
            mail = new TextBox();
            password = new TextBox();
            mailLabel = new Label();
            passLabel = new Label();
            LogIni = new Button();
            SuspendLayout();
            // 
            // registrarse
            // 
            registrarse.Location = new Point(129, 328);
            registrarse.Name = "registrarse";
            registrarse.Size = new Size(111, 32);
            registrarse.TabIndex = 4;
            registrarse.Text = "registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registrarse_Click;
            // 
            // mail
            // 
            mail.Location = new Point(129, 142);
            mail.Name = "mail";
            mail.Size = new Size(538, 23);
            mail.TabIndex = 1;
            mail.TextChanged += mail_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(129, 226);
            password.Name = "password";
            password.Size = new Size(538, 23);
            password.TabIndex = 2;
            password.TextChanged += password_TextChanged;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(129, 124);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(58, 15);
            mailLabel.TabIndex = 5;
            mailLabel.Text = "Mail";
            mailLabel.Click += mailLabel_Click;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(133, 208);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(58, 15);
            passLabel.TabIndex = 6;
            passLabel.Text = "Contraseña";
            passLabel.Click += passLabel_Click;
            // 
            // LogIni
            // 
            LogIni.Location = new Point(556, 328);
            LogIni.Name = "LogIni";
            LogIni.Size = new Size(111, 32);
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
            Controls.Add(mailLabel);
            Controls.Add(password);
            Controls.Add(mail);
            Controls.Add(registrarse);
            Name = "Login";
            Text = "Iniciar sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Button registrarse;
        private TextBox mail;
        private TextBox password;
        private Label mailLabel;
        private Label passLabel;
        private Button LogIni;
    }
}