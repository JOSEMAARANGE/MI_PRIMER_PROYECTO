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
            this.ConfirmarAsientoContabilidadbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GuardarCambiosbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContabilidadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCargarArchivoExcel
            // 
            this.lblCargarArchivoExcel.AutoSize = true;
            this.lblCargarArchivoExcel.Location = new System.Drawing.Point(12, 176);
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
            this.CargarContablidadbtn.Location = new System.Drawing.Point(44, 206);
            this.CargarContablidadbtn.Name = "CargarContablidadbtn";
            this.CargarContablidadbtn.Size = new System.Drawing.Size(75, 23);
            this.CargarContablidadbtn.TabIndex = 3;
            this.CargarContablidadbtn.Text = "CARGAR";
            this.CargarContablidadbtn.UseVisualStyleBackColor = true;
            this.CargarContablidadbtn.Click += new System.EventHandler(this.CargarContablidadbtn_Click);
            // 
            // ConfirmarAsientoContabilidadbtn
            // 
            this.ConfirmarAsientoContabilidadbtn.Location = new System.Drawing.Point(208, 398);
            this.ConfirmarAsientoContabilidadbtn.Name = "ConfirmarAsientoContabilidadbtn";
            this.ConfirmarAsientoContabilidadbtn.Size = new System.Drawing.Size(127, 23);
            this.ConfirmarAsientoContabilidadbtn.TabIndex = 4;
            this.ConfirmarAsientoContabilidadbtn.Text = "Confirmar Asiento";
            this.ConfirmarAsientoContabilidadbtn.UseVisualStyleBackColor = true;
            this.ConfirmarAsientoContabilidadbtn.Click += new System.EventHandler(this.ConfirmarAsientoContabilidadbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MI_PRIMER_PROYECTO.Properties.Resources.Excel;
            this.pictureBox1.Location = new System.Drawing.Point(33, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GuardarCambiosbtn
            // 
            this.GuardarCambiosbtn.Location = new System.Drawing.Point(362, 398);
            this.GuardarCambiosbtn.Name = "GuardarCambiosbtn";
            this.GuardarCambiosbtn.Size = new System.Drawing.Size(124, 23);
            this.GuardarCambiosbtn.TabIndex = 6;
            this.GuardarCambiosbtn.Text = "Guardar Cambios";
            this.GuardarCambiosbtn.UseVisualStyleBackColor = true;
            this.GuardarCambiosbtn.Click += new System.EventHandler(this.GuardarCambiosbtn_Click);
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 506);
            this.Controls.Add(this.GuardarCambiosbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConfirmarAsientoContabilidadbtn);
            this.Controls.Add(this.CargarContablidadbtn);
            this.Controls.Add(this.SalirContabilidadbtn);
            this.Controls.Add(this.ContabilidadDataGridView);
            this.Controls.Add(this.lblCargarArchivoExcel);
            this.Name = "Contabilidad";
            this.Text = "CONTABILIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.ContabilidadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargarArchivoExcel;
        private System.Windows.Forms.DataGridView ContabilidadDataGridView;
        private System.Windows.Forms.Button SalirContabilidadbtn;
        private System.Windows.Forms.Button CargarContablidadbtn;
        private System.Windows.Forms.Button ConfirmarAsientoContabilidadbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GuardarCambiosbtn;
    }
}