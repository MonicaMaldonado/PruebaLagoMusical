using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class terceraCancion
    {
        List<string> cancion = new List<string> { "bri-bri", "plop", "cric-cric", "brrah" };
        
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

