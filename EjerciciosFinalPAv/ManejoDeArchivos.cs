using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjerciciosFinalPAv
{
    class ManejoDeArchivos
    {
        List<string> lSLineas = new List<string>();
        public List<string> LecturaArchivo(string sRuta)
        {
            StreamReader srLector = new StreamReader(sRuta, Encoding.Default);
            string sLineas = srLector.ReadLine();
            while (sLineas != null)
            {
                lSLineas.Add(sLineas);
                sLineas = srLector.ReadLine();
            }
            srLector.Close();
            return lSLineas;
        }

        List<string[]> lSDatos = new List<string[]>();
        public void DeStringAArreglo()
        {
            for (int i = 0; i < lSLineas.Count; i++)
            {
                char[] cTemp = lSLineas[0].ToCharArray();
                
                
            }
        }
    }
}
