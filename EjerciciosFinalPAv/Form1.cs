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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ManejoDeArchivos manejoDeArchivos = new ManejoDeArchivos();

        private void Fila(ref DataTable dtTabla, string[] Resultado)
        {
            DataRow drFila;
            drFila = dtTabla.NewRow();

            string[] datos = Resultado;

            for (int i = 0; i < datos.Length; i++)
            {
                drFila[i] = datos[i];
            }
            dtTabla.Rows.Add(drFila);
        }

        private void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();

            tabla.Columns.Add("LDE");
            tabla.Columns.Add("LC");
            tabla.Columns.Add("SALIDA");

            //foreach (ListaCircular dato in manejoDeArchivos.Lista)
            //{
            //   // Fila(ref tabla);
            //}

            dataGridView1.DataSource = tabla;

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            openFileDialog.Filter = "Archivo csv (*.txt)|*.txt";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                txbRuta.Text = openFileDialog.FileName;
                btnGenerarTabla.Enabled = true;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            manejoDeArchivos.LecturaArchivo(txbRuta.Text);
        }
    }
}
