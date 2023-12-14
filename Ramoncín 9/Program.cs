using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conseguir los primeros datos.

            double dato1;
            Console.WriteLine("Escriba un número: ");
            dato1 = double.Parse(Console.ReadLine());

            double dato2;
            Console.WriteLine("Escriba otro número: ");
            dato2 = double.Parse(Console.ReadLine());

            //Traspasar los datos.

            double dato1_2;
            dato1_2 = dato2;

            double dato2_1;
            dato2_1 = dato1;

            //Pasar los datos

            dato1 = dato2;
            dato2 = dato2_1;

        }
    }
}
