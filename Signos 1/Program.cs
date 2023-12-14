using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Operadores matemáticos: + , - , * , / , % .
            //Estos operadores generan un valor cuyo tipo depende de los operandos.
            //Por ejemplo: Los operadores + , - , y * :
            // --> Si los operandos son short, o byte o int devuelve siempre un int

            byte x1 = 9;
            byte x2 = 10;
            byte resultado = (Byte)(x1 + x2);
            int resultado2 = x1 + x2;
            
            //Si hay dos tipos de operando, devuelve el de mayor capacidad
            long x3 = 900000;
            int x4 = 1000;
            int suma = (int)(x3 + x4);
            long suma2 = x3 + x4;

            //El operador / si los operandos son de tipo int devuelven un valor de tipo int,
            //Aunque el resultado no sea exacto
            int a1 = 9;
            int a2 = 5;
            double división2 = a1 / a2;
            double división = (double)(a1 / a2); //Esto no funciona, xq ya se calculó como 1
            double división3 = (double)a1 / a2;
            string división4 = Convert.ToString((double)a1 / a2);
            Console.WriteLine("El resultado de la primera división es " + división);
            Console.WriteLine("El resultado de la segunda división es " + división2);
            Console.WriteLine("El resultado de la tercera división es " + división3);
            Console.WriteLine("El resultado de la cuarta división es " + división4);

            Console.ReadLine();

        }
    }
}
