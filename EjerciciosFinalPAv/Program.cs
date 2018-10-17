using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFinalPAv
{
    public class DataAlumno
    {
        /// <summary>
        /// Nombre del Alumno
        /// </summary>
        public string sNombre
        {
            get; set;
        }

        /// <summary>
        /// Apellido del Alumno
        /// </summary>
        public string sApellido
        {
            get; set;
        }

        /// <summary>
        /// Numero de Carnet
        /// </summary>
        public int iCarne
        {
            get; set;
        }

        /// <summary>
        /// Dirección de Correo Electronico
        /// </summary>
        public string sCorreo
        {
            get; set;
        }

        /// <summary>
        /// Nombre de Curso
        /// </summary>
        public string sCurso
        {
            get; set;
        }

        /// <summary>
        /// Listado de Notas de Tareas
        /// </summary>
        public List<decimal> lDNotasTareas
        {
            get; set;
        }

        /// <summary>
        /// Listado de Notas de Proyectos
        /// </summary>
        public List<decimal> lDNotasProyectos
        {
            get; set;
        }

        /// <summary>
        /// Listado de Nodas de Examenes
        /// </summary>
        public List<decimal> lDNotasExamenes
        {
            get; set;
        }

        /// <summary>
        /// Nota Final Del Estuidiante
        /// </summary>
        public decimal dNotaFinal
        {
            get; set;
        }

        /// <summary>
        /// Generar la linea del registro lista para el csv
        /// </summary>
        /// <returns>Linea Separada por comas</returns>
        public string LineaRegistro()
        {
            /*
             * Los items del registro esta separados por 
             * punto y coma (;) y no por coma (,) porque 
             * Excel reconoce el punto y coma como separador
             * de celdas de una fila
            */
            string slinea = "";
            slinea += sNombre;
            slinea += ";";
            slinea += sApellido;
            slinea += ";";
            slinea += iCarne;
            slinea += ";";
            slinea += sCorreo;
            slinea += ";";
            slinea += sCurso;
            slinea += ";";
            foreach (decimal nota in lDNotasTareas)
            {
                slinea += nota.ToString();
                slinea += ";";
            }
            foreach (decimal nota in lDNotasProyectos)
            {
                slinea += nota.ToString();
                slinea += ";";
            }
            foreach (decimal nota in lDNotasExamenes)
            {
                slinea += nota.ToString();
                slinea += ";";
            }
            slinea += dNotaFinal;
            return slinea;
        }

        /// <summary>
        /// Ingresa una nueva fila a una tabla de datos
        /// </summary>
        /// <param name="dtTabla">Tabla de Datos</param>
        public void FilaTabla(ref DataTable dtTabla)
        {
            DataRow drFila;
            drFila = dtTabla.NewRow();
            string[] datos = LineaRegistro().Split(';');
            for (int i = 0; i < datos.Length; i++)
            {
                drFila[i] = datos[i];
            }
            dtTabla.Rows.Add(drFila);
        }

        public DataAlumno()
        {
            sNombre = null;
            sApellido = null;
            iCarne = 0;
            sCorreo = null;
            sCurso = null;
            lDNotasTareas = new List<decimal>();
            lDNotasProyectos = new List<decimal>();
            lDNotasExamenes = new List<decimal>();

        }

    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ejercicio1());
        }
    }
}
