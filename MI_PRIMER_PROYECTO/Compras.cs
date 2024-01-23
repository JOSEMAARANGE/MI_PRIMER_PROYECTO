using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_PRIMER_PROYECTO
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            ComprasDataGridView.Columns.Add("Columna1", "Órdenes de Compras");
            ComprasDataGridView.Columns.Add("Columna2", "Materiales o Servicios");
            ComprasDataGridView.Columns.Add("Columna2", "Fecha");


            // Crear un nuevo objeto de fila
            DataGridViewRow row = new DataGridViewRow();

            // Agregar celdas a la fila
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "Orden N° 1" });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "Postes" });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "23/09/2023" });

            // Agregar la fila al DataGridView
            ComprasDataGridView.Rows.Add(row);
        }

        private void SalirComprasbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}
