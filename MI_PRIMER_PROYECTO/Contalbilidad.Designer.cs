namespace MI_PRIMER_PROYECTO
{
    partial class Contalbilidad
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
            this.lblCargarArchivoExcel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargarArchivoExcel
            // 
            this.lblCargarArchivoExcel.AutoSize = true;
            this.lblCargarArchivoExcel.Location = new System.Drawing.Point(165, 80);
            this.lblCargarArchivoExcel.Name = "lblCargarArchivoExcel";
            this.lblCargarArchivoExcel.Size = new System.Drawing.Size(106, 13);
            this.lblCargarArchivoExcel.TabIndex = 0;
            this.lblCargarArchivoExcel.Text = "Cargar Archivo Excel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(426, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // Contalbilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCargarArchivoExcel);
            this.Name = "Contalbilidad";
            this.Text = "CONTABILIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargarArchivoExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}