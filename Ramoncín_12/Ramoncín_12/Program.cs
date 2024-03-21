using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir lado
            float l;
            Console.WriteLine("Dime el lado :");
            l = float.Parse(Console.ReadLine());

            //Pedir el área
            float a;
            a = (float)Math.Pow(l, 2 );
            Console.WriteLine("El áera es de " + a);
            Console.ReadLine();

            //Pedir perímetro
            double p;
            p = 4 * l;
            Console.WriteLine("El perímetro es " + p );
            Console.ReadLine();

            /*Pedir la diagonal
            float d1;
            d1 = (float)Math.Sqrt(l);
            float d2 = l * d1;
            Console.WriteLine("La diagonal es " + d2);
            Console.ReadLine();
            */
            int x = 2;
            float d1 = l;
            float d1 = (float)Math.Sqrt(x);
            Console.WriteLine(d1);
            Console.ReadLine();


            
        }
    }
}
