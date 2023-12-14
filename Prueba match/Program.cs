using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_match
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a1;
            Console.WriteLine("Digame un número");
            a1 = Convert.ToDouble(Console.ReadLine());

            double a2;
            a2 = Math.Pow(a1, 2);
            Console.WriteLine(a1 + " elevado a dos es " + a2);
            Console.ReadLine();

            double a3;
            a3 = Math.Sqrt(a1);
            Console.WriteLine("La raíz cuadrada de " + a1 + " es " + a3);
            Console.ReadLine();

            double s, b, a;
            int y = 3;
            s = 255;
            a = (float)Math.Pow(s, 1 / 3);
            Console.WriteLine("La raiz cubica de 255 es " + a);
            Console.ReadLine();


        }
    }
}
