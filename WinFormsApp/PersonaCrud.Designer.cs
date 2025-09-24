using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp
{
    partial class PersonaCrud
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnCrear;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnBorrar;

        private Panel panelCrear;
        private Panel panelBuscar;
        private Panel panelModificar;
        private Panel panelBorrar;

        // Controles panel Crear
        private Label lblNombreCrear;
        private TextBox txtNombreCrear;
        private Button btnGuardarCrear;

        // Controles panel Buscar
        private Label lblIdBuscar;
        private TextBox txtIdBuscar;
        private Button btnBuscarBuscar;

        // Controles panel Modificar
        private Label lblIdModificar;
        private TextBox txtIdModificar;
        private Button btnModificarModificar;

        // Controles panel Borrar
        private Label lblIdBorrar;
        private TextBox txtIdBorrar;
        private Button btnBorrarBorrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCrear = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            panelCrear = new Panel();
            dateTimePicker1 = new DateTimePicker();
            lblCrearFechaNac = new Label();
            lblCrearTipoUsuario = new Label();
            RadioAlumno = new RadioButton();
            RadioProfesor = new RadioButton();
            lblCrearTelefono = new Label();
            lblCrearEmail = new Label();
            lblCrearDireccion = new Label();
            txtCrearTelefono = new TextBox();
            txtCrearEmail = new TextBox();
            txtCrearDireccion = new TextBox();
            txtCrearApellido = new TextBox();
            lblCrearApellido = new Label();
            lblNombreCrear = new Label();
            txtNombreCrear = new TextBox();
            btnGuardarCrear = new Button();
            panelBuscar = new Panel();
            lblBuscarApellido = new Label();
            txtBuscarEmail = new TextBox();
            txtBuscarLegajo = new TextBox();
            txtBuscarFechaNac = new TextBox();
            txtBuscarTipoUsuario = new TextBox();
            lblBuscarEmail = new Label();
            lblBuscarLegajo = new Label();
            lblBuscarFechaNac = new Label();
            lblBuscarTipoUsuario = new Label();
            lblBuscarTelefono = new Label();
            lblBuscarDireccion = new Label();
            lblBuscarNombre = new Label();
            txtBuscarTelefono = new TextBox();
            txtBuscarDireccion = new TextBox();
            txtBuscarApellido = new TextBox();
            txtBuscarNombre = new TextBox();
            lblIdBuscar = new Label();
            txtIdBuscar = new TextBox();
            btnBuscarBuscar = new Button();
            panelModificar = new Panel();
            BuscarModificar = new Button();
            lblModificarApellido = new Label();
            txtModificarEmail = new TextBox();
            txtModificarLegajo = new TextBox();
            txtModificarFechaNac = new TextBox();
            txtModificarTipoUsuario = new TextBox();
            lblModificarEmail = new Label();
            lblModificarLegajo = new Label();
            lblModificarFechaNac = new Label();
            lblModificarTipoUsuario = new Label();
            lblModificarTelefono = new Label();
            lblModificarDireccion = new Label();
            lblModificarNombre = new Label();
            txtModificarTelefono = new TextBox();
            txtModificarDireccion = new TextBox();
            txtModificarApellido = new TextBox();
            txtModificarNombre = new TextBox();
            lblIdModificar = new Label();
            txtIdModificar = new TextBox();
            btnModificarModificar = new Button();
            panelBorrar = new Panel();
            lblIdBorrar = new Label();
            txtIdBorrar = new TextBox();
            btnBorrarBorrar = new Button();
            btnVolver = new Button();
            panelCrear.SuspendLayout();
            panelBuscar.SuspendLayout();
            panelModificar.SuspendLayout();
            panelBorrar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(20, 20);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(80, 30);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(110, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 30);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(200, 20);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 30);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(290, 20);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(80, 30);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.Click += btnBorrar_Click;
            // 
            // panelCrear
            // 
            panelCrear.BorderStyle = BorderStyle.FixedSingle;
            panelCrear.Controls.Add(dateTimePicker1);
            panelCrear.Controls.Add(lblCrearFechaNac);
            panelCrear.Controls.Add(lblCrearTipoUsuario);
            panelCrear.Controls.Add(RadioAlumno);
            panelCrear.Controls.Add(RadioProfesor);
            panelCrear.Controls.Add(lblCrearTelefono);
            panelCrear.Controls.Add(lblCrearEmail);
            panelCrear.Controls.Add(lblCrearDireccion);
            panelCrear.Controls.Add(txtCrearTelefono);
            panelCrear.Controls.Add(txtCrearEmail);
            panelCrear.Controls.Add(txtCrearDireccion);
            panelCrear.Controls.Add(txtCrearApellido);
            panelCrear.Controls.Add(lblCrearApellido);
            panelCrear.Controls.Add(lblNombreCrear);
            panelCrear.Controls.Add(txtNombreCrear);
            panelCrear.Controls.Add(btnGuardarCrear);
            panelCrear.Location = new Point(20, 70);
            panelCrear.Name = "panelCrear";
            panelCrear.Size = new Size(582, 327);
            panelCrear.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // lblCrearFechaNac
            // 
            lblCrearFechaNac.AutoSize = true;
            lblCrearFechaNac.Location = new Point(20, 205);
            lblCrearFechaNac.Name = "lblCrearFechaNac";
            lblCrearFechaNac.Size = new Size(59, 15);
            lblCrearFechaNac.TabIndex = 14;
            lblCrearFechaNac.Text = "FechaNac";
            // 
            // lblCrearTipoUsuario
            // 
            lblCrearTipoUsuario.AutoSize = true;
            lblCrearTipoUsuario.Location = new Point(20, 237);
            lblCrearTipoUsuario.Name = "lblCrearTipoUsuario";
            lblCrearTipoUsuario.Size = new Size(71, 15);
            lblCrearTipoUsuario.TabIndex = 13;
            lblCrearTipoUsuario.Text = "TipoUsuario";
            // 
            // RadioAlumno
            // 
            RadioAlumno.AutoSize = true;
            RadioAlumno.Location = new Point(369, 235);
            RadioAlumno.Name = "RadioAlumno";
            RadioAlumno.Size = new Size(98, 19);
            RadioAlumno.TabIndex = 12;
            RadioAlumno.TabStop = true;
            RadioAlumno.Text = "RadioAlumno";
            RadioAlumno.UseVisualStyleBackColor = true;
            // 
            // RadioProfesor
            // 
            RadioProfesor.AutoSize = true;
            RadioProfesor.Location = new Point(125, 235);
            RadioProfesor.Name = "RadioProfesor";
            RadioProfesor.Size = new Size(99, 19);
            RadioProfesor.TabIndex = 11;
            RadioProfesor.TabStop = true;
            RadioProfesor.Text = "RadioProfesor";
            RadioProfesor.UseVisualStyleBackColor = true;
            // 
            // lblCrearTelefono
            // 
            lblCrearTelefono.AutoSize = true;
            lblCrearTelefono.Location = new Point(20, 167);
            lblCrearTelefono.Name = "lblCrearTelefono";
            lblCrearTelefono.Size = new Size(53, 15);
            lblCrearTelefono.TabIndex = 10;
            lblCrearTelefono.Text = "Telefono";
            // 
            // lblCrearEmail
            // 
            lblCrearEmail.AutoSize = true;
            lblCrearEmail.Location = new Point(20, 129);
            lblCrearEmail.Name = "lblCrearEmail";
            lblCrearEmail.Size = new Size(36, 15);
            lblCrearEmail.TabIndex = 9;
            lblCrearEmail.Text = "Email";
            // 
            // lblCrearDireccion
            // 
            lblCrearDireccion.AutoSize = true;
            lblCrearDireccion.Location = new Point(20, 92);
            lblCrearDireccion.Name = "lblCrearDireccion";
            lblCrearDireccion.Size = new Size(57, 15);
            lblCrearDireccion.TabIndex = 8;
            lblCrearDireccion.Text = "Direccion";
            // 
            // txtCrearTelefono
            // 
            txtCrearTelefono.Location = new Point(116, 164);
            txtCrearTelefono.Name = "txtCrearTelefono";
            txtCrearTelefono.Size = new Size(347, 23);
            txtCrearTelefono.TabIndex = 7;
            txtCrearTelefono.TextChanged += TextTelefono_TextChanged;
            // 
            // txtCrearEmail
            // 
            txtCrearEmail.Location = new Point(116, 126);
            txtCrearEmail.Name = "txtCrearEmail";
            txtCrearEmail.Size = new Size(347, 23);
            txtCrearEmail.TabIndex = 6;
            txtCrearEmail.TextChanged += TextEmail_TextChanged;
            // 
            // txtCrearDireccion
            // 
            txtCrearDireccion.Location = new Point(116, 89);
            txtCrearDireccion.Name = "txtCrearDireccion";
            txtCrearDireccion.Size = new Size(347, 23);
            txtCrearDireccion.TabIndex = 5;
            // 
            // txtCrearApellido
            // 
            txtCrearApellido.Location = new Point(116, 49);
            txtCrearApellido.Name = "txtCrearApellido";
            txtCrearApellido.Size = new Size(347, 23);
            txtCrearApellido.TabIndex = 4;
            // 
            // lblCrearApellido
            // 
            lblCrearApellido.AutoSize = true;
            lblCrearApellido.Location = new Point(20, 52);
            lblCrearApellido.Name = "lblCrearApellido";
            lblCrearApellido.Size = new Size(51, 15);
            lblCrearApellido.TabIndex = 3;
            lblCrearApellido.Text = "Apellido";
            // 
            // lblNombreCrear
            // 
            lblNombreCrear.Location = new Point(20, 17);
            lblNombreCrear.Name = "lblNombreCrear";
            lblNombreCrear.Size = new Size(64, 23);
            lblNombreCrear.TabIndex = 0;
            lblNombreCrear.Text = "Nombre:";
            // 
            // txtNombreCrear
            // 
            txtNombreCrear.Location = new Point(116, 17);
            txtNombreCrear.Name = "txtNombreCrear";
            txtNombreCrear.Size = new Size(347, 23);
            txtNombreCrear.TabIndex = 1;
            // 
            // btnGuardarCrear
            // 
            btnGuardarCrear.Location = new Point(10, 284);
            btnGuardarCrear.Name = "btnGuardarCrear";
            btnGuardarCrear.Size = new Size(560, 23);
            btnGuardarCrear.TabIndex = 2;
            btnGuardarCrear.Text = "Cargar";
            btnGuardarCrear.Click += btnGuardarCrear_Click_1;
            // 
            // panelBuscar
            // 
            panelBuscar.BorderStyle = BorderStyle.FixedSingle;
            panelBuscar.Controls.Add(lblBuscarApellido);
            panelBuscar.Controls.Add(txtBuscarEmail);
            panelBuscar.Controls.Add(txtBuscarLegajo);
            panelBuscar.Controls.Add(txtBuscarFechaNac);
            panelBuscar.Controls.Add(txtBuscarTipoUsuario);
            panelBuscar.Controls.Add(lblBuscarEmail);
            panelBuscar.Controls.Add(lblBuscarLegajo);
            panelBuscar.Controls.Add(lblBuscarFechaNac);
            panelBuscar.Controls.Add(lblBuscarTipoUsuario);
            panelBuscar.Controls.Add(lblBuscarTelefono);
            panelBuscar.Controls.Add(lblBuscarDireccion);
            panelBuscar.Controls.Add(lblBuscarNombre);
            panelBuscar.Controls.Add(txtBuscarTelefono);
            panelBuscar.Controls.Add(txtBuscarDireccion);
            panelBuscar.Controls.Add(txtBuscarApellido);
            panelBuscar.Controls.Add(txtBuscarNombre);
            panelBuscar.Controls.Add(lblIdBuscar);
            panelBuscar.Controls.Add(txtIdBuscar);
            panelBuscar.Controls.Add(btnBuscarBuscar);
            panelBuscar.Location = new Point(20, 70);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(582, 297);
            panelBuscar.TabIndex = 5;
            // 
            // lblBuscarApellido
            // 
            lblBuscarApellido.AutoSize = true;
            lblBuscarApellido.Location = new Point(20, 126);
            lblBuscarApellido.Name = "lblBuscarApellido";
            lblBuscarApellido.Size = new Size(51, 15);
            lblBuscarApellido.TabIndex = 19;
            lblBuscarApellido.Text = "Apellido";
            // 
            // txtBuscarEmail
            // 
            txtBuscarEmail.Location = new Point(369, 208);
            txtBuscarEmail.Name = "txtBuscarEmail";
            txtBuscarEmail.Size = new Size(171, 23);
            txtBuscarEmail.TabIndex = 18;
            // 
            // txtBuscarLegajo
            // 
            txtBuscarLegajo.Location = new Point(109, 211);
            txtBuscarLegajo.Name = "txtBuscarLegajo";
            txtBuscarLegajo.Size = new Size(171, 23);
            txtBuscarLegajo.TabIndex = 17;
            // 
            // txtBuscarFechaNac
            // 
            txtBuscarFechaNac.Location = new Point(369, 167);
            txtBuscarFechaNac.Name = "txtBuscarFechaNac";
            txtBuscarFechaNac.Size = new Size(171, 23);
            txtBuscarFechaNac.TabIndex = 16;
            // 
            // txtBuscarTipoUsuario
            // 
            txtBuscarTipoUsuario.Location = new Point(109, 167);
            txtBuscarTipoUsuario.Name = "txtBuscarTipoUsuario";
            txtBuscarTipoUsuario.Size = new Size(171, 23);
            txtBuscarTipoUsuario.TabIndex = 15;
            // 
            // lblBuscarEmail
            // 
            lblBuscarEmail.AutoSize = true;
            lblBuscarEmail.Location = new Point(307, 211);
            lblBuscarEmail.Name = "lblBuscarEmail";
            lblBuscarEmail.Size = new Size(36, 15);
            lblBuscarEmail.TabIndex = 14;
            lblBuscarEmail.Text = "Email";
            // 
            // lblBuscarLegajo
            // 
            lblBuscarLegajo.AutoSize = true;
            lblBuscarLegajo.Location = new Point(20, 211);
            lblBuscarLegajo.Name = "lblBuscarLegajo";
            lblBuscarLegajo.Size = new Size(42, 15);
            lblBuscarLegajo.TabIndex = 13;
            lblBuscarLegajo.Text = "Legajo";
            // 
            // lblBuscarFechaNac
            // 
            lblBuscarFechaNac.AutoSize = true;
            lblBuscarFechaNac.Location = new Point(307, 175);
            lblBuscarFechaNac.Name = "lblBuscarFechaNac";
            lblBuscarFechaNac.Size = new Size(59, 15);
            lblBuscarFechaNac.TabIndex = 12;
            lblBuscarFechaNac.Text = "FechaNac";
            // 
            // lblBuscarTipoUsuario
            // 
            lblBuscarTipoUsuario.AutoSize = true;
            lblBuscarTipoUsuario.Location = new Point(20, 170);
            lblBuscarTipoUsuario.Name = "lblBuscarTipoUsuario";
            lblBuscarTipoUsuario.Size = new Size(71, 15);
            lblBuscarTipoUsuario.TabIndex = 11;
            lblBuscarTipoUsuario.Text = "TipoUsuario";
            // 
            // lblBuscarTelefono
            // 
            lblBuscarTelefono.AutoSize = true;
            lblBuscarTelefono.Location = new Point(307, 125);
            lblBuscarTelefono.Name = "lblBuscarTelefono";
            lblBuscarTelefono.Size = new Size(53, 15);
            lblBuscarTelefono.TabIndex = 10;
            lblBuscarTelefono.Text = "Telefono";
            // 
            // lblBuscarDireccion
            // 
            lblBuscarDireccion.AutoSize = true;
            lblBuscarDireccion.Location = new Point(307, 74);
            lblBuscarDireccion.Name = "lblBuscarDireccion";
            lblBuscarDireccion.Size = new Size(57, 15);
            lblBuscarDireccion.TabIndex = 9;
            lblBuscarDireccion.Text = "Direccion";
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Location = new Point(20, 79);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(51, 15);
            lblBuscarNombre.TabIndex = 7;
            lblBuscarNombre.Text = "Nombre";
            // 
            // txtBuscarTelefono
            // 
            txtBuscarTelefono.Location = new Point(369, 122);
            txtBuscarTelefono.Name = "txtBuscarTelefono";
            txtBuscarTelefono.Size = new Size(171, 23);
            txtBuscarTelefono.TabIndex = 6;
            // 
            // txtBuscarDireccion
            // 
            txtBuscarDireccion.Location = new Point(369, 71);
            txtBuscarDireccion.Name = "txtBuscarDireccion";
            txtBuscarDireccion.Size = new Size(171, 23);
            txtBuscarDireccion.TabIndex = 5;
            // 
            // txtBuscarApellido
            // 
            txtBuscarApellido.Location = new Point(109, 126);
            txtBuscarApellido.Name = "txtBuscarApellido";
            txtBuscarApellido.Size = new Size(171, 23);
            txtBuscarApellido.TabIndex = 4;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(109, 71);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(171, 23);
            txtBuscarNombre.TabIndex = 3;
            // 
            // lblIdBuscar
            // 
            lblIdBuscar.Location = new Point(10, 20);
            lblIdBuscar.Name = "lblIdBuscar";
            lblIdBuscar.Size = new Size(100, 23);
            lblIdBuscar.TabIndex = 0;
            lblIdBuscar.Text = "ID:";
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Location = new Point(109, 20);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(171, 23);
            txtIdBuscar.TabIndex = 1;
            txtIdBuscar.TextChanged += txtIdBuscar_TextChanged;
            // 
            // btnBuscarBuscar
            // 
            btnBuscarBuscar.Location = new Point(449, 20);
            btnBuscarBuscar.Name = "btnBuscarBuscar";
            btnBuscarBuscar.Size = new Size(75, 23);
            btnBuscarBuscar.TabIndex = 2;
            btnBuscarBuscar.Text = "Buscar";
            btnBuscarBuscar.Click += btnBuscarBuscar_Click_1;
            // 
            // panelModificar
            // 
            panelModificar.BorderStyle = BorderStyle.FixedSingle;
            panelModificar.Controls.Add(BuscarModificar);
            panelModificar.Controls.Add(lblModificarApellido);
            panelModificar.Controls.Add(txtModificarEmail);
            panelModificar.Controls.Add(txtModificarLegajo);
            panelModificar.Controls.Add(txtModificarFechaNac);
            panelModificar.Controls.Add(txtModificarTipoUsuario);
            panelModificar.Controls.Add(lblModificarEmail);
            panelModificar.Controls.Add(lblModificarLegajo);
            panelModificar.Controls.Add(lblModificarFechaNac);
            panelModificar.Controls.Add(lblModificarTipoUsuario);
            panelModificar.Controls.Add(lblModificarTelefono);
            panelModificar.Controls.Add(lblModificarDireccion);
            panelModificar.Controls.Add(lblModificarNombre);
            panelModificar.Controls.Add(txtModificarTelefono);
            panelModificar.Controls.Add(txtModificarDireccion);
            panelModificar.Controls.Add(txtModificarApellido);
            panelModificar.Controls.Add(txtModificarNombre);
            panelModificar.Controls.Add(lblIdModificar);
            panelModificar.Controls.Add(txtIdModificar);
            panelModificar.Controls.Add(btnModificarModificar);
            panelModificar.Location = new Point(20, 70);
            panelModificar.Name = "panelModificar";
            panelModificar.Size = new Size(582, 297);
            panelModificar.TabIndex = 6;
            panelModificar.Visible = false;
            panelModificar.Paint += panelModificar_Paint;
            // 
            // BuscarModificar
            // 
            BuscarModificar.Location = new Point(366, 20);
            BuscarModificar.Name = "BuscarModificar";
            BuscarModificar.Size = new Size(171, 23);
            BuscarModificar.TabIndex = 39;
            BuscarModificar.Text = "BuscarModificar";
            BuscarModificar.UseVisualStyleBackColor = true;
            BuscarModificar.Click += BuscarModificar_Click;
            // 
            // lblModificarApellido
            // 
            lblModificarApellido.AutoSize = true;
            lblModificarApellido.Location = new Point(17, 130);
            lblModificarApellido.Name = "lblModificarApellido";
            lblModificarApellido.Size = new Size(51, 15);
            lblModificarApellido.TabIndex = 38;
            lblModificarApellido.Text = "Apellido";
            // 
            // txtModificarEmail
            // 
            txtModificarEmail.Location = new Point(366, 212);
            txtModificarEmail.Name = "txtModificarEmail";
            txtModificarEmail.Size = new Size(171, 23);
            txtModificarEmail.TabIndex = 37;
            // 
            // txtModificarLegajo
            // 
            txtModificarLegajo.Location = new Point(106, 215);
            txtModificarLegajo.Name = "txtModificarLegajo";
            txtModificarLegajo.Size = new Size(171, 23);
            txtModificarLegajo.TabIndex = 36;
            // 
            // txtModificarFechaNac
            // 
            txtModificarFechaNac.Location = new Point(366, 171);
            txtModificarFechaNac.Name = "txtModificarFechaNac";
            txtModificarFechaNac.Size = new Size(171, 23);
            txtModificarFechaNac.TabIndex = 35;
            // 
            // txtModificarTipoUsuario
            // 
            txtModificarTipoUsuario.Location = new Point(106, 171);
            txtModificarTipoUsuario.Name = "txtModificarTipoUsuario";
            txtModificarTipoUsuario.Size = new Size(171, 23);
            txtModificarTipoUsuario.TabIndex = 34;
            // 
            // lblModificarEmail
            // 
            lblModificarEmail.AutoSize = true;
            lblModificarEmail.Location = new Point(304, 215);
            lblModificarEmail.Name = "lblModificarEmail";
            lblModificarEmail.Size = new Size(36, 15);
            lblModificarEmail.TabIndex = 33;
            lblModificarEmail.Text = "Email";
            // 
            // lblModificarLegajo
            // 
            lblModificarLegajo.AutoSize = true;
            lblModificarLegajo.Location = new Point(17, 215);
            lblModificarLegajo.Name = "lblModificarLegajo";
            lblModificarLegajo.Size = new Size(42, 15);
            lblModificarLegajo.TabIndex = 32;
            lblModificarLegajo.Text = "Legajo";
            // 
            // lblModificarFechaNac
            // 
            lblModificarFechaNac.AutoSize = true;
            lblModificarFechaNac.Location = new Point(304, 179);
            lblModificarFechaNac.Name = "lblModificarFechaNac";
            lblModificarFechaNac.Size = new Size(59, 15);
            lblModificarFechaNac.TabIndex = 31;
            lblModificarFechaNac.Text = "FechaNac";
            // 
            // lblModificarTipoUsuario
            // 
            lblModificarTipoUsuario.AutoSize = true;
            lblModificarTipoUsuario.Location = new Point(17, 174);
            lblModificarTipoUsuario.Name = "lblModificarTipoUsuario";
            lblModificarTipoUsuario.Size = new Size(71, 15);
            lblModificarTipoUsuario.TabIndex = 30;
            lblModificarTipoUsuario.Text = "TipoUsuario";
            // 
            // lblModificarTelefono
            // 
            lblModificarTelefono.AutoSize = true;
            lblModificarTelefono.Location = new Point(304, 129);
            lblModificarTelefono.Name = "lblModificarTelefono";
            lblModificarTelefono.Size = new Size(53, 15);
            lblModificarTelefono.TabIndex = 29;
            lblModificarTelefono.Text = "Telefono";
            // 
            // lblModificarDireccion
            // 
            lblModificarDireccion.AutoSize = true;
            lblModificarDireccion.Location = new Point(304, 78);
            lblModificarDireccion.Name = "lblModificarDireccion";
            lblModificarDireccion.Size = new Size(57, 15);
            lblModificarDireccion.TabIndex = 28;
            lblModificarDireccion.Text = "Direccion";
            // 
            // lblModificarNombre
            // 
            lblModificarNombre.AutoSize = true;
            lblModificarNombre.Location = new Point(17, 83);
            lblModificarNombre.Name = "lblModificarNombre";
            lblModificarNombre.Size = new Size(51, 15);
            lblModificarNombre.TabIndex = 27;
            lblModificarNombre.Text = "Nombre";
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Location = new Point(366, 126);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(171, 23);
            txtModificarTelefono.TabIndex = 26;
            txtModificarTelefono.TextChanged += textBox13_TextChanged;
            // 
            // txtModificarDireccion
            // 
            txtModificarDireccion.Location = new Point(366, 75);
            txtModificarDireccion.Name = "txtModificarDireccion";
            txtModificarDireccion.Size = new Size(171, 23);
            txtModificarDireccion.TabIndex = 25;
            // 
            // txtModificarApellido
            // 
            txtModificarApellido.Location = new Point(106, 130);
            txtModificarApellido.Name = "txtModificarApellido";
            txtModificarApellido.Size = new Size(171, 23);
            txtModificarApellido.TabIndex = 24;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Location = new Point(106, 75);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(171, 23);
            txtModificarNombre.TabIndex = 23;
            // 
            // lblIdModificar
            // 
            lblIdModificar.Location = new Point(10, 20);
            lblIdModificar.Name = "lblIdModificar";
            lblIdModificar.Size = new Size(100, 23);
            lblIdModificar.TabIndex = 0;
            lblIdModificar.Text = "ID:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(106, 20);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(174, 23);
            txtIdModificar.TabIndex = 1;
            txtIdModificar.TextChanged += txtIdModificar_TextChanged;
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Location = new Point(17, 254);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(520, 23);
            btnModificarModificar.TabIndex = 2;
            btnModificarModificar.Text = "Modificar";
            btnModificarModificar.Click += btnModificarModificar_Click_1;
            // 
            // panelBorrar
            // 
            panelBorrar.BorderStyle = BorderStyle.FixedSingle;
            panelBorrar.Controls.Add(lblIdBorrar);
            panelBorrar.Controls.Add(txtIdBorrar);
            panelBorrar.Controls.Add(btnBorrarBorrar);
            panelBorrar.Location = new Point(20, 70);
            panelBorrar.Name = "panelBorrar";
            panelBorrar.Size = new Size(582, 296);
            panelBorrar.TabIndex = 7;
            panelBorrar.Visible = false;
            // 
            // lblIdBorrar
            // 
            lblIdBorrar.Location = new Point(10, 20);
            lblIdBorrar.Name = "lblIdBorrar";
            lblIdBorrar.Size = new Size(100, 23);
            lblIdBorrar.TabIndex = 0;
            lblIdBorrar.Text = "ID:";
            // 
            // txtIdBorrar
            // 
            txtIdBorrar.Location = new Point(106, 20);
            txtIdBorrar.Name = "txtIdBorrar";
            txtIdBorrar.Size = new Size(174, 23);
            txtIdBorrar.TabIndex = 1;
            txtIdBorrar.TextChanged += txtIdBorrar_TextChanged;
            // 
            // btnBorrarBorrar
            // 
            btnBorrarBorrar.Location = new Point(80, 60);
            btnBorrarBorrar.Name = "btnBorrarBorrar";
            btnBorrarBorrar.Size = new Size(75, 23);
            btnBorrarBorrar.TabIndex = 2;
            btnBorrarBorrar.Text = "Borrar";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(31, 403);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(560, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // PersonaCrud
            // 
            ClientSize = new Size(667, 437);
            Controls.Add(btnVolver);
            Controls.Add(btnCrear);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(panelCrear);
            Controls.Add(panelBuscar);
            Controls.Add(panelModificar);
            Controls.Add(panelBorrar);
            Name = "PersonaCrud";
            Text = "Persona CRUD Multipanel";
            Load += PersonaCrud_Load;
            panelCrear.ResumeLayout(false);
            panelCrear.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelModificar.ResumeLayout(false);
            panelModificar.PerformLayout();
            panelBorrar.ResumeLayout(false);
            panelBorrar.PerformLayout();
            ResumeLayout(false);
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            panelCrear.Visible = true;
            panelBuscar.Visible = false;
            panelModificar.Visible = false;
            panelBorrar.Visible = false;
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = true;
            panelModificar.Visible = false;
            panelBorrar.Visible = false;
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = false;
            panelModificar.Visible = true;
            panelBorrar.Visible = false;
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            panelCrear.Visible = false;
            panelBuscar.Visible = false;
            panelModificar.Visible = false;
            panelBorrar.Visible = true;
        }
        private Label lblCrearApellido;
        private Button btnVolver;
        private DateTimePicker dateTimePicker1;
        private Label lblCrearFechaNac;
        private Label lblCrearTipoUsuario;
        private RadioButton RadioAlumno;
        private RadioButton RadioProfesor;
        private Label lblCrearTelefono;
        private Label lblCrearEmail;
        private Label lblCrearDireccion;
        private TextBox txtCrearTelefono;
        private TextBox txtCrearEmail;
        private TextBox txtCrearDireccion;
        private TextBox txtCrearApellido;
        private TextBox txtBuscarEmail;
        private TextBox txtBuscarLegajo;
        private TextBox txtBuscarFechaNac;
        private TextBox txtBuscarTipoUsuario;
        private Label lblBuscarEmail;
        private Label lblBuscarLegajo;
        private Label lblBuscarFechaNac;
        private Label lblBuscarTipoUsuario;
        private Label lblBuscarTelefono;
        private Label lblBuscarDireccion;
        private Label lblBuscarNombre;
        private TextBox txtBuscarTelefono;
        private TextBox txtBuscarDireccion;
        private TextBox txtBuscarApellido;
        private TextBox txtBuscarNombre;
        private Label lblBuscarApellido;
        private Label lblModificarApellido;
        private TextBox txtModificarEmail;
        private TextBox txtModificarLegajo;
        private TextBox txtModificarFechaNac;
        private TextBox txtModificarTipoUsuario;
        private Label lblModificarEmail;
        private Label lblModificarLegajo;
        private Label lblModificarFechaNac;
        private Label lblModificarTipoUsuario;
        private Label lblModificarTelefono;
        private Label lblModificarDireccion;
        private Label lblModificarNombre;
        private TextBox txtModificarTelefono;
        private TextBox txtModificarDireccion;
        private TextBox txtModificarApellido;
        private TextBox txtModificarNombre;
        private Button BuscarModificar;
    }
}
