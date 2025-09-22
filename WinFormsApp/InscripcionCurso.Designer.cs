namespace WinFormsApp
{
    partial class InscripcionCurso
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
            Comision = new DataGridViewTextBoxColumn();
            HoraDesde = new DataGridViewTextBoxColumn();
            HoraHasta = new DataGridViewTextBoxColumn();
            confirmar = new Button();
            Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Comision, HoraDesde, HoraHasta });
            dataGridView1.Location = new Point(196, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 183);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Comision
            // 
            Comision.HeaderText = "comision";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // HoraDesde
            // 
            HoraDesde.HeaderText = "HoraDesde";
            HoraDesde.Name = "HoraDesde";
            HoraDesde.ReadOnly = true;
            // 
            // HoraHasta
            // 
            HoraHasta.HeaderText = "HoraHasta";
            HoraHasta.Name = "HoraHasta";
            HoraHasta.ReadOnly = true;
            // 
            // confirmar
            // 
            confirmar.Location = new Point(620, 353);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(91, 45);
            confirmar.TabIndex = 1;
            confirmar.Text = "confirmar";
            confirmar.UseVisualStyleBackColor = true;
            confirmar.Click += this.confirmar_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(87, 353);
            Volver.Name = "Volver";
            Volver.Size = new Size(98, 45);
            Volver.TabIndex = 2;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += this.Volver_Click;
            // 
            // InscripcionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(confirmar);
            Controls.Add(dataGridView1);
            Name = "InscripcionCurso";
            Text = "InscripcionCurso";
            Load += InscripcionMateria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comision;
        private DataGridViewTextBoxColumn HoraDesde;
        private DataGridViewTextBoxColumn HoraHasta;
        private Button confirmar;
        private Button Volver;
    }
}