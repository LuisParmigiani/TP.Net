namespace WinFormsApp
{
    partial class Registro
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
            registrarme = new Button();
            cancelar = new Button();
            mail = new Label();
            textboxmail = new TextBox();
            textboxpasw = new TextBox();
            password = new Label();
            nombre = new Label();
            apellido = new Label();
            direccion = new Label();
            nombreUsuario = new Label();
            fechaNac = new Label();
            textboxnom = new TextBox();
            textboxape = new TextBox();
            textboxdir = new TextBox();
            textboxNombreUsuario = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tipoUs = new Label();
            Profesor = new RadioButton();
            Alumno = new RadioButton();
            SuspendLayout();
            // 
            // registrarme
            // 
            registrarme.Location = new Point(571, 366);
            registrarme.Name = "registrarme";
            registrarme.Size = new Size(113, 34);
            registrarme.TabIndex = 8;
            registrarme.Text = "Registrarme:";
            registrarme.UseVisualStyleBackColor = true;
            registrarme.Click += registrarme_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(239, 366);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(106, 34);
            cancelar.TabIndex = 10;
            cancelar.Text = "cancelar";
            cancelar.UseVisualStyleBackColor = true;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Location = new Point(62, 209);
            mail.Name = "mail";
            mail.Size = new Size(33, 15);
            mail.TabIndex = 2;
            mail.Text = "Mail:";
            mail.Click += mail_Click;
            // 
            // textboxmail
            // 
            textboxmail.Location = new Point(190, 209);
            textboxmail.Name = "textboxmail";
            textboxmail.Size = new Size(558, 23);
            textboxmail.TabIndex = 6;
            textboxmail.TextChanged += textboxmail_TextChanged;
            // 
            // textboxpasw
            // 
            textboxpasw.Location = new Point(190, 267);
            textboxpasw.Name = "textboxpasw";
            textboxpasw.Size = new Size(558, 23);
            textboxpasw.TabIndex = 7;
            textboxpasw.TextChanged += textboxpasw_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(62, 270);
            password.Name = "password";
            password.Size = new Size(70, 15);
            password.TabIndex = 5;
            password.Text = "Contraseña:";
            password.Click += password_Click;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(62, 34);
            nombre.Name = "nombre";
            nombre.Size = new Size(54, 15);
            nombre.TabIndex = 1;
            nombre.Text = "Nombre:";
            nombre.Click += nombre_Click;
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(462, 37);
            apellido.Name = "apellido";
            apellido.Size = new Size(54, 15);
            apellido.TabIndex = 2;
            apellido.Text = "Apellido:";
            apellido.Click += apellido_Click;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Location = new Point(62, 154);
            direccion.Name = "direccion";
            direccion.Size = new Size(60, 15);
            direccion.TabIndex = 4;
            direccion.Text = "Direccion:";
            direccion.Click += direccion_Click;
            // 
            // nombreUsuario
            // 
            nombreUsuario.AutoSize = true;
            nombreUsuario.Location = new Point(62, 108);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(112, 15);
            nombreUsuario.TabIndex = 3;
            nombreUsuario.Text = "Nombre de usuario:";
            nombreUsuario.Click += nombreUsuario_Click;
            // 
            // fechaNac
            // 
            fechaNac.AutoSize = true;
            fechaNac.Location = new Point(422, 160);
            fechaNac.Name = "fechaNac";
            fechaNac.Size = new Size(120, 15);
            fechaNac.TabIndex = 5;
            fechaNac.Text = "Fecha de nacimiento:";
            fechaNac.Click += fechaNac_Click;
            // 
            // textboxnom
            // 
            textboxnom.Location = new Point(190, 34);
            textboxnom.Name = "textboxnom";
            textboxnom.Size = new Size(226, 23);
            textboxnom.TabIndex = 12;
            textboxnom.TextChanged += textboxnom_TextChanged;
            // 
            // textboxape
            // 
            textboxape.Location = new Point(548, 34);
            textboxape.Name = "textboxape";
            textboxape.Size = new Size(200, 23);
            textboxape.TabIndex = 2;
            textboxape.TextChanged += textboxape_TextChanged;
            // 
            // textboxdir
            // 
            textboxdir.Location = new Point(190, 157);
            textboxdir.Name = "textboxdir";
            textboxdir.Size = new Size(226, 23);
            textboxdir.TabIndex = 4;
            textboxdir.TextChanged += textboxdir_TextChanged;
            // 
            // textboxNombreUsuario
            // 
            textboxNombreUsuario.Location = new Point(190, 105);
            textboxNombreUsuario.Name = "textboxNombreUsuario";
            textboxNombreUsuario.Size = new Size(558, 23);
            textboxNombreUsuario.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(548, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // tipoUs
            // 
            tipoUs.AutoSize = true;
            tipoUs.Location = new Point(58, 325);
            tipoUs.Name = "tipoUs";
            tipoUs.Size = new Size(76, 15);
            tipoUs.TabIndex = 7;
            tipoUs.Text = "Tipo usuario:";
            // 
            // Profesor
            // 
            Profesor.AutoSize = true;
            Profesor.Location = new Point(251, 325);
            Profesor.Name = "Profesor";
            Profesor.Size = new Size(69, 19);
            Profesor.TabIndex = 18;
            Profesor.TabStop = true;
            Profesor.Text = "Profesor";
            Profesor.UseVisualStyleBackColor = true;
            // 
            // Alumno
            // 
            Alumno.AutoSize = true;
            Alumno.Location = new Point(571, 321);
            Alumno.Name = "Alumno";
            Alumno.Size = new Size(68, 19);
            Alumno.TabIndex = 19;
            Alumno.TabStop = true;
            Alumno.Text = "Alumno";
            Alumno.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Alumno);
            Controls.Add(Profesor);
            Controls.Add(tipoUs);
            Controls.Add(dateTimePicker1);
            Controls.Add(textboxNombreUsuario);
            Controls.Add(textboxdir);
            Controls.Add(textboxape);
            Controls.Add(textboxnom);
            Controls.Add(fechaNac);
            Controls.Add(nombreUsuario);
            Controls.Add(direccion);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(password);
            Controls.Add(textboxpasw);
            Controls.Add(textboxmail);
            Controls.Add(mail);
            Controls.Add(cancelar);
            Controls.Add(registrarme);
            Name = "Registro";
            Text = "Registro:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarme;
        private Button cancelar;
        private Label mail;
        private TextBox textboxmail;
        private TextBox textboxpasw;
        private Label password;
        private Label nombre;
        private Label apellido;
        private Label direccion;
        private Label nombreUsuario;
        private Label fechaNac;
        private TextBox textboxnom;
        private TextBox textboxape;
        private TextBox textboxdir;
        private TextBox textboxNombreUsuario;
        private DateTimePicker dateTimePicker1;
        private Label tipoUs;
        private RadioButton Profesor;
        private RadioButton Alumno;
    }
}