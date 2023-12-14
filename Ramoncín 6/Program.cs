using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double suma1;
            double suma2;
            Console.WriteLine("Digame un número:");
            suma1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digame otro número:");
            suma2 = Convert.ToDouble(Console.ReadLine());
            double resultadosuma = suma1 + suma2;
            Console.WriteLine("La suma de " + suma1 + " más " + suma2 + " es igual a " + resultadosuma);
            Console.ReadLine();

            double resta1;
            double resta2;
            Console.WriteLine("Digame un número:");
            resta1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digame otro número:");
            resta2 = Convert.ToDouble(Console.ReadLine());
            double resultadoresta = resta1 - resta2;
            Console.WriteLine("La resta de " + suma1 + " más " + suma2 + " es igual a " + resultadoresta);
            Console.ReadLine();

            double multiplicación1;
            double multiplicación2;
            Console.WriteLine("Digame un número:");
            multiplicación1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digame otro número:");
            multiplicación2 = Convert.ToDouble(Console.ReadLine());
            double resultadomultiplicación = multiplicación1 * multiplicación2;
            Console.WriteLine("La suma de " + suma1 + " más " + suma2 + " es igual a " + resultadomultiplicación);
            Console.ReadLine();

        }
    }
}
