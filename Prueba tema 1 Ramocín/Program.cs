using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tema_1_Ramocín
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //crea un programa que lea 3 valores y calcule
            //La media
            //Calcule el módulo: (a2, b2, c2) --> con dos decimales
            //Utilizando la libreria match obtener el más pequeño

            double a1;
            double a2;
            double a3;

            Console.WriteLine("Dime un número: ");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número: ");
            a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime un ultimo número: ");
            a3 = double.Parse(Console.ReadLine());

            //Calcular la media
            double media;
            media = (a1 + a2 + a3) / 3;
            Console.WriteLine("La media de los tres es de " + media);
            Console.ReadLine();

            //Calcular el módulo
            double modulo1;
            modulo1 = (float)Math.





        }
    }
}
