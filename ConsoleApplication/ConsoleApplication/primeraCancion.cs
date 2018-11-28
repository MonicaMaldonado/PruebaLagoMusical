using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class primeraCancion
    {
        List<string> cancion = new List<string> { "brr", "fiu", "cric-cric", "brrah" };
       
        public string escuchar()
        {
            string sonido = "";
            for (int i = 1; i < cancion.Count; i++)
            {
                sonido += cancion[i] + " ";
            }
            return sonido;
        }
    }
}
