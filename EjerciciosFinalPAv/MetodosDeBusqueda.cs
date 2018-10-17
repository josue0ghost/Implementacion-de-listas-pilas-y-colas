using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    class MetodosDeBusqueda
    {
        /// <summary>
        /// Cuantas Comparaciones se realizan en la busqueda
        /// </summary>
        public int IteracionesBinaria
        {
            get;
            private set;
        }
        /// <summary>
        /// Cuantas Comparaciones se realiza en la busqueda
        /// </summary>
        public int IteracionesSecuencial
        {
            get;
            private set;
        }

        /// <summary>
        /// Realiza una busqueda de todos los elementos que coincidan con los parametros indicados
        /// </summary>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el cual buscar</param>
        /// <param name="sItem">Elemento Buscado</param>
        /// <returns>Lista de Resultado de Busqueda</returns>
        public List<DataAlumno> BusquedaBinaria(DataAlumno[] DAAlumno, string sCampo, string sItem)
        {
            IteracionesBinaria = 0;
            List<DataAlumno> Coincidencias = new List<DataAlumno>();
            //BusquedaBinaria(ref Coincidencias, DAAlumno, sCampo, sItem);
            BusquedaBinaria(ref Coincidencias, DAAlumno, sCampo, sItem, 0, DAAlumno.Length - 1);
            return Coincidencias;
        }
        /// <summary>
        /// Realiza una busqueda de todos los elementos que coincidan con los parametros indicados
        /// </summary>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el cual buscar</param>
        /// <param name="dItem">Elemento Buscado</param>
        /// <param name="iSubIndice">En el caso de las notas, se elije una de las notas</param>
        /// <returns>Lista de Resultado de Busqueda</returns>
        public List<DataAlumno> BusquedaBinaria(DataAlumno[] DAAlumno, string sCampo, decimal dItem, int iSubIndice)
        {
            IteracionesBinaria = 0;
            List<DataAlumno> Coincidencias = new List<DataAlumno>();
            //BusquedaBinaria(ref Coincidencias, DAAlumno, sCampo, dItem, iSubIndice);
            BusquedaBinaria(ref Coincidencias, DAAlumno, sCampo, dItem, 0, DAAlumno.Length - 1, iSubIndice);
            return Coincidencias;
        }

        /// <summary>
        /// Busca todas las conincidencias con los parametros señalados
        /// </summary>
        /// <param name="lDAResultado">Lista de Coincidencias</param>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el que buscar</param>
        /// <param name="sItem">Elemento Buscado</param>
        /// <param name="iInicio">Indice de Inicio</param>
        /// <param name="iFin">Indice de Fin</param>
        private void BusquedaBinaria(ref List<DataAlumno> lDAResultado, DataAlumno[] DAAlumno, string sCampo, string sItem, int iInicio, int iFin)
        {
            IteracionesBinaria++;
            int iLargo = iFin - iInicio + 1;
            int iPivot = iLargo / 2 + iInicio;
            int iBuscado;
            decimal dBuscado;
            switch (sCampo)
            {
                case "dNotaFinal":
                    dBuscado = decimal.Parse(sItem);
                    if (iLargo != 0)
                    {
                        if (DAAlumno[iPivot].dNotaFinal == dBuscado)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (DAAlumno[iPivot].dNotaFinal > dBuscado)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
                case "iCarne":
                    iBuscado = int.Parse(sItem);
                    if (iLargo != 0)
                    {
                        if (DAAlumno[iPivot].iCarne == iBuscado)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (DAAlumno[iPivot].iCarne > iBuscado)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
                case "sNombre":
                    if (iLargo != 0)
                    {
                        if (string.Compare(DAAlumno[iPivot].sNombre, sItem) == 0)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (string.Compare(DAAlumno[iPivot].sNombre, sItem) > 0)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
                case "sApellido":
                    if (iLargo != 0)
                    {
                        if (string.Compare(DAAlumno[iPivot].sApellido, sItem) == 0)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (string.Compare(DAAlumno[iPivot].sApellido, sItem) > 0)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
                case "sCorreo":
                    if (iLargo != 0)
                    {
                        if (string.Compare(DAAlumno[iPivot].sCorreo, sItem) == 0)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (string.Compare(DAAlumno[iPivot].sCorreo, sItem) > 0)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
                case "sCurso":
                    if (iLargo != 0)
                    {
                        if (string.Compare(DAAlumno[iPivot].sCurso, sItem) == 0)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                        else if (string.Compare(DAAlumno[iPivot].sCurso, sItem) > 0)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iInicio, iPivot - 1);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, sItem, iPivot + 1, iFin);
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// Busca todas las conincidencias con los parametros señalados
        /// </summary>
        /// <param name="lDAResultado">Lista de Coincidencias</param>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el que buscar</param>
        /// <param name="sItem">Elemento Buscado</param>
        /// <param name="iInicio">Indice de Inicio</param>
        /// <param name="iFin">Indice de Fin</param>
        /// <param name="iSubIndice">Indice de Lista</param>
        private void BusquedaBinaria(ref List<DataAlumno> lDAResultado, DataAlumno[] DAAlumno, string sCampo, decimal dItem, int iInicio, int iFin, int iSubIndice)
        {
            IteracionesBinaria++;
            int iLargo = iFin - iInicio + 1;
            int iPivot = iLargo / 2 + iInicio;
            switch (sCampo)
            {
                case "lDNotasProyectos":
                    if (iLargo != 0)
                    {
                        if (DAAlumno[iPivot].lDNotasProyectos[iSubIndice] == dItem)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                        else if (DAAlumno[iPivot].lDNotasProyectos[iSubIndice] > dItem)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                    }
                    break;
                case "lDNotasExamenes":
                    if (iLargo != 0)
                    {
                        if (DAAlumno[iPivot].lDNotasExamenes[iSubIndice] == dItem)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                        else if (DAAlumno[iPivot].lDNotasExamenes[iSubIndice] > dItem)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                    }
                    break;
                case "lDNotasTareas":
                    if (iLargo != 0)
                    {
                        if (DAAlumno[iPivot].lDNotasTareas[iSubIndice] == dItem)
                        {
                            lDAResultado.Add(DAAlumno[iPivot]);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                        else if (DAAlumno[iPivot].lDNotasTareas[iSubIndice] > dItem)
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iInicio, iPivot - 1, iSubIndice);
                        }
                        else
                        {
                            BusquedaBinaria(ref lDAResultado, DAAlumno, sCampo, dItem, iPivot + 1, iFin, iSubIndice);
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Realiza una busqueda de todos los elementos que conicidan con los parametros indicados
        /// </summary>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el cual buscar</param>
        /// <param name="sItem">Elemento Buscado</param>
        /// <returns>Lista de Resultado de Busqueda</returns>
        public List<DataAlumno> BusquedaSecuencial(DataAlumno[] DAAlumno, string sCampo, string sItem)
        {
            IteracionesSecuencial = 0;
            List<DataAlumno> Coincidencias = new List<DataAlumno>();
            int iItem;
            decimal dItem;
            switch (sCampo)
            {
                case "dNotaFinal":
                    dItem = decimal.Parse(sItem);
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].dNotaFinal == dItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "iCarne":
                    iItem = int.Parse(sItem);
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].iCarne == iItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "sNombre":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].sNombre == sItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "sApellido":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].sApellido == sItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "sCorreo":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].sCorreo == sItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "sCurso":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].sCurso == sItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
            }
            return Coincidencias;
        }
        /// <summary>
        /// Realiza una busqueda de todos los elementos que conicidan con los parametros indicados
        /// </summary>
        /// <param name="DAAlumno">Arreglo donde buscar</param>
        /// <param name="sCampo">Campo en el cual buscar</param>
        /// <param name="dItem">Elemento Buscado</param>
        /// <param name="iSubindice">SubIndice de Lista</param>
        /// <returns>Lista de Resultado de Busqueda</returns>
        public List<DataAlumno> BusquedaSecuencial(DataAlumno[] DAAlumno, string sCampo, decimal dItem, int iSubindice)
        {
            IteracionesSecuencial = 0;
            List<DataAlumno> Coincidencias = new List<DataAlumno>();
            switch (sCampo)
            {
                case "lDNotasProyectos":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].lDNotasProyectos[iSubindice] == dItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "lDNotasExamenes":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].lDNotasExamenes[iSubindice] == dItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
                case "lDNotasTareas":
                    for (int i = 0; i < DAAlumno.Length; i++)
                    {
                        IteracionesSecuencial++;
                        if (DAAlumno[i].lDNotasTareas[iSubindice] == dItem)
                        {
                            Coincidencias.Add(DAAlumno[i]);
                        }
                    }
                    break;
            }
            return Coincidencias;
        }

    }
}
