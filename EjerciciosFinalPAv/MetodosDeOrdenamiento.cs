using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    class MetodosDeOrdenamiento
    {
        int IntercambiosShell
        {
            get;
            set;
        }
        int IntercambiosSeleccion
        {
            get;
            set;
        }
        /// <summary>
        /// Cuenta cuantos intercambios se realizan en el QuickSort
        /// </summary>
        public int IntercambiosQuick
        {
            get;
            private set;
        }
        int IntercambiosStupid
        {
            get;
            set;
        }

        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        public void OrdenamientoShell(DataAlumno[] daAlumno, bool bAD, string sCampo)
        {
            int iSalto = 0;
            int iIntercambio = 0;

            DataAlumno daAuxiliar = null;

            int i = 0;
            iSalto = daAlumno.Length / 2;

            switch (sCampo)
            {
                case "sNombre":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (String.Compare(daAlumno[i - 1].sNombre, daAlumno[(i - 1) + iSalto].sNombre) > 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (String.Compare(daAlumno[i - 1].sNombre, daAlumno[(i - 1) + iSalto].sNombre) < 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "sApellido":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (String.Compare(daAlumno[i - 1].sApellido, daAlumno[(i - 1) + iSalto].sApellido) > 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (String.Compare(daAlumno[i - 1].sApellido, daAlumno[(i - 1) + iSalto].sApellido) < 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "sCorreo":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (String.Compare(daAlumno[i - 1].sCorreo, daAlumno[(i - 1) + iSalto].sCorreo) > 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (String.Compare(daAlumno[i - 1].sCorreo, daAlumno[(i - 1) + iSalto].sCorreo) < 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "iCarne":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (daAlumno[i - 1].iCarne > daAlumno[(i - 1) + iSalto].iCarne)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (daAlumno[i - 1].iCarne < daAlumno[(i - 1) + iSalto].iCarne)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "sCurso":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (String.Compare(daAlumno[i - 1].sCurso, daAlumno[(i - 1) + iSalto].sCurso) > 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (String.Compare(daAlumno[i - 1].sCurso, daAlumno[(i - 1) + iSalto].sCurso) < 0)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "dNotaFinal":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (daAlumno[i - 1].dNotaFinal > daAlumno[(i - 1) + iSalto].dNotaFinal)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (daAlumno[i - 1].dNotaFinal < daAlumno[(i - 1) + iSalto].dNotaFinal)
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;
            }
        }
        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="iSubIndice">SubIndice de Lista</param>
        public void OrdenamientoShell(DataAlumno[] daAlumno, bool bAD, string sCampo, int iSubIndice)
        {
            int iSalto = 0;
            int iIntercambio = 0;

            DataAlumno daAuxiliar = null;

            int i = 0;
            iSalto = daAlumno.Length / 2;

            switch (sCampo)
            {
                case "lDNotasTareas":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (daAlumno[i - 1].lDNotasTareas[iSubIndice] > daAlumno[(i - 1) + iSalto].lDNotasTareas[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (daAlumno[i - 1].lDNotasTareas[iSubIndice] < daAlumno[(i - 1) + iSalto].lDNotasTareas[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "lDNotasProyectos":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (daAlumno[i - 1].lDNotasProyectos[iSubIndice] > daAlumno[(i - 1) + iSalto].lDNotasProyectos[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (daAlumno[i - 1].lDNotasProyectos[iSubIndice] < daAlumno[(i - 1) + iSalto].lDNotasProyectos[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;

                case "lDNotasExamenes":
                    while (iSalto > 0)
                    {
                        iIntercambio = 1;
                        while (iIntercambio != 0)
                        {
                            iIntercambio = 0;
                            i = 1;
                            while (i <= (daAlumno.Length - iSalto))
                            {
                                if (bAD)
                                {
                                    if (daAlumno[i - 1].lDNotasExamenes[iSubIndice] > daAlumno[(i - 1) + iSalto].lDNotasExamenes[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                                else
                                {
                                    if (daAlumno[i - 1].lDNotasExamenes[iSubIndice] < daAlumno[(i - 1) + iSalto].lDNotasExamenes[iSubIndice])
                                    {
                                        daAuxiliar = daAlumno[(i - 1) + iSalto];
                                        daAlumno[(i - 1) + iSalto] = daAlumno[i - 1];
                                        daAlumno[(i - 1)] = daAuxiliar;
                                        iIntercambio = 1;
                                    }
                                    i++;
                                }
                            }
                        }
                        iSalto = iSalto / 2;
                    }
                    break;
            }
        }

        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        public void OrdenamientoSeleccion(DataAlumno[] daAlumno, bool bAD, string sCampo)
        {
            int iMinimo;

            DataAlumno daAuxiliar = null;

            switch (sCampo)
            {
                case "sNombre":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (String.Compare(daAlumno[j].sNombre, daAlumno[iMinimo].sNombre) < 0)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (String.Compare(daAlumno[j].sNombre, daAlumno[iMinimo].sNombre) > 0)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "sApellido":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (String.Compare(daAlumno[j].sApellido, daAlumno[iMinimo].sApellido) < 0)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (String.Compare(daAlumno[j].sApellido, daAlumno[iMinimo].sApellido) > 0)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "sCorreo":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (String.Compare(daAlumno[j].sCorreo, daAlumno[iMinimo].sCorreo) < 0)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (String.Compare(daAlumno[j].sCorreo, daAlumno[iMinimo].sCorreo) > 0)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "sCurso":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (String.Compare(daAlumno[j].sCurso, daAlumno[iMinimo].sCurso) < 0)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (String.Compare(daAlumno[j].sCurso, daAlumno[iMinimo].sCurso) > 0)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "iCarne":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (daAlumno[j].iCarne < daAlumno[iMinimo].iCarne)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (daAlumno[j].iCarne > daAlumno[iMinimo].iCarne)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "dNotaFinal":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (daAlumno[j].dNotaFinal < daAlumno[iMinimo].dNotaFinal)
                                    iMinimo = j;
                            }
                            else
                            {
                                if (daAlumno[j].dNotaFinal > daAlumno[iMinimo].dNotaFinal)
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;
            }


        }
        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="iSubIndice">SubIndice de Lista</param>
        public void OrdenamientoSeleccion(DataAlumno[] daAlumno, bool bAD, string sCampo, int iSubIndice)
        {
            int iMinimo;
            DataAlumno daAuxiliar = null;

            switch (sCampo)
            {
                case "lDNotasTareas":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (daAlumno[j].lDNotasTareas[iSubIndice] < daAlumno[iMinimo].lDNotasTareas[iSubIndice])
                                    iMinimo = j;
                            }
                            else
                            {
                                if (daAlumno[j].lDNotasTareas[iSubIndice] > daAlumno[iMinimo].lDNotasTareas[iSubIndice])
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "lDNotasProyectos":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (daAlumno[j].lDNotasProyectos[iSubIndice] < daAlumno[iMinimo].lDNotasProyectos[iSubIndice])
                                    iMinimo = j;
                            }
                            else
                            {
                                if (daAlumno[j].lDNotasProyectos[iSubIndice] > daAlumno[iMinimo].lDNotasProyectos[iSubIndice])
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;

                case "lDNotasExamenes":
                    for (int i = 0; i < daAlumno.Length; i++)
                    {
                        iMinimo = i;
                        for (int j = i + 1; j < daAlumno.Length; j++)
                        {
                            if (bAD)
                            {
                                if (daAlumno[j].lDNotasExamenes[iSubIndice] < daAlumno[iMinimo].lDNotasExamenes[iSubIndice])
                                    iMinimo = j;
                            }
                            else
                            {
                                if (daAlumno[j].lDNotasExamenes[iSubIndice] > daAlumno[iMinimo].lDNotasExamenes[iSubIndice])
                                    iMinimo = j;
                            }
                        }
                        daAuxiliar = daAlumno[iMinimo];
                        daAlumno[iMinimo] = daAlumno[i];
                        daAlumno[i] = daAuxiliar;
                    }
                    break;
            }
        }

        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        public void Quicksort(DataAlumno[] daAlumno, bool bAD, string sCampo)
        {
            QuickSort(daAlumno, 0, daAlumno.Length - 1, bAD, sCampo);
        }
        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="iSubIndice">SubIndice de Lista</param>
        public void Quicksort(DataAlumno[] daAlumno, bool bAD, string sCampo, int iSubIndice)
        {
            QuickSort(daAlumno, 0, daAlumno.Length - 1, bAD, sCampo, iSubIndice);
        }

        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="inicio">Inidice de Inicio</param>
        /// <param name="fin">Largo del Vector</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        private void QuickSort(DataAlumno[] daAlumno, int inicio, int fin, bool bAD, string sCampo)
        {
            IntercambiosQuick = 0;
            int i = inicio;
            int j = fin;
            int iCentral = (inicio + fin) / 2;

            DataAlumno daAuxiliar = null;

            string sPivoteNombre = daAlumno[iCentral].sNombre;
            string sPivoteApellido = daAlumno[iCentral].sApellido;
            string sPivoteCorreo = daAlumno[iCentral].sCorreo;
            string sPivoteCurso = daAlumno[iCentral].sCurso;
            int iPivoteCarne = daAlumno[iCentral].iCarne;
            decimal iPivoteNotaFinal = daAlumno[iCentral].dNotaFinal;

            switch (sCampo)
            {
                case "sNombre":
                    if (bAD)
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sNombre, sPivoteNombre) < 0) i++;
                            while (String.Compare(daAlumno[j].sNombre, sPivoteNombre) > 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sNombre, sPivoteNombre) > 0) i++;
                            while (String.Compare(daAlumno[j].sNombre, sPivoteNombre) < 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;

                case "sCurso":
                    if (bAD)
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sCurso, sPivoteCurso) < 0) i++;
                            while (String.Compare(daAlumno[j].sCurso, sPivoteCurso) > 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sCurso, sPivoteCurso) > 0) i++;
                            while (String.Compare(daAlumno[j].sCurso, sPivoteCurso) < 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;

                case "sApellido":
                    if (bAD)
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sApellido, sPivoteApellido) < 0) i++;
                            while (String.Compare(daAlumno[j].sApellido, sPivoteApellido) > 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sApellido, sPivoteApellido) > 0) i++;
                            while (String.Compare(daAlumno[j].sApellido, sPivoteApellido) < 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;

                case "sCorreo":
                    if (bAD)
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sCorreo, sPivoteCorreo) < 0) i++;
                            while (String.Compare(daAlumno[j].sCorreo, sPivoteCorreo) > 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (String.Compare(daAlumno[i].sCorreo, sPivoteCorreo) > 0) i++;
                            while (String.Compare(daAlumno[j].sCorreo, sPivoteCorreo) < 0) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;

                case "iCarne":
                    if (bAD)
                    {
                        do
                        {
                            while (daAlumno[i].iCarne < iPivoteCarne) i++;
                            while (daAlumno[j].iCarne > iPivoteCarne) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (daAlumno[i].iCarne > iPivoteCarne) i++;
                            while (daAlumno[j].iCarne < iPivoteCarne) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;

                case "dNotaFinal":
                    if (bAD)
                    {
                        do
                        {
                            while (daAlumno[i].dNotaFinal < iPivoteNotaFinal) i++;
                            while (daAlumno[j].dNotaFinal > iPivoteNotaFinal) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        do
                        {
                            while (daAlumno[i].dNotaFinal > iPivoteNotaFinal) i++;
                            while (daAlumno[j].dNotaFinal < iPivoteNotaFinal) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo);

                    break;
            }


        }
        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="inicio">Inidice de Inicio</param>
        /// <param name="fin">Largo del Vector</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="iSubIndice">SubIndice de Lista</param>
        private void QuickSort(DataAlumno[] daAlumno, int inicio, int fin, bool bAD, string sCampo, int iSubIndice)
        {
            IntercambiosQuick = 0;
            int i = inicio;
            int j = fin;
            int iCentral = (inicio + fin) / 2;

            DataAlumno daAuxiliar = null;
            switch (sCampo)
            {
                case "lDNotasTareas":
                    if (bAD)
                    {
                        decimal dPivoteNotasTareas = daAlumno[iCentral].lDNotasTareas[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasTareas[iSubIndice] < dPivoteNotasTareas) i++;
                            while (daAlumno[j].lDNotasTareas[iSubIndice] > dPivoteNotasTareas) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        decimal dPivoteNotasTareas = daAlumno[iCentral].lDNotasTareas[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasTareas[iSubIndice] > dPivoteNotasTareas) i++;
                            while (daAlumno[j].lDNotasTareas[iSubIndice] < dPivoteNotasTareas) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo, iSubIndice);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo, iSubIndice);

                    break;

                case "lDNotasProyectos":
                    if (bAD)
                    {
                        decimal dPivoteNotasProyectos = daAlumno[iCentral].lDNotasProyectos[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasProyectos[iSubIndice] < dPivoteNotasProyectos) i++;
                            while (daAlumno[j].lDNotasProyectos[iSubIndice] > dPivoteNotasProyectos) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        decimal dPivoteNotasProyectos = daAlumno[iCentral].lDNotasProyectos[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasProyectos[iSubIndice] > dPivoteNotasProyectos) i++;
                            while (daAlumno[j].lDNotasProyectos[iSubIndice] < dPivoteNotasProyectos) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo, iSubIndice);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo, iSubIndice);

                    break;

                case "lDNotasExamenes":
                    if (bAD)
                    {
                        decimal dPivoteNotasExamentes = daAlumno[iCentral].lDNotasExamenes[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasExamenes[iSubIndice] < dPivoteNotasExamentes) i++;
                            while (daAlumno[j].lDNotasExamenes[iSubIndice] > dPivoteNotasExamentes) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    else
                    {
                        decimal dPivoteNotasExamentes = daAlumno[iCentral].lDNotasExamenes[iSubIndice];
                        do
                        {
                            while (daAlumno[i].lDNotasExamenes[iSubIndice] > dPivoteNotasExamentes) i++;
                            while (daAlumno[j].lDNotasExamenes[iSubIndice] < dPivoteNotasExamentes) j--;
                            if (i <= j)
                            {
                                IntercambiosQuick++;
                                daAuxiliar = daAlumno[i];
                                daAlumno[i] = daAlumno[j];
                                daAlumno[j] = daAuxiliar;
                                i++;
                                j--;
                            }
                        } while (i <= j);
                    }
                    if (inicio < j)
                        QuickSort(daAlumno, inicio, j, bAD, sCampo, iSubIndice);

                    if (i < fin)
                        QuickSort(daAlumno, i, fin, bAD, sCampo, iSubIndice);

                    break;
            }
        }

        /// <summary>
        /// Ordena un arreglo de cadenas 
        /// </summary>
        /// <param name="sListaLeida">Arreglo de Cadenas</param>
        /// <param name="inicio">Indice de Inicio</param>
        /// <param name="fin">Posición Final</param>
        public void QuickSort(string[] sListaLeida, int inicio, int fin)
        {
            IntercambiosQuick = 0;
            int i = inicio;
            int j = fin;
            int iCentral = (inicio + fin) / 2;
            string sAuxiliar = "";
            string sPivote = sListaLeida[iCentral];
            do
            {
                while (String.Compare(sListaLeida[i], sPivote) < 0) i++;
                while (String.Compare(sListaLeida[j], sPivote) > 0) j--;
                if (i <= j)
                {
                    IntercambiosQuick++;
                    sAuxiliar = sListaLeida[i];
                    sListaLeida[i] = sListaLeida[j];
                    sListaLeida[j] = sAuxiliar;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (inicio < j)
                QuickSort(sListaLeida, inicio, j);

            if (i < fin)
                QuickSort(sListaLeida, i, fin);
        }


        /// <summary>
        /// Verifica que un arreglo de alumnos este ordenado tomando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <returns>Vector en Orden</returns>
        private bool VerificarOrden(DataAlumno[] daAlumno, bool bAD, string sCampo)
        {
            switch (sCampo)
            {
                case "sNombre":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sNombre, daAlumno[i + 1].sNombre) > 0)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sNombre, daAlumno[i + 1].sNombre) < 0)
                                return false;
                        }
                    }
                    return true;

                case "sApellido":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sApellido, daAlumno[i + 1].sApellido) > 0)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sApellido, daAlumno[i + 1].sApellido) < 0)
                                return false;
                        }
                    }
                    return true;

                case "sCorreo":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sCorreo, daAlumno[i + 1].sCorreo) > 0)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sCorreo, daAlumno[i + 1].sCorreo) < 0)
                                return false;
                        }
                    }
                    return true;

                case "sCurso":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sCurso, daAlumno[i + 1].sCurso) > 0)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (String.Compare(daAlumno[i].sCurso, daAlumno[i + 1].sCurso) < 0)
                                return false;
                        }
                    }
                    return true;

                case "iCarne":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].iCarne > daAlumno[i + 1].iCarne)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].iCarne < daAlumno[i + 1].iCarne)
                                return false;
                        }
                    }
                    return true;

                case "dNotaFinal":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].dNotaFinal > daAlumno[i + 1].dNotaFinal)
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].dNotaFinal < daAlumno[i + 1].dNotaFinal)
                                return false;
                        }
                    }
                    return true;

                default:
                    return false;
            }
        }
        /// <summary>
        /// Verifica que un arreglo de alumnos este ordenado tomando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="ISubIndice">SubIndice de Lista</param>
        /// <returns>Vector en Orden</returns>
        private bool VerificarOrden(DataAlumno[] daAlumno, bool bAD, string sCampo, int ISubIndice)
        {
            switch (sCampo)
            {
                case "lDNotasTareas":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasTareas[ISubIndice] > daAlumno[i + 1].lDNotasTareas[ISubIndice])
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasTareas[ISubIndice] < daAlumno[i + 1].lDNotasTareas[ISubIndice])
                                return false;
                        }
                    }
                    return true;

                case "lDNotasProyectos":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasProyectos[ISubIndice] > daAlumno[i + 1].lDNotasProyectos[ISubIndice])
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasProyectos[ISubIndice] < daAlumno[i + 1].lDNotasProyectos[ISubIndice])
                                return false;
                        }
                    }
                    return true;

                case "lDNotasExamenes":
                    if (bAD)
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasExamenes[ISubIndice] > daAlumno[i + 1].lDNotasExamenes[ISubIndice])
                                return false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < daAlumno.Length - 1; i++)
                        {
                            if (daAlumno[i].lDNotasExamenes[ISubIndice] < daAlumno[i + 1].lDNotasExamenes[ISubIndice])
                                return false;
                        }
                    }
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        public void StupidSort(DataAlumno[] daAlumno, bool bAD, string sCampo)
        {
            while (!VerificarOrden(daAlumno, bAD, sCampo))
            {
                Random r = new Random();
                int i = r.Next(0, daAlumno.Length);
                int j = r.Next(0, daAlumno.Length);
                DataAlumno Auxiliar = daAlumno[i];
                daAlumno[i] = daAlumno[j];
                daAlumno[j] = Auxiliar;
            }
        }
        /// <summary>
        /// Ordena un arreglo de alumnos utilizando un campo como guía
        /// </summary>
        /// <param name="daAlumno">Vector de Alumnos</param>
        /// <param name="bAD">Acendente = Verdadero, Descendente = Falso</param>
        /// <param name="sCampo">Campo guía</param>
        /// <param name="iSubIndice">SubIndice de Lista</param>
        public void StupidSort(DataAlumno[] daAlumno, bool bAD, string sCampo, int iSubIndice)
        {
            while (!VerificarOrden(daAlumno, bAD, sCampo, iSubIndice))
            {
                Random r = new Random();
                int i = r.Next(0, daAlumno.Length);
                int j = r.Next(0, daAlumno.Length);
                DataAlumno Auxiliar = daAlumno[i];
                daAlumno[i] = daAlumno[j];
                daAlumno[j] = Auxiliar;
            }
        }

    }
}
