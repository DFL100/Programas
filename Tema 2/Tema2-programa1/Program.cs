using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que clasifica un número como par o impar
            int numero = 11;
            if (numero % 2 == 0)
            { Console.WriteLine(numero + " es par"); }
            else
            { Console.WriteLine(numero + " es par"); }

            Console.ReadLine();

            //Programa que indica si un número es 0 o distinto de cero
            int numero2 = 3;

            if (numero2 == 0)
            { Console.WriteLine(numero2 + " es distinto de 0"); }
            else
            { Console.WriteLine(numero2 + " es igual a 0"); }

            //Programa que clasifica un número como multiplo de 3 o no

            int numero3 = 15;

            if (numero3 % 3 == 0)
            { Console.WriteLine(numero3 + " es múltiplo de 3"); }
            else
            { Console.WriteLine(numero3 + " no es múltiplo de 3"); }

            Console.ReadLine();

            //Programa que a partir del salario bruto del trabajador aplica un IRPF del 15% si el salario <= 1200€ y un irpf del 19% si es superior
            int numero4;

            Console.WriteLine("Cuanto cobra al mes?");
            numero4 = int.Parse(Console.ReadLine());

            if (numero4 > 1200)
            { Console.WriteLine("Su salario es de " + numero4 + " y hacienda le quitará 19% "); }
            else
            { Console.WriteLine("Su salario es de " + numero4 + " y hacienda le quitará 15% "); }

            Console.ReadLine();

            //Programa que clasifica un número como negativo, cero o positivo
            int numero5 = 900;

            if (numero5 < 0)
            { Console.WriteLine("Número negativo"); }
            else if (numero5 == 0)
            { Console.WriteLine("Número es 0 "); }
            else
            { Console.WriteLine("Número es positivo"); }
            Console.ReadLine();

            //Programa que clasifica un número como multiplo de 3, multiplo de 5 o los dos
            int numero6;
            Console.WriteLine("Dime un número:");
            numero6 = int.Parse(Console.ReadLine());

            if ((numero6 % 3 == 0) && (numero6 % 5 == 0))
            { Console.WriteLine("Es múltiplo de 5 y de 3"); }

            else if (numero6 % 3 ==0)
                    { Console.WriteLine("Es multiplo de 3"); }
            
            else if (numero6 % 5 ==0)
                    { Console.WriteLine("Es múltiplo de 5"); }

            
            else 
                    { Console.WriteLine("No es múltiplo ni de 5 ni de 3"); }

            Console.ReadLine() ;

            //Crear un programa con los mínios para aprobar
            //Aprobar examenes
            //Aprobar las tareas
            //Buen comportamiento

            Boolean ExamenesAprobados = true;
            Boolean TrabajosAprobados = true;
            Boolean BuenComportamiento = true;

            if (ExamenesAprobados == false) 
            { 
                Console.WriteLine("Suspendiste por falta de nota en los examenes"); 
            }

            else if (TrabajosAprobados == false)
            {
                Console.WriteLine("Suapendiste por gañán");
            }
            
            else if (BuenComportamiento == false)
            {
                Console.WriteLine("Suspendiste por bobolón");
            }

            else if (ExamenesAprobados && TrabajosAprobados && BuenComportamiento) 
            {
                Console.WriteLine("Aprobaste máquina!");
            }

            Console.ReadLine() ;

        }
    }
}
