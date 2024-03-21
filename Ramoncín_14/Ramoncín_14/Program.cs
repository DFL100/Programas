using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float p1;
            Console.WriteLine("Digame el precio del producto:");
            p1 = float.Parse(Console.ReadLine());

            float p2;
            Console.WriteLine("Digame el porcentage de la rebaja:");
            p2 = float.Parse(Console.ReadLine());

            float p3 = (p1 * p2) / 100;
            Console.WriteLine("Se le van a rebajar " +  p3 + " Euros");
            Console.ReadLine();

            float p4;
            p4 = p3 - p1;
            Console.WriteLine("Al aplicar un " + p2 + " por ciento de descuento el precio final del producto es de precio final y por lo tanto se ahorra " + p3 + " euros.");
            Console.ReadLine() ;
            
        }
    }
}
