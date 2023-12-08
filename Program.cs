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
            if (ejercicioxd == 1)
            {

                //Ejercicio 1:
                Console.WriteLine("********* EJERCICIO 1 *********");
                int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] a2 = new int[100]; // 1,2,3,4,5,6,7,8,9,10,... 100

                for (int i = 0; i < 100; i++)
                {
                    a2[i] = i + 1;
                }
                //Visualizar los dos arrays
                for (int i = 0; i < a1.Length; i++)
                {
                    Console.Write(a1[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("a2: ");
                Console.WriteLine();
                Funciones.printArray(a2);
                Console.WriteLine();

            }

            if (ejercicioxd == 2)
            {

                //Ejercicio 2: 
                Funciones.printEnunciado(2);
                float[] a3 = new float[20];

                Funciones.printArray(a3);

            }

            if (ejercicioxd == 3)
            {

                //Ejercicio 3: 
                Funciones.printEnunciado(3);
                int[] a4 = new int[10];

                a4[0] = -1;
                a4[2] = -1;
                a4[5] = -1;
                a4[9] = -1;

                Funciones.printArray(a4);
            }

            if (ejercicioxd == 4)
            {

                //Ejercicio 4:
                Funciones.printEnunciado(4);

                String[] libros = new string[50];

                libros[0] = "Los Pilares de la Tierra";
                libros[1] = "El archivo de las tormentas";
                libros[2] = "Los bolechas";
                libros[3] = "Los secretos de Youtube";
                libros[4] = "El clan del oso cavernario";

                /* for(int i = 0; i < libros.Length; i++)
                 {
                     Console.WriteLine(libros[i] + " ");
                 }
                 Console.WriteLine();*/

                Funciones.printArray(libros);

            }

            if (ejercicioxd == 5)
            {


                Funciones.printEnunciado(5);

                short[] a5 = new short[4];

                for (int i = 0; i < a5.Length; i++)
                {
                    Console.WriteLine("Intro valor posicion. " + i);
                    a5[i] = short.Parse(Console.ReadLine());
                }

                Funciones.printArray(a5);

            }

            if (ejercicioxd == 6)
            { 

                Funciones.printEnunciado(6);

                double[] a6 = new double[8];

                //Actualizar la última pos a -1
                a6[a6.Length - 1] = -1;

                for (int i = 0; i < a6.Length; i++)
                {
                    Console.Write(a6[i] + " ");
                }

                Console.WriteLine();

            }

            if (ejercicioxd == 7)
            {

                Console.WriteLine("Dime el valor de la array:");
                int a1 = int.Parse(Console.ReadLine());
                int[] Kid = new int[a1];

                Kid[Kid.Length -1 ] = 25; 
                Kid[0] = 90;

                for (int i = 0; i < Kid.Length; i++)
                {
                    Console.Write(Kid[i] + " ");
                }
                Console.WriteLine();

            }

            if (ejercicioxd == 8)
            {

                int[] Luffy = new int[100];

                Random generador = new Random();
                int num = generador.Next(0, 11);

                for (int i = 0; i < 100; i++)
                {

                    Luffy[i] = generador.Next(1, 11);

                    Console.Write(Luffy[i] + " ");

                }
                Console.ReadLine();
            }

            if ( ejercicioxd == 9)
            {

                int[] Law = new int[100];

                for (int i = 0; i < 100; i += 2)
                {

                    Law[i] = i / 2 + 1;

                    Console.Write(Law[i] + " ");

                }
                Console.ReadLine();

            }

            if (ejercicioxd == 10)
            {

                int[] CR7 = new int[100];

                Random generador = new Random();

                for (int i = 1; i < 100; i += +2)
                {

                    CR7[i] = generador.Next(10, 36);

                    Console.Write(CR7[i] + " ");

                }
                Console.ReadLine();

            }

            if (ejercicioxd == 14)
            {

                Funciones.printEnunciado(14);

                int[] a14 = new int[100];
                double c14 = 0;
                Random generador = new Random();

                for (int i = 1; i < 100; i++)
                {

                    a14[i] = generador.Next(1, 9999);
                    // double b14 = a14[i] * a14[i];
                    double b14 = Math.Sqrt(a14[i]);
                    Console.WriteLine("El cuadrado de la casilla "+ i + " es " + b14);

                    c14 += b14;

                    
                }
                Console.WriteLine("La suma de los cuadrados es " + c14);
            }

            if (ejercicioxd == 15)
            {

                Funciones.printEnunciado(15);

                int[] a15 = new int[100];
                int b15 = 0;
                Random generador = new Random();

                for (int i = 1; i < 100; i++)
                {

                    a15[i] = generador.Next();
                    
                    Console.WriteLine("El valor de la casilla " + i + " es " + a15[i]);
                    
                    if (a15[i] >= 0)
                    {

                        b15 += a15[i];

                    }
                }
                Console.WriteLine("La suma de los números positivos es " + b15);

            }

            if (ejercicioxd == 17)
            {

                Funciones.printEnunciado(17);

                int[] a17 = new int[100];
                int b17 = 0;
                int c17 = 0;
                Random generador = new Random();

                for (int i = 1; i < 100; i++)
                {

                    a17[i] = generador.Next();

                    Console.WriteLine("El valor de la casilla " + i + " es " + a17[i]);

                    if (a17[i] % 2 != 0 )
                    {

                        b17++;

                    }
                }
                c17 = (b17 * 100) / 100;
                Console.WriteLine("El porcentaje de números impares es " + c17 + "%");

            }

            if (ejercicioxd == 26)
            {

                double[] a26 = new double[100];
                double A26 = 0;
                double[] b26 = new double[100];
                double B26 = 0;
                double c26 = 0;

                Random generador = new Random();

                a26[0] = 5;
                for (int i = 1;i < a26.Length; i++)
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

                for (int i = 0; i <100;  i++)
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
