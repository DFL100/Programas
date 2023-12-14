using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escoge el ejercicio:");
            int ejercicioxd = int.Parse(Console.ReadLine());
     
            if (ejercicioxd == 26)
            {

                double[] a26 = new double[100];
                double A26 = 0;
                double[] b26 = new double[100];
                double B26 = 0;
                double c26 = 0;

                Random generador = new Random();

                a26[0] = 5;
                for (int i = 1; i < a26.Length; i++)
                {

                    a26[i] = generador.Next();

                    Console.WriteLine("El valor " + i + " de a26 es " + a26[i]);
                    A26 += a26[i];

                }
                Console.WriteLine("La suma de todas las celdas de a26 es " + A26);

                Console.ReadLine();

                b26[0] = 5;

                for (int i = 1; i < b26.Length; i++)
                {

                    b26[i] = generador.Next();

                    Console.WriteLine("El valor " + i + " de b26 es " + b26[i]);
                    B26 += b26[i];

                }
                Console.WriteLine("La suma de todas las celdas de b26 es " + B26);

                for (int i = 0; i < 100; i++)
                {

                    if (a26[i] == b26[i])
                    {

                        Console.WriteLine("La cuadrícula " + i + " es igual en las dos arrays");

                    }
                    else
                    {

                        Console.WriteLine("La cuadrícula " + i + " no es igual en las dos arrays");
                        c26++;

                    }

                }

                Console.ReadLine();

                if (A26 == B26)
                {

                    Console.WriteLine("La suma de las dos arrays es la misma");

                }
                else
                {

                    Console.WriteLine("La suma de las dos arrays no es la misma");

                }

                Console.ReadLine();
                if (c26 != 0)
                {

                    Console.WriteLine("Las arrays son distintas");

                }
                else
                {

                    Console.WriteLine("Las arrays son iguales");

                }

            }

            Console.ReadLine();
        }
    }
}