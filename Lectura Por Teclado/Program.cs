using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_Por_Teclado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que solicita al usuario DNI y Edad
            String dni;
            byte edad;

            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine ();

            Console.WriteLine("Introduce su Edad: ");
            edad = byte.Parse(Console.ReadLine ());



        }
    }
}
