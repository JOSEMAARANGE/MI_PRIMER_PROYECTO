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

    public class Estudiante : ICloneable
    {
        public int EstudianteId { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string MateriaActual { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeInscripcion { get; set; }
        public string MateriaCursada { get; set; }
        public class Materia
        {
            public string Descripcion { get; set; }
            public List<Materia> Correlativas { get; set; }
       }

        public class Validador
        {
            public bool InscripcionUnica(List<Materia> materias, Materia nuevaMateria)
            {
                return !materias.Any(m => m.Descripcion == nuevaMateria.Descripcion);
            }

            public bool EsCoherenteCorrelativas(Materia materia)
            {
                // Asegura que ninguna de las correlativas de la materia es la misma materia
                return !materia.Correlativas.Any(c => c.Descripcion == materia.Descripcion);
            }
        }
          public class Programa
          {
            static void Main(string[] args)
            {
                // Crear una lista de materias
                List<Materia> materias = new List<Materia>();

                // Crear una nueva materia
                Materia nuevaMateria = new Materia
                {
                    Descripcion = "MATEMATICAS II",
                    Correlativas = new List<Materia>()
                };

                // Crear un validador
                Validador validador = new Validador();

                // Verificar si la inscripción de la materia es única
                if (!validador.InscripcionUnica(materias, nuevaMateria))
                {
                    throw new Exception("La inscripción de la materia no es única.");
                }

                // Verificar si las correlativas de la materia son coherentes
                if (!validador.EsCoherenteCorrelativas(nuevaMateria))
                {
                    throw new Exception("Las correlativas de la materia no son coherentes.");
                }
            }
        }
        public object Clone()
        {
            var clon = new Estudiante
            {
                EstudianteId = EstudianteId,
                Dni = Dni,
                Nombre = Nombre,
                Apellido = Apellido,
                Telefono = Telefono,
                MateriaActual = MateriaActual,
                FechaDeNacimiento = FechaDeNacimiento,
                FechaDeInscripcion = FechaDeInscripcion,
                MateriaCursada = MateriaCursada,
               
            };

            return clon;
        }

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



            if (MateriaCursada == "MATEMATICAS II")
            {

                throw new Exception("Debe tener aprobada MATEMATICAS I");
            }
            

        }


        public class EstudianteList : List<Estudiante>
        {
           

        }


    }
 }

 


   




    

    

      

