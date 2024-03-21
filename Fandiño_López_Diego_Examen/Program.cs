using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fandiño_López_Diego_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Examen Diego Fandiño López

            int ejercicio = 0;

            do
            {

                Console.WriteLine("Escoge un ejercicio del 1 al 4:");
                ejercicio = int.Parse(Console.ReadLine());

            }
            while (ejercicio > 4 || ejercicio < 0) ;

            switch (ejercicio)
            {
                case 1:

                    Console.WriteLine("Ejercicio 1");

                    int a1 = 200;
                    int a2 = 20;

                    while (a1 < 400)
                    {

                        Console.Write(a1 + " , ");
                        a1 += 50;

                    }
                    Console.WriteLine();

                    while (a2 > 14)
                    {

                        Console.Write(a2 + " , ");
                        a2 -= 1;

                    }

                    break;

                case 2:

                    Console.WriteLine("Ejercicio 2") ;

                    int n2 = 0;
                    int m2 = 0;
                    bool a20 = false;

                    do
                    {

                        Console.WriteLine("Escoge el valor de n:");
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoge el valor de m:");
                        m2 = int.Parse(Console.ReadLine());

                    }
                    while (n2 > m2);

                    int n2copy = n2;

                    for (; n2 <= m2; n2++)
                    {

                        if (n2 % 2 == 0 && n2 % 11 == 0)
                        {

                            Console.WriteLine(n2 + " Es el primer número par y múltiplo de 11 entre n (" + n2copy + ") y m ("+ m2 +") ");
                            break;
                            a20 = true;

                        }
                       /* else
                        {

                            Console.WriteLine("No hay ningún número par y múltiplo de 11 en tre n (" + n2 + ") y m (" + m2 + ")");
                            
                        }*/
                    }
                    if (a20 = false)
                    {

                        Console.WriteLine("No hay ningún número par y múltiplo de 11 en tre n (" + n2 + ") y m (" + m2 + ")");

                    }

                    break;

                case 3:

                    Console.WriteLine("Ejercicio 3");




                    Console.WriteLine("Dígame un valor mayor que 10 para n:");
                    double n3 = int.Parse(Console.ReadLine());

                    for (double i = 10; i <= n3; i++)
                    {

                        double a3 = 1 + i / 2;
                        Console.WriteLine("1 + " + i + " / 2 = " + a3);

                    }

                    break;

                case 4:

                    Console.WriteLine("Ejercicio 4");

                    Console.WriteLine("Digame el valor de n");
                    int n4 = int.Parse(Console.ReadLine());

                    int contador = 0;

                    for (int i = 1; i <= n4 / 2; i++)
                    {

                        if (n4 % i == 0)
                        {

                            contador++;

                            Console.WriteLine("El " +  contador + "º divisor de " + n4 + " es " + i);

                           /* if ( contador == 2)
                            {

                                Console.WriteLine(n4 + " Es un número primo");

                            }*/

                        }


                    }
                    if (contador == 2)
                    {

                        Console.WriteLine(n4 + " Es un número primo");

                    }

                        break;


            }

            Console.ReadLine();
            Console.WriteLine("Programa de Diego Fandiño López for Ramón :)");
            Console.ReadLine();
        }
    }
}
