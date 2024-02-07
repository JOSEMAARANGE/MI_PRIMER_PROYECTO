using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection.Metadata;
using System.Xml.Linq;
using PageSize = iTextSharp.text.PageSize;


namespace MI_PRIMER_PROYECTO
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            ComprasDataGridView.Columns.Add("Columna1", "Ordenes de Compras");
            ComprasDataGridView.Columns.Add("Columna2", "Materiales o Servicios");
            ComprasDataGridView.Columns.Add("Columna3", "Fecha");


            // Crear un nuevo objeto de fila
            DataGridViewRow row = new DataGridViewRow();

            // Agregar celdas a la fila
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "Orden N° 1" });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "Postes" }) ;
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "23/09/2023" });
            

            // Agregar la fila al DataGridView
            ComprasDataGridView.Rows.Add(row);
        }

        private void SalirComprasbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalesOrdenesComprasbtn_Click(object sender, EventArgs e)
        {
            // Crear un nuevo documento PDF
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            // Crear un nuevo escritor PDF en el archivo especificado
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\jarange\Desktop\Totales de las ordenes de Compras.pdf", FileMode.Create));

            // Abrir el documento para escribir
            doc.Open();

            // Crear una nueva tabla PDF con el número de columnas del DataGridView
            PdfPTable pdfTable = new PdfPTable(1);

            // Agregar las celdas de la columna especificada al PDF
            foreach (DataGridViewRow row in ComprasDataGridView.Rows)
            {
                if (row.Cells["Columna1"].Value != null)
                {
                    pdfTable.AddCell(new Phrase(row.Cells["Columna1"].Value.ToString()));
                    pdfTable.AddCell(new Phrase(row.Cells["Columna3"].Value.ToString()));

                }
            }

            // Agregar la tabla al documento
            doc.Add(pdfTable);

            // Cerrar el documento
            doc.Close();
        }

        private void TotalesMaterialesoServiciosbtn_Click(object sender, EventArgs e)
        { // Crear un nuevo documento PDF
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            // Crear un nuevo escritor PDF en el archivo especificado
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\jarange\Desktop\Totales de Materiales o Servicios.pdf", FileMode.Create));

            // Abrir el documento para escribir
            doc.Open();

            // Crear una nueva tabla PDF con el número de columnas del DataGridView
            PdfPTable pdfTable = new PdfPTable(1);

            // Agregar las celdas de la columna especificada al PDF
            foreach (DataGridViewRow row in ComprasDataGridView.Rows)
            {
                if (row.Cells["Columna2"].Value != null)
                {
                    pdfTable.AddCell(new Phrase(row.Cells["Columna2"].Value.ToString()));
                    pdfTable.AddCell(new Phrase(row.Cells["Columna3"].Value.ToString()));
                }
            }

            // Agregar la tabla al documento
            doc.Add(pdfTable);

            // Cerrar el documento
            doc.Close();

        }

    }

}
