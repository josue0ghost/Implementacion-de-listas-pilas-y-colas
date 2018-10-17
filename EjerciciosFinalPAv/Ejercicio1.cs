using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFinalPAv
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        ListaDoblementeEnlazada LDE = new ListaDoblementeEnlazada();
        ListaDoblementeEnlazada LDE2 = new ListaDoblementeEnlazada();
        char[] Lista;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lbLDE1.Items.Clear();
            lbLDE2.Items.Clear();

            string sLinea = txbIngreso.Text;
            char[] Caracter = sLinea.ToCharArray();

            foreach (char item in Caracter)
            {
                if (item != ',')
                {
                    Data data = new Data();
                    data.Caracter = item;

                    LDE.Insertar(data);

                    lbLDE1.Items.Add(item);
                }
            }

            Lista = new char[LDE.Count];

            int i = 0;
            foreach (char item in Caracter)
            {
                if (item != ',')
                {
                    Lista[i] = item;
                    i++;
                }
            }

            ListaNueva();
        }

        public void ListaNueva()
        {
            int Contador = 0;
            for (int i = 0; i < Lista.Length; i++)
            {
                for (int j = 0; j < Lista.Length; j++)
                {
                    if (Lista[i] == Lista[j])
                    {
                        Contador++;
                    }
                }
                if (Contador == 3)
                {
                    if (!(lbLDE2.Items.Contains(Lista[i])))
                    {
                        Data data = new Data();
                        data.Caracter = Lista[i];

                        LDE2.Insertar(data);
                        lbLDE2.Items.Add(Lista[i]);
                    }
                }
                Contador = 0;

            }
        }
    }
}
