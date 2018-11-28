using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class segundaCancion
    {
        List<string> cancion = new List<string> { "pep", "birip", "trri-trri", "croac" };
        
        public string escuchar()
        {
            string sonido = "";
            for (int i = 2; i < cancion.Count; i++)
            {
                sonido += cancion[i] + " ";
            }
            return sonido;
        }
    }
}
