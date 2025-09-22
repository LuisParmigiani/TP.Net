namespace WinFormsApp
{
    partial class InscripcionExamenes
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Plan = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Inscribirse = new DataGridViewButtonColumn();
            Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Materia, Fecha, Plan, Año, Inscribirse });
            dataGridView1.Location = new Point(60, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(702, 201);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Plan
            // 
            Plan.HeaderText = "Plan";
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            // 
            // Año
            // 
            Año.HeaderText = "Año";
            Año.Name = "Año";
            Año.ReadOnly = true;
            // 
            // Inscribirse
            // 
            Inscribirse.HeaderText = "Acción";
            Inscribirse.Name = "Inscribirse";
            Inscribirse.Text = "Inscribirse";
            Inscribirse.UseColumnTextForButtonValue = true;
            // 
            // Volver
            // 
            Volver.Location = new Point(60, 350);
            Volver.Name = "Volver";
            Volver.Size = new Size(702, 31);
            Volver.TabIndex = 1;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // InscripcionExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(dataGridView1);
            Name = "InscripcionExamenes";
            Text = "InscripcionExamenes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewButtonColumn Inscribirse;
        private Button Volver;
    }
}