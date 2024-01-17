using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace MI_PRIMER_PROYECTO
{
    public partial class Contabilidad : Form
    {
        public Contabilidad()
        {
            InitializeComponent();
        }

        private void SalirComprasbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarContablidadbtn_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument(@"C:\Users\jarange\Desktop\Contabilidad.xlsx");
            SLWorksheetStatistics stats = sl.GetWorksheetStatistics();

            DataTable dt = new DataTable();
            for (int i = 1; i <= stats.EndColumnIndex; ++i)
            {
                dt.Columns.Add(new DataColumn());
            }

            for (int i = 1; i <= stats.EndRowIndex; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 1; j <= stats.EndColumnIndex; ++j)
                {
                    dr[j - 1] = sl.GetCellValueAsString(i, j);
                }
                dt.Rows.Add(dr);
            }


            if (dialogResult == DialogResult.Yes)

            {
                MessageBox.Show("Formato del excel correcto, se cargo el asiento");
                ContabilidadDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("El formato es incorrecto o faltan datos obligatorios");
            }

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }
    }
}
