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
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static LOGICA.Estudiante;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LOGICA
{

    public class Estudiante
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string MateriaActual { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeInscripcion { get; set; }
        public string MateriaCursada { get; set; }
        public string MateriaAprobada { get; private set; }

        public int Edad()
        {

            // Obtengo la diferencia en años.

            int edad = DateTime.Today.Year - FechaDeNacimiento.Year;

            // Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = FechaDeNacimiento.AddYears(edad);

            // Le resto un año si la fecha actual es anterior al día de nacimiento.
            if (DateTime.Today.CompareTo(nacimientoAhora) < 0)
            {
                edad--;
            }

            return edad;
        }


        public void Validar()

        {

            if (string.IsNullOrEmpty(Dni) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) || string.IsNullOrEmpty(Telefono) || string.IsNullOrEmpty(MateriaActual))
            {
                throw new Exception("Debe llenar todos los campos");
            }


            if (Edad() < 21)
            {
                throw new Exception("Es menor a 21 años, imposible continuar");
            }
        }

        public static implicit operator Estudiante(BindingSource v)
        {
            throw new NotImplementedException();
        }

        public class EstudianteList : List<Estudiante>
        {
            public int CantidadPorMateria(string materia)
            {
                return 0;
            }


        }

    }
}

   




    

    

      

