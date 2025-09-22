namespace WinFormsApp
{
    partial class InscripcionMaterias
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

            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            confirmar = new Button();
            volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {  Column1, Column4, Column2, Column3, Column5 });
            dataGridView1.Location = new Point(34, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(754, 122);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "id:";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Plan:";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre:";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "año:";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Horas semanales:";
            Column5.Name = "Column5";
            // 
            // confirmar
            // 
            confirmar.Location = new Point(569, 339);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(153, 40);
            confirmar.TabIndex = 1;
            confirmar.Text = "confirmar";
            confirmar.UseVisualStyleBackColor = true;
            confirmar.Click += confirmar_Click;
            // 
            // volver
            // 
            volver.Location = new Point(111, 339);
            volver.Name = "volver";
            volver.Size = new Size(137, 40);
            volver.TabIndex = 2;
            volver.Text = "volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // InscripcionMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volver);
            Controls.Add(confirmar);
            Controls.Add(dataGridView1);
            Name = "InscripcionMaterias";
            Text = "InscripcionMaterias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private Button confirmar;
        private Button volver;
    }
}