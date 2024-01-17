namespace MI_PRIMER_PROYECTO
{
    partial class Contabilidad
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
            this.ContabilidadDataGridView = new System.Windows.Forms.DataGridView();
            this.SalirContabilidadbtn = new System.Windows.Forms.Button();
            this.CargarContablidadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContabilidadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargarArchivoExcel
            // 
            this.lblCargarArchivoExcel.AutoSize = true;
            this.lblCargarArchivoExcel.Location = new System.Drawing.Point(12, 325);
            this.lblCargarArchivoExcel.Name = "lblCargarArchivoExcel";
            this.lblCargarArchivoExcel.Size = new System.Drawing.Size(161, 13);
            this.lblCargarArchivoExcel.TabIndex = 0;
            this.lblCargarArchivoExcel.Text = "Cargar Archivo Excel del Asiento";
            // 
            // ContabilidadDataGridView
            // 
            this.ContabilidadDataGridView.AllowUserToAddRows = false;
            this.ContabilidadDataGridView.AllowUserToDeleteRows = false;
            this.ContabilidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContabilidadDataGridView.Location = new System.Drawing.Point(208, 43);
            this.ContabilidadDataGridView.Name = "ContabilidadDataGridView";
            this.ContabilidadDataGridView.ReadOnly = true;
            this.ContabilidadDataGridView.Size = new System.Drawing.Size(678, 332);
            this.ContabilidadDataGridView.TabIndex = 1;
            // 
            // SalirContabilidadbtn
            // 
            this.SalirContabilidadbtn.Location = new System.Drawing.Point(792, 444);
            this.SalirContabilidadbtn.Name = "SalirContabilidadbtn";
            this.SalirContabilidadbtn.Size = new System.Drawing.Size(75, 23);
            this.SalirContabilidadbtn.TabIndex = 2;
            this.SalirContabilidadbtn.Text = "SALIR";
            this.SalirContabilidadbtn.UseVisualStyleBackColor = true;
            this.SalirContabilidadbtn.Click += new System.EventHandler(this.SalirComprasbtn_Click);
            // 
            // CargarContablidadbtn
            // 
            this.CargarContablidadbtn.Location = new System.Drawing.Point(50, 352);
            this.CargarContablidadbtn.Name = "CargarContablidadbtn";
            this.CargarContablidadbtn.Size = new System.Drawing.Size(75, 23);
            this.CargarContablidadbtn.TabIndex = 3;
            this.CargarContablidadbtn.Text = "CARGAR";
            this.CargarContablidadbtn.UseVisualStyleBackColor = true;
            this.CargarContablidadbtn.Click += new System.EventHandler(this.CargarContablidadbtn_Click);
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 506);
            this.Controls.Add(this.CargarContablidadbtn);
            this.Controls.Add(this.SalirContabilidadbtn);
            this.Controls.Add(this.ContabilidadDataGridView);
            this.Controls.Add(this.lblCargarArchivoExcel);
            this.Name = "Contabilidad";
            this.Text = "CONTABILIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.ContabilidadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargarArchivoExcel;
        private System.Windows.Forms.DataGridView ContabilidadDataGridView;
        private System.Windows.Forms.Button SalirContabilidadbtn;
        private System.Windows.Forms.Button CargarContablidadbtn;
    }
}