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


            Console.ReadLine();
        }
    }
}
