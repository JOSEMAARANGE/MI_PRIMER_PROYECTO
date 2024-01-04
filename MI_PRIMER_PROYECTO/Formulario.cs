using LOGICA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static LOGICA.Estudiante;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MI_PRIMER_PROYECTO
{

    public partial class Formulario : Form
    {


        Estudiante _estudiante;

        EstudianteList _estudianteList;
       
       


        public Formulario()
        {
            InitializeComponent();
            _estudianteList = new EstudianteList();

            EstudianteBindingSource.DataSource = _estudianteList;
            MateriaCursadaTextBox.ReadOnly = true;
            //Cuando el programa inicia, dejamos listo para cargar un nuevo estudiante
            Nuevoestudiante();
        }


        public void Nuevoestudiante()
        {

            //creamos el nuevo estudiante
            _estudiante = new Estudiante();

            _estudiante.EstudianteId = _estudianteList.Count() + 1;

            //enlazamos los controles
            estudianteEnEdicionBindingSource.DataSource = _estudiante;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void Form1_Load(object sender, EventArgs e)
        {

            DniTextbox.Focus();
            ModificarBotton.Enabled = false;
            Nuevoestudiante();
        }

        public void DniTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Comparas si la tecla presionada corresponde a una numero
            {
                e.Handled = true;
            }

        }

        public void NombreTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar))  //Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }
        }

        public void ApellidoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar))  //Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }
        }

        public void TelefonoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsSymbol(e.KeyChar)) //Comparas si la tecla presionada corresponde a un simbolo
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar)) //Comparas si la tecla presionada corresponde a una numero
            {
                e.Handled = true;
            }
        }


        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            _estudiante = new Estudiante();
            estudianteEnEdicionBindingSource.EndEdit();
            

            var encontrado = _estudianteList.Where(estudiante => estudiante.EstudianteId == _estudiante.EstudianteId).ToList()[0];

            if (encontrado != null)
            {
                EstudianteBindingSource.DataSource = encontrado;
            }

            Nuevoestudiante();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea cancelar las modificaciones?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Nuevoestudiante();

            }
            else if (dialogResult == DialogResult.No)
            {

                return;

            }

        }

        private void AgregarBotton_Click(object sender, EventArgs e)
        {
            estudianteEnEdicionBindingSource.EndEdit();
            // Verificar la acción a realizar
            if (MateriasComboBox.Text == "MATEMATICA II")
            {
                DialogResult dialogResult = MessageBox.Show("Aprobo MATEMATICAS I?", "Necesitas matematicas I", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)

                {
                    MessageBox.Show("Registrado");
                }
                else
                {
                    MessageBox.Show("Debe tener MATEMATICAS I aprobada");
                }

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }


            //Antes de agregar, validamos el estudiante para que todo este bien.
            try
            {
                _estudiante.Validar();

            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.Message);

                return;
            }
            if (AprobadoComboBox.Text == "SI")
            {
                MateriaCursadaTextBox.Text = MateriasComboBox.Text;
                MateriasComboBox.Text = null;

                MessageBox.Show("Coloco materia aprobada, queda en Materia Cursada");
            }
            else
            {
                MessageBox.Show("Materia no aprobada, queda en Materia actual");
            }
              Correlativa();
            //Se valido correctamente, por lo que agregamos el estudiante a la "grilla" 
            EstudianteBindingSource.Add(_estudiante);
            //Dejamos todo listo para agregar otro estudiante mas
            Nuevoestudiante();
        }

        public void Correlativa()

        {
            int m = 0;
            int n = estudianteGridView.Rows.Count - 1;
            int k;
            string estaFila, unaFila;

            while (m < n)
            {
                k = 1;
                estaFila = String.Empty;

                // Relleno la cadena con los datos de toda la fila
                for (int i = 0; i < estudianteGridView.Columns.Count; i++)
                    estaFila = String.Concat(estaFila, estudianteGridView.Rows[m].Cells[i].Value.ToString());

                while (k < n)
                {
                    unaFila = String.Empty;
                    for (int i = 0; i < estudianteGridView.Columns.Count; i++)
                        unaFila =
                   String.Concat(unaFila, estudianteGridView.Rows[k].Cells[i].Value.ToString());

                    if (String.Compare(estaFila, unaFila) == 0 && k != m)
                    {
                        MessageBox.Show("ALUMNO YA MATRICULADO");
                        n--;
                    }
                    k++;
                }
                m++;
            }


        }


        private void estudianteGridView_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Se procedera a cargar los campos para su modificacion ?", "Confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                //creamos el nuevo estudiante
                var estudianteEnGrilla = (Estudiante)EstudianteBindingSource.Current;

                _estudiante = (Estudiante)((ICloneable)EstudianteBindingSource.Current).Clone();

                //enlazamos los controles
                estudianteEnEdicionBindingSource.DataSource = _estudiante;


                ModificarBotton.Enabled = true;

            }

        }
    }
   
}
         
