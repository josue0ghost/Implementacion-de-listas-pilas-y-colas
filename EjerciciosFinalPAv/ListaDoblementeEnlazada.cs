using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    public unsafe struct NodoDoble
    {
        public Data Info;
        public NodoDoble* Siguiente;
        public NodoDoble* Anterior;
        public bool Ultimo;
    }

    public unsafe class ListaDoblementeEnlazada
    {
        public NodoDoble* Cabeza;
        int Tamaño;

        public ListaDoblementeEnlazada()
        {
            this.Cabeza = null;
            this.Tamaño = 0;
        }

        public bool Vacio
        {
            get { return this.Tamaño == 0; }
        }

        public int Count
        {
            get { return this.Tamaño; }
        }

        public NodoDoble* UltimoElemento()
        {
            NodoDoble* nTemp = Cabeza;

            while (nTemp->Siguiente != null)
            {
                nTemp = nTemp->Siguiente;
            }

            return nTemp;
        }

        public void RecorrerLista()
        {
            NodoDoble* pFinal = UltimoElemento();
        }

        public NodoDoble* RecorrerListaHaciaAtras()
        {
            NodoDoble* nTemp = UltimoElemento();

            while (nTemp->Anterior != null)
            {
                nTemp = nTemp->Anterior;
            }

            return nTemp;
        }

        public Data Insertar(int Indice, Data dato)
        {
            if (Indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice: " + Indice);
            }
            if (Indice > Tamaño)
            {
                Indice = Tamaño;
            }

            NodoDoble* Actual = (NodoDoble*)Marshal.AllocHGlobal(sizeof(NodoDoble));

            Actual->Info = dato;
            Actual->Ultimo = true;

            if (this.Vacio || Indice == 0)
            {
                this.Cabeza = Actual;
                Actual->Siguiente = null;
                Actual->Anterior = null;
            }
            else
            {
                NodoDoble* Final = this.Cabeza;
                NodoDoble* Temporal;
                while (Final->Siguiente != null)
                {


                    if (Indice == 1)
                    {
                        Final->Anterior = this.Cabeza;
                    }

                    Temporal = Final;
                    Final = Final->Siguiente;
                    Final->Anterior = Temporal;

                }

                Final->Ultimo = false;

                Final->Siguiente = Actual;
                Actual->Siguiente = null;
                Actual->Anterior = Final;
            }

            Tamaño++;

            return dato;
        }

        public void Insertar(Data dato)
        {
            this.Insertar(Tamaño, dato);
        }

        public void Eliminar(int Indice)
        {
            if (Indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice: " + Indice);
            }
            if (this.Vacio)
            {
                //return null;
            }
            if (Indice >= this.Tamaño)
            {
                Indice = Tamaño - 1;
            }

            NodoDoble* Elimina;

            if (this.Cabeza == null)
            {
                Tamaño = 1;
            }
            else if (this.Cabeza->Siguiente == null)
            {
                Marshal.FreeHGlobal((IntPtr)Cabeza);
                this.Cabeza = null;
            }
            else if (Indice >= Tamaño)
            {
                NodoDoble* Final = this.Cabeza;

                while (Final->Siguiente->Siguiente != null)
                {
                    Final = Final->Siguiente;
                }
                Elimina = Final->Siguiente;
                Final->Siguiente = null;

                Marshal.FreeHGlobal((IntPtr)Elimina);
                Elimina = null;
            }
            else
            {

                NodoDoble* Actual = this.Cabeza;

                for (int i = 0; i < Indice - 1; i++)
                {
                    Actual = Actual->Siguiente;
                }

                Elimina = Actual->Siguiente;
                Actual->Siguiente->Siguiente->Anterior = Actual;
                Actual->Siguiente = Actual->Siguiente->Siguiente;

                Marshal.FreeHGlobal((IntPtr)Elimina);

            }

            Tamaño--;
        }

        public void Limpiar()
        {
            this.Cabeza = null;
            Marshal.FreeHGlobal((IntPtr)this.Cabeza);
            this.Tamaño = 0;
        }

        public int IndiceDe(Data dato)
        {
            NodoDoble* Actual = this.Cabeza;

            for (int i = 0; i < this.Tamaño; i++)
            {
                if (Actual->Info.Equals(dato))
                {
                    return i;
                }
                Actual = Actual->Siguiente;

            }

            return -1;
        }

        public bool Contiene(Data dato)
        {
            return this.IndiceDe(dato) >= 0;
        }

        public Data Obtener(int Indice)
        {
            if (Indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice: " + Indice);
            }
            if (this.Vacio)
            {
                // return null
            }
            if (Indice >= this.Tamaño)
            {
                Indice = this.Tamaño - 1;
            }

            NodoDoble* Actual = this.Cabeza;

            for (int i = 0; i < Indice; i++)
            {
                Actual = Actual->Siguiente;
            }
            return Actual->Info;
        }

        public Data this[int Indice]
        {
            get { return this.Obtener(Indice); }
        }


    }
}
