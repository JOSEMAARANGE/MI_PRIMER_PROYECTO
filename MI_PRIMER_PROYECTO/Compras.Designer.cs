namespace MI_PRIMER_PROYECTO
{
    partial class Compras
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
            this.ComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.lblMesdeCorte = new System.Windows.Forms.Label();
            this.TotalesOrdenesComprasbtn = new System.Windows.Forms.Button();
            this.TotalesMaterialesoServiciosbtn = new System.Windows.Forms.Button();
            this.MesDeCortedateTime = new System.Windows.Forms.DateTimePicker();
            this.SalirComprasbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComprasDataGridView
            // 
            this.ComprasDataGridView.AllowUserToAddRows = false;
            this.ComprasDataGridView.AllowUserToDeleteRows = false;
            this.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprasDataGridView.Location = new System.Drawing.Point(545, 99);
            this.ComprasDataGridView.Name = "ComprasDataGridView";
            this.ComprasDataGridView.ReadOnly = true;
            this.ComprasDataGridView.Size = new System.Drawing.Size(486, 350);
            this.ComprasDataGridView.TabIndex = 0;
            // 
            // lblMesdeCorte
            // 
            this.lblMesdeCorte.AutoSize = true;
            this.lblMesdeCorte.Location = new System.Drawing.Point(183, 127);
            this.lblMesdeCorte.Name = "lblMesdeCorte";
            this.lblMesdeCorte.Size = new System.Drawing.Size(70, 13);
            this.lblMesdeCorte.TabIndex = 1;
            this.lblMesdeCorte.Text = "Mes de Corte";
            // 
            // TotalesOrdenesComprasbtn
            // 
            this.TotalesOrdenesComprasbtn.Location = new System.Drawing.Point(186, 220);
            this.TotalesOrdenesComprasbtn.Name = "TotalesOrdenesComprasbtn";
            this.TotalesOrdenesComprasbtn.Size = new System.Drawing.Size(213, 23);
            this.TotalesOrdenesComprasbtn.TabIndex = 2;
            this.TotalesOrdenesComprasbtn.Text = "Totales de las Órdenes de Compras";
            this.TotalesOrdenesComprasbtn.UseVisualStyleBackColor = true;
            this.TotalesOrdenesComprasbtn.Click += new System.EventHandler(this.TotalesOrdenesComprasbtn_Click);
            // 
            // TotalesMaterialesoServiciosbtn
            // 
            this.TotalesMaterialesoServiciosbtn.Location = new System.Drawing.Point(186, 284);
            this.TotalesMaterialesoServiciosbtn.Name = "TotalesMaterialesoServiciosbtn";
            this.TotalesMaterialesoServiciosbtn.Size = new System.Drawing.Size(213, 23);
            this.TotalesMaterialesoServiciosbtn.TabIndex = 3;
            this.TotalesMaterialesoServiciosbtn.Text = "Totales de Materiales o Servicios";
            this.TotalesMaterialesoServiciosbtn.UseVisualStyleBackColor = true;
            this.TotalesMaterialesoServiciosbtn.Click += new System.EventHandler(this.TotalesMaterialesoServiciosbtn_Click);
            // 
            // MesDeCortedateTime
            // 
            this.MesDeCortedateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.MesDeCortedateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MesDeCortedateTime.Location = new System.Drawing.Point(316, 120);
            this.MesDeCortedateTime.Name = "MesDeCortedateTime";
            this.MesDeCortedateTime.Size = new System.Drawing.Size(83, 20);
            this.MesDeCortedateTime.TabIndex = 4;
            this.MesDeCortedateTime.Value = new System.DateTime(2024, 1, 22, 13, 11, 3, 0);
            // 
            // SalirComprasbtn
            // 
            this.SalirComprasbtn.Location = new System.Drawing.Point(920, 469);
            this.SalirComprasbtn.Name = "SalirComprasbtn";
            this.SalirComprasbtn.Size = new System.Drawing.Size(75, 23);
            this.SalirComprasbtn.TabIndex = 5;
            this.SalirComprasbtn.Text = "SALIR";
            this.SalirComprasbtn.UseVisualStyleBackColor = true;
            this.SalirComprasbtn.Click += new System.EventHandler(this.SalirComprasbtn_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 513);
            this.Controls.Add(this.SalirComprasbtn);
            this.Controls.Add(this.MesDeCortedateTime);
            this.Controls.Add(this.TotalesMaterialesoServiciosbtn);
            this.Controls.Add(this.TotalesOrdenesComprasbtn);
            this.Controls.Add(this.lblMesdeCorte);
            this.Controls.Add(this.ComprasDataGridView);
            this.Name = "Compras";
            this.Text = "COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ComprasDataGridView;
        private System.Windows.Forms.Label lblMesdeCorte;
        private System.Windows.Forms.Button TotalesOrdenesComprasbtn;
        private System.Windows.Forms.Button TotalesMaterialesoServiciosbtn;
        private System.Windows.Forms.DateTimePicker MesDeCortedateTime;
        private System.Windows.Forms.Button SalirComprasbtn;
    }
}