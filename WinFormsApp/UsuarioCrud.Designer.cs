namespace WinFormsApp
{
    partial class UsuarioCrud
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
            radioModificarHabilitado = new RadioButton();
            radioModificarCambioClave = new RadioButton();
            txtModificarIdPersona = new TextBox();
            txtModificarMail = new TextBox();
            txtModificarApellido = new TextBox();
            txtModificarNombre = new TextBox();
            txtModificarClave = new TextBox();
            txtModificarNombreUsuario = new TextBox();
            labelModificarIdPersona = new Label();
            labelModificarCambiarClave = new Label();
            labelModificarEmail = new Label();
            labelModificarNombreUsuario = new Label();
            labelModificarApellido = new Label();
            labelModificarClave = new Label();
            labelModificarNombre = new Label();
            labelModificarHabilitado = new Label();
            btnModificarModificar = new Button();
            txtModificarId = new TextBox();
            labelModificarId = new Label();
            btnModificarBuscar = new Button();
            panelBuscar = new Panel();
            radioBuscarHabilitado = new RadioButton();
            radioBuscarCambioClave = new RadioButton();
            txtBuscarIdPersona = new TextBox();
            txtBuscarMail = new TextBox();
            txtBuscarApellido = new TextBox();
            txtBuscarNombre = new TextBox();
            txtBuscarClave = new TextBox();
            txtBuscarNombreUsuario = new TextBox();
            labelBuscarIdPersona = new Label();
            labelBuscarCambiarClave = new Label();
            labelBuscarEmail = new Label();
            labelBuscarNombreUsuario = new Label();
            labelBuscarApellido = new Label();
            labelBuscarClave = new Label();
            labelBuscarNombre = new Label();
            labelBuscarHabilitado = new Label();
            txtBuscarId = new TextBox();
            btnBuscarId = new Button();
            labelBuscarId = new Label();
            panelCrear = new Panel();
            radioCrearHabilitado = new RadioButton();
            radioCrearCambioClave = new RadioButton();
            txtCrearIdPersona = new TextBox();
            txtCrearEmail = new TextBox();
            txtCrearApellido = new TextBox();
            txtCrearNombre = new TextBox();
            txtCrearClave = new TextBox();
            txtCrearNombreUsuario = new TextBox();
            labelCrearIdPersona = new Label();
            btnCrearCrear = new Button();
            labelCrearCambiarClave = new Label();
            labelCrearEmail = new Label();
            labelCrearNombreUsuario = new Label();
            labelCrearApellido = new Label();
            labelCrearClave = new Label();
            labelCrearNombre = new Label();
            labelCrearHabilitado = new Label();
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
            txtEliminarId.TextChanged += txtEliminarId_TextChanged;
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
            panelModificar.Controls.Add(radioModificarHabilitado);
            panelModificar.Controls.Add(radioModificarCambioClave);
            panelModificar.Controls.Add(txtModificarIdPersona);
            panelModificar.Controls.Add(txtModificarMail);
            panelModificar.Controls.Add(txtModificarApellido);
            panelModificar.Controls.Add(txtModificarNombre);
            panelModificar.Controls.Add(txtModificarClave);
            panelModificar.Controls.Add(txtModificarNombreUsuario);
            panelModificar.Controls.Add(labelModificarIdPersona);
            panelModificar.Controls.Add(labelModificarCambiarClave);
            panelModificar.Controls.Add(labelModificarEmail);
            panelModificar.Controls.Add(labelModificarNombreUsuario);
            panelModificar.Controls.Add(labelModificarApellido);
            panelModificar.Controls.Add(labelModificarClave);
            panelModificar.Controls.Add(labelModificarNombre);
            panelModificar.Controls.Add(labelModificarHabilitado);
            panelModificar.Controls.Add(btnModificarModificar);
            panelModificar.Controls.Add(txtModificarId);
            panelModificar.Controls.Add(labelModificarId);
            panelModificar.Controls.Add(btnModificarBuscar);
            panelModificar.Location = new Point(24, 394);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(747, 338);
            panelModificar.TabIndex = 7;
            panelModificar.Visible = false;
            // 
            // radioModificarHabilitado
            // 
            radioModificarHabilitado.AutoSize = true;
            radioModificarHabilitado.Location = new Point(335, 121);
            radioModificarHabilitado.Name = "radioModificarHabilitado";
            radioModificarHabilitado.Size = new Size(80, 19);
            radioModificarHabilitado.TabIndex = 40;
            radioModificarHabilitado.TabStop = true;
            radioModificarHabilitado.Text = "Habilitado";
            radioModificarHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioModificarCambioClave
            // 
            radioModificarCambioClave.AutoSize = true;
            radioModificarCambioClave.Location = new Point(346, 237);
            radioModificarCambioClave.Name = "radioModificarCambioClave";
            radioModificarCambioClave.Size = new Size(99, 19);
            radioModificarCambioClave.TabIndex = 39;
            radioModificarCambioClave.TabStop = true;
            radioModificarCambioClave.Text = "CambioClave ";
            radioModificarCambioClave.UseVisualStyleBackColor = true;
            // 
            // txtModificarIdPersona
            // 
            txtModificarIdPersona.Location = new Point(96, 264);
            txtModificarIdPersona.Name = "txtModificarIdPersona";
            txtModificarIdPersona.Size = new Size(635, 23);
            txtModificarIdPersona.TabIndex = 38;
            txtModificarIdPersona.TextChanged += txtModificarIdPersona_TextChanged;
            // 
            // txtModificarMail
            // 
            txtModificarMail.Location = new Point(96, 204);
            txtModificarMail.Name = "txtModificarMail";
            txtModificarMail.Size = new Size(635, 23);
            txtModificarMail.TabIndex = 37;
            txtModificarMail.TextChanged += txtModificarMail_TextChanged;
            // 
            // txtModificarApellido
            // 
            txtModificarApellido.Location = new Point(96, 175);
            txtModificarApellido.Name = "txtModificarApellido";
            txtModificarApellido.Size = new Size(635, 23);
            txtModificarApellido.TabIndex = 36;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Location = new Point(96, 146);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(635, 23);
            txtModificarNombre.TabIndex = 35;
            // 
            // txtModificarClave
            // 
            txtModificarClave.Location = new Point(96, 88);
            txtModificarClave.Name = "txtModificarClave";
            txtModificarClave.Size = new Size(635, 23);
            txtModificarClave.TabIndex = 34;
            // 
            // txtModificarNombreUsuario
            // 
            txtModificarNombreUsuario.Location = new Point(96, 59);
            txtModificarNombreUsuario.Name = "txtModificarNombreUsuario";
            txtModificarNombreUsuario.Size = new Size(635, 23);
            txtModificarNombreUsuario.TabIndex = 33;
            txtModificarNombreUsuario.TextChanged += txtModificarNombreUsuario_TextChanged;
            // 
            // labelModificarIdPersona
            // 
            labelModificarIdPersona.AutoSize = true;
            labelModificarIdPersona.Location = new Point(12, 267);
            labelModificarIdPersona.Name = "labelModificarIdPersona";
            labelModificarIdPersona.Size = new Size(59, 15);
            labelModificarIdPersona.TabIndex = 32;
            labelModificarIdPersona.Text = "IdPersona";
            // 
            // labelModificarCambiarClave
            // 
            labelModificarCambiarClave.AutoSize = true;
            labelModificarCambiarClave.Location = new Point(9, 241);
            labelModificarCambiarClave.Name = "labelModificarCambiarClave";
            labelModificarCambiarClave.Size = new Size(81, 15);
            labelModificarCambiarClave.TabIndex = 31;
            labelModificarCambiarClave.Text = "CambiarClave";
            // 
            // labelModificarEmail
            // 
            labelModificarEmail.AutoSize = true;
            labelModificarEmail.Location = new Point(12, 212);
            labelModificarEmail.Name = "labelModificarEmail";
            labelModificarEmail.Size = new Size(36, 15);
            labelModificarEmail.TabIndex = 30;
            labelModificarEmail.Text = "Email";
            // 
            // labelModificarNombreUsuario
            // 
            labelModificarNombreUsuario.AutoSize = true;
            labelModificarNombreUsuario.Location = new Point(1, 62);
            labelModificarNombreUsuario.Name = "labelModificarNombreUsuario";
            labelModificarNombreUsuario.Size = new Size(91, 15);
            labelModificarNombreUsuario.TabIndex = 25;
            labelModificarNombreUsuario.Text = "NombreUsuario";
            // 
            // labelModificarApellido
            // 
            labelModificarApellido.AutoSize = true;
            labelModificarApellido.Location = new Point(12, 183);
            labelModificarApellido.Name = "labelModificarApellido";
            labelModificarApellido.Size = new Size(51, 15);
            labelModificarApellido.TabIndex = 29;
            labelModificarApellido.Text = "Apellido";
            // 
            // labelModificarClave
            // 
            labelModificarClave.AutoSize = true;
            labelModificarClave.Location = new Point(9, 96);
            labelModificarClave.Name = "labelModificarClave";
            labelModificarClave.Size = new Size(36, 15);
            labelModificarClave.TabIndex = 26;
            labelModificarClave.Text = "Clave";
            // 
            // labelModificarNombre
            // 
            labelModificarNombre.AutoSize = true;
            labelModificarNombre.Location = new Point(12, 154);
            labelModificarNombre.Name = "labelModificarNombre";
            labelModificarNombre.Size = new Size(51, 15);
            labelModificarNombre.TabIndex = 28;
            labelModificarNombre.Text = "Nombre";
            // 
            // labelModificarHabilitado
            // 
            labelModificarHabilitado.AutoSize = true;
            labelModificarHabilitado.Location = new Point(9, 125);
            labelModificarHabilitado.Name = "labelModificarHabilitado";
            labelModificarHabilitado.Size = new Size(62, 15);
            labelModificarHabilitado.TabIndex = 27;
            labelModificarHabilitado.Text = "Habilitado";
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(31, 295);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(664, 29);
            btnModificarModificar.TabIndex = 4;
            btnModificarModificar.Text = "ModificarModificar";
            btnModificarModificar.UseVisualStyleBackColor = true;
            btnModificarModificar.Click += btnModificarModificar_Click;
            // 
            // txtModificarId
            // 
            txtModificarId.Location = new Point(108, 29);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(371, 23);
            txtModificarId.TabIndex = 2;
            txtModificarId.TextChanged += txtModificarId_TextChanged;
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
            btnModificarBuscar.Click += btnModificarBuscar_Click;
            // 
            // panelBuscar
            // 
            panelBuscar.Controls.Add(radioBuscarHabilitado);
            panelBuscar.Controls.Add(radioBuscarCambioClave);
            panelBuscar.Controls.Add(txtBuscarIdPersona);
            panelBuscar.Controls.Add(txtBuscarMail);
            panelBuscar.Controls.Add(txtBuscarApellido);
            panelBuscar.Controls.Add(txtBuscarNombre);
            panelBuscar.Controls.Add(txtBuscarClave);
            panelBuscar.Controls.Add(txtBuscarNombreUsuario);
            panelBuscar.Controls.Add(labelBuscarIdPersona);
            panelBuscar.Controls.Add(labelBuscarCambiarClave);
            panelBuscar.Controls.Add(labelBuscarEmail);
            panelBuscar.Controls.Add(labelBuscarNombreUsuario);
            panelBuscar.Controls.Add(labelBuscarApellido);
            panelBuscar.Controls.Add(labelBuscarClave);
            panelBuscar.Controls.Add(labelBuscarNombre);
            panelBuscar.Controls.Add(labelBuscarHabilitado);
            panelBuscar.Controls.Add(txtBuscarId);
            panelBuscar.Controls.Add(btnBuscarId);
            panelBuscar.Controls.Add(labelBuscarId);
            panelBuscar.Location = new Point(794, 406);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(747, 312);
            panelBuscar.TabIndex = 8;
            panelBuscar.Visible = false;
            // 
            // radioBuscarHabilitado
            // 
            radioBuscarHabilitado.AutoSize = true;
            radioBuscarHabilitado.Location = new Point(336, 117);
            radioBuscarHabilitado.Name = "radioBuscarHabilitado";
            radioBuscarHabilitado.Size = new Size(80, 19);
            radioBuscarHabilitado.TabIndex = 40;
            radioBuscarHabilitado.TabStop = true;
            radioBuscarHabilitado.Text = "Habilitado";
            radioBuscarHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioBuscarCambioClave
            // 
            radioBuscarCambioClave.AutoSize = true;
            radioBuscarCambioClave.Location = new Point(347, 233);
            radioBuscarCambioClave.Name = "radioBuscarCambioClave";
            radioBuscarCambioClave.Size = new Size(99, 19);
            radioBuscarCambioClave.TabIndex = 39;
            radioBuscarCambioClave.TabStop = true;
            radioBuscarCambioClave.Text = "CambioClave ";
            radioBuscarCambioClave.UseVisualStyleBackColor = true;
            // 
            // txtBuscarIdPersona
            // 
            txtBuscarIdPersona.Enabled = false;
            txtBuscarIdPersona.Location = new Point(97, 260);
            txtBuscarIdPersona.Name = "txtBuscarIdPersona";
            txtBuscarIdPersona.Size = new Size(635, 23);
            txtBuscarIdPersona.TabIndex = 38;
            txtBuscarIdPersona.TextChanged += txtBuscarIdPersona_TextChanged;
            // 
            // txtBuscarMail
            // 
            txtBuscarMail.Enabled = false;
            txtBuscarMail.Location = new Point(97, 200);
            txtBuscarMail.Name = "txtBuscarMail";
            txtBuscarMail.Size = new Size(635, 23);
            txtBuscarMail.TabIndex = 37;
            txtBuscarMail.TextChanged += txtBuscarMail_TextChanged;
            // 
            // txtBuscarApellido
            // 
            txtBuscarApellido.Enabled = false;
            txtBuscarApellido.Location = new Point(97, 171);
            txtBuscarApellido.Name = "txtBuscarApellido";
            txtBuscarApellido.Size = new Size(635, 23);
            txtBuscarApellido.TabIndex = 36;
            txtBuscarApellido.TextChanged += txtBuscarApellido_TextChanged;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Enabled = false;
            txtBuscarNombre.Location = new Point(97, 142);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(635, 23);
            txtBuscarNombre.TabIndex = 35;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.Enabled = false;
            txtBuscarClave.Location = new Point(97, 84);
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.Size = new Size(635, 23);
            txtBuscarClave.TabIndex = 34;
            txtBuscarClave.TextChanged += txtBuscarClave_TextChanged;
            // 
            // txtBuscarNombreUsuario
            // 
            txtBuscarNombreUsuario.Enabled = false;
            txtBuscarNombreUsuario.Location = new Point(97, 55);
            txtBuscarNombreUsuario.Name = "txtBuscarNombreUsuario";
            txtBuscarNombreUsuario.Size = new Size(635, 23);
            txtBuscarNombreUsuario.TabIndex = 33;
            // 
            // labelBuscarIdPersona
            // 
            labelBuscarIdPersona.AutoSize = true;
            labelBuscarIdPersona.Location = new Point(13, 263);
            labelBuscarIdPersona.Name = "labelBuscarIdPersona";
            labelBuscarIdPersona.Size = new Size(59, 15);
            labelBuscarIdPersona.TabIndex = 32;
            labelBuscarIdPersona.Text = "IdPersona";
            // 
            // labelBuscarCambiarClave
            // 
            labelBuscarCambiarClave.AutoSize = true;
            labelBuscarCambiarClave.Location = new Point(10, 237);
            labelBuscarCambiarClave.Name = "labelBuscarCambiarClave";
            labelBuscarCambiarClave.Size = new Size(81, 15);
            labelBuscarCambiarClave.TabIndex = 31;
            labelBuscarCambiarClave.Text = "CambiarClave";
            // 
            // labelBuscarEmail
            // 
            labelBuscarEmail.AutoSize = true;
            labelBuscarEmail.Location = new Point(13, 208);
            labelBuscarEmail.Name = "labelBuscarEmail";
            labelBuscarEmail.Size = new Size(36, 15);
            labelBuscarEmail.TabIndex = 30;
            labelBuscarEmail.Text = "Email";
            // 
            // labelBuscarNombreUsuario
            // 
            labelBuscarNombreUsuario.AutoSize = true;
            labelBuscarNombreUsuario.Location = new Point(2, 58);
            labelBuscarNombreUsuario.Name = "labelBuscarNombreUsuario";
            labelBuscarNombreUsuario.Size = new Size(91, 15);
            labelBuscarNombreUsuario.TabIndex = 25;
            labelBuscarNombreUsuario.Text = "NombreUsuario";
            // 
            // labelBuscarApellido
            // 
            labelBuscarApellido.AutoSize = true;
            labelBuscarApellido.Location = new Point(13, 179);
            labelBuscarApellido.Name = "labelBuscarApellido";
            labelBuscarApellido.Size = new Size(51, 15);
            labelBuscarApellido.TabIndex = 29;
            labelBuscarApellido.Text = "Apellido";
            // 
            // labelBuscarClave
            // 
            labelBuscarClave.AutoSize = true;
            labelBuscarClave.Location = new Point(10, 92);
            labelBuscarClave.Name = "labelBuscarClave";
            labelBuscarClave.Size = new Size(36, 15);
            labelBuscarClave.TabIndex = 26;
            labelBuscarClave.Text = "Clave";
            // 
            // labelBuscarNombre
            // 
            labelBuscarNombre.AutoSize = true;
            labelBuscarNombre.Location = new Point(13, 150);
            labelBuscarNombre.Name = "labelBuscarNombre";
            labelBuscarNombre.Size = new Size(51, 15);
            labelBuscarNombre.TabIndex = 28;
            labelBuscarNombre.Text = "Nombre";
            // 
            // labelBuscarHabilitado
            // 
            labelBuscarHabilitado.AutoSize = true;
            labelBuscarHabilitado.Location = new Point(10, 121);
            labelBuscarHabilitado.Name = "labelBuscarHabilitado";
            labelBuscarHabilitado.Size = new Size(62, 15);
            labelBuscarHabilitado.TabIndex = 27;
            labelBuscarHabilitado.Text = "Habilitado";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(143, 26);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(443, 23);
            txtBuscarId.TabIndex = 2;
            txtBuscarId.TextChanged += txtBuscarId_TextChanged;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(632, 25);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(75, 23);
            btnBuscarId.TabIndex = 1;
            btnBuscarId.Text = "BuscarId";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
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
            panelCrear.Controls.Add(radioCrearHabilitado);
            panelCrear.Controls.Add(radioCrearCambioClave);
            panelCrear.Controls.Add(txtCrearIdPersona);
            panelCrear.Controls.Add(txtCrearEmail);
            panelCrear.Controls.Add(txtCrearApellido);
            panelCrear.Controls.Add(txtCrearNombre);
            panelCrear.Controls.Add(txtCrearClave);
            panelCrear.Controls.Add(txtCrearNombreUsuario);
            panelCrear.Controls.Add(labelCrearIdPersona);
            panelCrear.Controls.Add(btnCrearCrear);
            panelCrear.Controls.Add(labelCrearCambiarClave);
            panelCrear.Controls.Add(labelCrearEmail);
            panelCrear.Controls.Add(labelCrearNombreUsuario);
            panelCrear.Controls.Add(labelCrearApellido);
            panelCrear.Controls.Add(labelCrearClave);
            panelCrear.Controls.Add(labelCrearNombre);
            panelCrear.Controls.Add(labelCrearHabilitado);
            panelCrear.Location = new Point(777, 90);
            panelCrear.Name = "panelCrear";
            panelCrear.Size = new Size(762, 296);
            panelCrear.TabIndex = 5;
            // 
            // radioCrearHabilitado
            // 
            radioCrearHabilitado.AutoSize = true;
            radioCrearHabilitado.Location = new Point(343, 74);
            radioCrearHabilitado.Name = "radioCrearHabilitado";
            radioCrearHabilitado.Size = new Size(80, 19);
            radioCrearHabilitado.TabIndex = 24;
            radioCrearHabilitado.TabStop = true;
            radioCrearHabilitado.Text = "Habilitado";
            radioCrearHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioCrearCambioClave
            // 
            radioCrearCambioClave.AutoSize = true;
            radioCrearCambioClave.Location = new Point(354, 190);
            radioCrearCambioClave.Name = "radioCrearCambioClave";
            radioCrearCambioClave.Size = new Size(99, 19);
            radioCrearCambioClave.TabIndex = 23;
            radioCrearCambioClave.TabStop = true;
            radioCrearCambioClave.Text = "CambioClave ";
            radioCrearCambioClave.UseVisualStyleBackColor = true;
            // 
            // txtCrearIdPersona
            // 
            txtCrearIdPersona.Location = new Point(104, 217);
            txtCrearIdPersona.Name = "txtCrearIdPersona";
            txtCrearIdPersona.Size = new Size(635, 23);
            txtCrearIdPersona.TabIndex = 22;
            txtCrearIdPersona.TextChanged += txtCrearIdPersona_TextChanged;
            // 
            // txtCrearEmail
            // 
            txtCrearEmail.Location = new Point(104, 157);
            txtCrearEmail.Name = "txtCrearEmail";
            txtCrearEmail.Size = new Size(635, 23);
            txtCrearEmail.TabIndex = 20;
            // 
            // txtCrearApellido
            // 
            txtCrearApellido.Location = new Point(104, 128);
            txtCrearApellido.Name = "txtCrearApellido";
            txtCrearApellido.Size = new Size(635, 23);
            txtCrearApellido.TabIndex = 19;
            // 
            // txtCrearNombre
            // 
            txtCrearNombre.Location = new Point(104, 99);
            txtCrearNombre.Name = "txtCrearNombre";
            txtCrearNombre.Size = new Size(635, 23);
            txtCrearNombre.TabIndex = 18;
            // 
            // txtCrearClave
            // 
            txtCrearClave.Location = new Point(104, 41);
            txtCrearClave.Name = "txtCrearClave";
            txtCrearClave.Size = new Size(635, 23);
            txtCrearClave.TabIndex = 16;
            // 
            // txtCrearNombreUsuario
            // 
            txtCrearNombreUsuario.Location = new Point(104, 12);
            txtCrearNombreUsuario.Name = "txtCrearNombreUsuario";
            txtCrearNombreUsuario.Size = new Size(635, 23);
            txtCrearNombreUsuario.TabIndex = 15;
            // 
            // labelCrearIdPersona
            // 
            labelCrearIdPersona.AutoSize = true;
            labelCrearIdPersona.Location = new Point(20, 220);
            labelCrearIdPersona.Name = "labelCrearIdPersona";
            labelCrearIdPersona.Size = new Size(59, 15);
            labelCrearIdPersona.TabIndex = 14;
            labelCrearIdPersona.Text = "IdPersona";
            // 
            // btnCrearCrear
            // 
            btnCrearCrear.Location = new Point(39, 247);
            btnCrearCrear.Name = "btnCrearCrear";
            btnCrearCrear.Size = new Size(700, 31);
            btnCrearCrear.TabIndex = 0;
            btnCrearCrear.Text = "CrearCrear";
            btnCrearCrear.UseVisualStyleBackColor = true;
            btnCrearCrear.Click += btnCrearCrear_Click;
            // 
            // labelCrearCambiarClave
            // 
            labelCrearCambiarClave.AutoSize = true;
            labelCrearCambiarClave.Location = new Point(17, 194);
            labelCrearCambiarClave.Name = "labelCrearCambiarClave";
            labelCrearCambiarClave.Size = new Size(81, 15);
            labelCrearCambiarClave.TabIndex = 13;
            labelCrearCambiarClave.Text = "CambiarClave";
            // 
            // labelCrearEmail
            // 
            labelCrearEmail.AutoSize = true;
            labelCrearEmail.Location = new Point(20, 165);
            labelCrearEmail.Name = "labelCrearEmail";
            labelCrearEmail.Size = new Size(36, 15);
            labelCrearEmail.TabIndex = 12;
            labelCrearEmail.Text = "Email";
            // 
            // labelCrearNombreUsuario
            // 
            labelCrearNombreUsuario.AutoSize = true;
            labelCrearNombreUsuario.Location = new Point(9, 15);
            labelCrearNombreUsuario.Name = "labelCrearNombreUsuario";
            labelCrearNombreUsuario.Size = new Size(91, 15);
            labelCrearNombreUsuario.TabIndex = 7;
            labelCrearNombreUsuario.Text = "NombreUsuario";
            // 
            // labelCrearApellido
            // 
            labelCrearApellido.AutoSize = true;
            labelCrearApellido.Location = new Point(20, 136);
            labelCrearApellido.Name = "labelCrearApellido";
            labelCrearApellido.Size = new Size(51, 15);
            labelCrearApellido.TabIndex = 11;
            labelCrearApellido.Text = "Apellido";
            // 
            // labelCrearClave
            // 
            labelCrearClave.AutoSize = true;
            labelCrearClave.Location = new Point(17, 49);
            labelCrearClave.Name = "labelCrearClave";
            labelCrearClave.Size = new Size(36, 15);
            labelCrearClave.TabIndex = 8;
            labelCrearClave.Text = "Clave";
            // 
            // labelCrearNombre
            // 
            labelCrearNombre.AutoSize = true;
            labelCrearNombre.Location = new Point(20, 107);
            labelCrearNombre.Name = "labelCrearNombre";
            labelCrearNombre.Size = new Size(51, 15);
            labelCrearNombre.TabIndex = 10;
            labelCrearNombre.Text = "Nombre";
            // 
            // labelCrearHabilitado
            // 
            labelCrearHabilitado.AutoSize = true;
            labelCrearHabilitado.Location = new Point(17, 78);
            labelCrearHabilitado.Name = "labelCrearHabilitado";
            labelCrearHabilitado.Size = new Size(62, 15);
            labelCrearHabilitado.TabIndex = 9;
            labelCrearHabilitado.Text = "Habilitado";
            // 
            // Volver
            // 
            Volver.Location = new Point(25, 756);
            Volver.Name = "Volver";
            Volver.Size = new Size(743, 37);
            Volver.TabIndex = 9;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
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
            Name = "UsuarioCrud";
            Text = "UsuarioCrud";
            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
            panelModificar.ResumeLayout(false);
            panelModificar.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelCrear.ResumeLayout(false);
            panelCrear.PerformLayout();
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
        private TextBox txtCrearIdPersona;
        private TextBox txtCrearEmail;
        private TextBox txtCrearApellido;
        private TextBox txtCrearNombre;
        private TextBox txtCrearClave;
        private TextBox txtCrearNombreUsuario;
        private Label labelCrearIdPersona;
        private Label labelCrearCambiarClave;
        private Label labelCrearEmail;
        private Label labelCrearNombreUsuario;
        private Label labelCrearApellido;
        private Label labelCrearClave;
        private Label labelCrearNombre;
        private Label labelCrearHabilitado;
        private RadioButton radioCrearHabilitado;
        private RadioButton radioCrearCambioClave;
        private RadioButton radioModificarHabilitado;
        private RadioButton radioModificarCambioClave;
        private TextBox txtModificarIdPersona;
        private TextBox txtModificarMail;
        private TextBox txtModificarApellido;
        private TextBox txtModificarNombre;
        private TextBox txtModificarClave;
        private TextBox txtModificarNombreUsuario;
        private Label labelModificarIdPersona;
        private Label labelModificarCambiarClave;
        private Label labelModificarEmail;
        private Label labelModificarNombreUsuario;
        private Label labelModificarApellido;
        private Label labelModificarClave;
        private Label labelModificarNombre;
        private Label labelModificarHabilitado;
        private RadioButton radioBuscarHabilitado;
        private RadioButton radioBuscarCambioClave;
        private TextBox txtBuscarIdPersona;
        private TextBox txtBuscarMail;
        private TextBox txtBuscarApellido;
        private TextBox txtBuscarNombre;
        private TextBox txtBuscarClave;
        private TextBox txtBuscarNombreUsuario;
        private Label labelBuscarIdPersona;
        private Label labelBuscarCambiarClave;
        private Label labelBuscarEmail;
        private Label labelBuscarNombreUsuario;
        private Label labelBuscarApellido;
        private Label labelBuscarClave;
        private Label labelBuscarNombre;
        private Label labelBuscarHabilitado;
    }

    }
