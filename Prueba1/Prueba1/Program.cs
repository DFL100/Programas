using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular la raíz cuadrada de una variable
            double a1, a2;
            Console.WriteLine("Dime un número para saber su raíz cuadrada: ");
            a1 = double.Parse(Console.ReadLine());
            a2 = Math.Sqrt(a1);
            Console.WriteLine("La raíz cuadrada de " + a1 + " es " + a2);
            Console.ReadLine();

            //Calcular una variable elevada a otra variable
            double b1, b2, b3;
            Console.WriteLine("Dime un número para elebar: ");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime sobre que número quieres elevar el anterior: ");
            b3= double.Parse(Console.ReadLine());
            b2 = Math.Pow(b1, b3);
            Console.WriteLine(b1 + " Elevado a " + b3 + " es " + b2);
            Console.ReadLine();

            //Calcular una suma entre vatiables
            double c1, c2, c3;
            Console.WriteLine("Dime un número: ");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número para sumarlos: ");
            c2 = double.Parse(Console.ReadLine());
            c3 = c1 + c2;
            Console.WriteLine("La suma entre " + c1 + " y " + c2 + " es " + c3);
            Console.ReadLine();




        }
    }
}
