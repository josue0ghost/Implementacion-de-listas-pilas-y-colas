using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    class ValidacionDeCasos
    {
        //    string[] Salida = new string[6];

        //    private void Caso1(ListaDoblementeEnlazada LDE, ListaCircular LC)
        //    {
        //        int Contador = 0;
        //        for (int i = 0; i < LDE.Count; i++)
        //        {
        //            if (LDE.Obtener(i) == LC.Obtener(0))
        //            {
        //                for (int j = i; j < LDE.Count; j++)
        //                {
        //                    if (LDE.Obtener(j) == LC.Obtener(Contador))
        //                    {
        //                        Contador++;
        //                    }
        //                }
        //            }
        //        }
        //        if (Contador == LC.Count)
        //        {
        //            Salida[0] = "1";
        //        }
        //        else
        //        {
        //            Salida[0] = "0";
        //        }          
        //    }

        //    private void Caso2(ListaDoblementeEnlazada LDE, ListaCircular LC)
        //    {
        //        int Contador = LC.Count;
        //        for (int i = 0; i < LDE.Count; i++)
        //        {
        //            if (LDE.Obtener(i) == LC.Obtener(Contador))
        //            {
        //                for (int j = i; j < LDE.Count; j--)
        //                {
        //                    if (LDE.Obtener(j) == LC.Obtener(Contador))
        //                    {
        //                        Contador++;
        //                    }
        //                }
        //            }
        //        }
        //        if (Contador == LC.Count)
        //        {
        //            Salida[1] = "1";
        //        }
        //        else
        //        {
        //            Salida[1] = "0";
        //        }
        //    }

        //    private void Caso3(ListaCircularDoblementeEnlazada LCDE, ListaCircular LC)
        //    {
        //        int Contador = 0;
        //        bool Caso = false;
        //        int i = 0;

        //        while (Caso == false)
        //        {
        //            if (LCDE.Obtener(i) == LC.Obtener(0))
        //            {
        //                for (int j = i; j < LC.Count; j += 2)
        //                {
        //                    if (LCDE.Obtener(j) == LC.Obtener(Contador))
        //                    {
        //                        Contador++;
        //                    }
        //                }
        //            }
        //            if (Contador == LC.Count)
        //            {
        //                Caso = true;
        //            }
        //        }

        //        if (Contador == LC.Count)
        //        {
        //            Salida[2] = "1";
        //        }
        //        else
        //        {
        //            Salida[3] = "0";
        //        }
        //    }

        //    private void Caso4(ListaCircularDoblementeEnlazada LCDE, ListaCircular LC)
        //    {
        //        int Contador = 0;
        //        bool Caso = false;
        //        int i = 0;

        //        while (Caso == false)
        //        {
        //            if (LCDE.Obtener(i) == LC.Obtener(0))
        //            {
        //                for (int j = i; j < LC.Count; j -= 2)
        //                {
        //                    if (j < 0)
        //                    {

        //                    }
        //                    if (LCDE.Obtener(j) == LC.Obtener(Contador))
        //                    {
        //                        Contador++;
        //                    }
        //                }
        //            }
        //            if (Contador == LC.Count)
        //            {
        //                Caso = true;
        //            }
        //        }

        //        if (Contador == LC.Count)
        //        {
        //            Salida[2] = "1";
        //        }
        //        else
        //        {
        //            Salida[3] = "0";
        //        }
        //    }
    }
}
