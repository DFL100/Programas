using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3_repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bucle do while
            //Programa que lee un número entre 1 y 5

            int numero = 0;

            do
            {

                Console.WriteLine("Introduzca un número entre 1 y 5");
                numero = int.Parse(Console.ReadLine());

            }
            while (numero < 1 || numero > 5);

            switch (numero)
            {

                case 1:
                    Console.WriteLine("Es uno");
                    break;
                case 2:
                    Console.WriteLine("Es uno");
                    break;
                case 3:
                    Console.WriteLine("Es uno");
                    break;
                default:
                    Console.WriteLine("no encontrado");
                    break;
                    

            }

            int a = 50;

            for (int i = 0; i > 75; i++)
            {

                Console.WriteLine(a + " ");
                a += 5;

            }

            Console.ReadLine();

            //Mostrar el primero número múltiplo de 2 y 7 en un intervalo de n y m

            int n = 0;
            int m = 0;
            
            do
            {
                Console.WriteLine("Que valor le quieres dar a n?");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Que valor mayor que n le quieres dar a m?");
                m = int.Parse(Console.ReadLine());
            }
            while (n > m);

            bool encontrado = false;

            for (int i = n; i <= m; i++)
            {

                if (i % 2 == 0 && i % 7 == 0)
                {
                    encontrado = true;
                    Console.WriteLine(i + " es múltiplo de 7 y 2");
                    break;
                }

            }

            if (!encontrado) //Igual que (encontrado == false);
            {

                Console.WriteLine("No hay múltiplos");

            }
            

            Console.ReadLine();
        }
    }
}
