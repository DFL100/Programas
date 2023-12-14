using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreexAmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;

            do
            {

                Console.WriteLine("Escoge ejercicio:");
                ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {

                    case 1:

                        Console.WriteLine("sol");
                        break;

                    default:
                        Console.WriteLine("Gilipollas");
                        break;

                }

            }
            while (ejercicio > 5);
            Console.ReadLine();

        }
    }
}
