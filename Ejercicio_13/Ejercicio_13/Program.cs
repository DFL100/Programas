using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* h2 = a2 + b2
            h = Raiz(a2 + b2)
           */

            float h;
            Console.WriteLine("Dime la hipotenusa");
            h = float.Parse((string) Console.ReadLine());

            float a;
            Console.WriteLine("Dime la a");
            a = float.Parse((string) Console.ReadLine());

            float b;
            Console.WriteLine("Dime la b");
            b = float.Parse((string) Console.ReadLine());

            float h1 = h * h;
            float a1 = a * a;
            float b1 = b * b;

            h1 = a1 * b1;

            Console.WriteLine(h1);
            Console.ReadLine();

        }
    }
}
