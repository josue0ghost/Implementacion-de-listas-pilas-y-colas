using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{

    public unsafe struct NodoDobleCircular
    {
        public Data Info;
        public NodoDobleCircular* Siguiente;
        public NodoDobleCircular* Anterior;
        public bool Ultimo;
    }

    unsafe class ListaCircularDoblementeEnlazada
    {
        private NodoDobleCircular* Cabeza;
        private int Tamaño;

        public ListaCircularDoblementeEnlazada()
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

        private void Insertar(int Indice, Data dato)
        {
            if (Indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice: " + Indice);
            }
            if (Indice > Tamaño)
            {
                Indice = Tamaño;
            }


            NodoDobleCircular* Actual = (NodoDobleCircular*)Marshal.AllocHGlobal(sizeof(NodoDobleCircular));

            if (this.Vacio || Indice == 0)
            {
                this.Cabeza = Actual;
                Actual->Siguiente = this.Cabeza;
                Actual->Anterior = this.Cabeza;
            }
            else
            {
                NodoDobleCircular* Final = this.Cabeza;
                while (Final->Ultimo != true)
                {
                    Final = Final->Siguiente;
                }

                Final->Ultimo = false;

                Final->Siguiente = Actual;
                Actual->Siguiente = this.Cabeza;
                Actual->Anterior = Final;
            }

            Tamaño++;

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

            NodoDobleCircular* Elimina = this.Cabeza;

            if (this.Cabeza->Siguiente == null)
            {
                Marshal.FreeHGlobal((IntPtr)Cabeza);
                this.Cabeza = null;
            }
            else if(Indice >= Tamaño)
            {
                NodoDobleCircular* Final = this.Cabeza;

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

                NodoDobleCircular* Actual = this.Cabeza;

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
            this.Tamaño = 0;
        }

        public int IndiceDe(object dato)
        {
            NodoDobleCircular* Actual = this.Cabeza;

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

        public bool Contiene(object dato)
        {
            return this.IndiceDe(dato) >= 0;
        }

        public object Obtener(int Indice)
        {
            if (Indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice: " + Indice);
            }
            if (this.Vacio)
            {
                return null;
            }
            if (Indice >= this.Tamaño)
            {
                Indice = this.Tamaño - 1;
            }

            NodoDobleCircular* Actual = this.Cabeza;

            for (int i = 0; i < Indice; i++)
            {
                Actual = Actual->Siguiente;
            }
            return Actual->Info;
        }

        public object this[int Indice]
        {
            get { return this.Obtener(Indice); }
        }
    }
}
