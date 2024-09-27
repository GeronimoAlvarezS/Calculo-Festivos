namespace CalculoFeSstivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAño = new Label();
            dgvFechas = new DataGridView();
            nupAño = new NumericUpDown();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFechas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAño).BeginInit();
            SuspendLayout();
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(33, 56);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(143, 18);
            lblAño.TabIndex = 1;
            lblAño.Text = "Seleccione el año:";
            // 
            // dgvFechas
            // 
            dgvFechas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFechas.Location = new Point(41, 153);
            dgvFechas.Name = "dgvFechas";
            dgvFechas.Size = new Size(683, 241);
            dgvFechas.TabIndex = 3;
            // 
            // nupAño
            // 
            nupAño.Location = new Point(182, 56);
            nupAño.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupAño.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            nupAño.Name = "nupAño";
            nupAño.Size = new Size(120, 23);
            nupAño.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(93, 109);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular Fechas";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(nupAño);
            Controls.Add(dgvFechas);
            Controls.Add(lblAño);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFechas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAño;
        private DataGridView dgvFechas;
        private NumericUpDown nupAño;
        private Button btnCalcular;
    }
}
