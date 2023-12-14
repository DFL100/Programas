using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a;
            Console.WriteLine("Dime la medida del lado: ");
            a = float.Parse(Console.ReadLine());

            float raíz1;
            raíz1 = (float)Math.Sqrt(3);

            float d;
            d = raíz1 * a;

            float al;
            al = 4 * (a * a);

            float v;
            v = (a * a * a);

            Console.WriteLine("D es " + d);
            Console.WriteLine("Al es " + al);
            Console.WriteLine("V es " + v);

            Console.ReadLine();


        }
    }
}
