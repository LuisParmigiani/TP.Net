namespace WinFormsApp
{
    partial class EstadoAcademico
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
            Nombre = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            Plan = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Ano, Plan, Estado });
            dataGridView1.Location = new Point(33, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Ano
            // 
            Ano.HeaderText = "Año";
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            // 
            // Plan
            // 
            Plan.HeaderText = "Plan";
            Plan.Name = "Plan";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Volver
            // 
            Volver.Location = new Point(59, 382);
            Volver.Name = "Volver";
            Volver.Size = new Size(653, 31);
            Volver.TabIndex = 1;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // EstadoAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(dataGridView1);
            Name = "EstadoAcademico";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn Estado;
        private Button Volver;
    }
}