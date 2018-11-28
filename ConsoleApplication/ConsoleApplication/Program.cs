using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            terceraCancion terceraCancion = new terceraCancion();
            segundaCancion segundaCancion = new segundaCancion();
            primeraCancion primeraCancion = new primeraCancion();
            

            Console.Write("Escriba un sonido de los animalitos: ");

            string sonido = Console.ReadLine();

            if (sonido == "brr")
            {
                Console.WriteLine("Canción: " + primeraCancion.escuchar());
                Console.WriteLine("");
           }
            else if (sonido == "birip")
            {
                Console.WriteLine("Canción: " + segundaCancion.escuchar());
                Console.WriteLine("");
            }
            else if (sonido == "plop")
            {
               Console.WriteLine("Canción: " +  terceraCancion.escuchar());
               Console.WriteLine("");
            }
            else if (sonido == "croac" || sonido == "brrah")
            {
               Console.WriteLine("No podemos reproducir ninguna canción");
               Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No presionaste ninguna opcion valida");
                Console.WriteLine("");
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadLine();
        }
    }
}
