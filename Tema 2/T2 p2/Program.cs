using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace T2_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 16:");

            int[] a16 = new int[20];
            
            a16[0] = 1;
            a16[1] = 10;
            a16[2] = -3;
            a16[3] = 612;
            a16[4] = -9;

            for(int i = 0; i < a16.Length; i++)
            {

                  if (a16[i] < 0)
                {

                    Console.Write(a16[i] + " ");

                }  

            }
            Console.ReadLine();


            Console.WriteLine("Ejercicio 18:");

            string[] a18 = new string[20];
            int contador18 = 0;

            for(int i = 0; i < a18.Length; i++)
            {

                if (a18[i] == null)
                {
                    contador18++;

                    
                }

            }
            Console.Write(contador18 + " ");
            Console.ReadLine();

            // ejercicio 12

            int[] a12 = new int[20];

            //Método que llena un array con números aleatorios

            Random generador = new Random();
            for (int i=0; i < a12.Length; i++)
            {

                a12[i] = generador.Next();

            }

            long suma = 0;

            for (int i = 0; i <a12.Length; i++)
            {

                suma = suma + a12[i];

            }

            Console.WriteLine("Suma: " + suma);

            Console.ReadLine();


            //*********************************

            int[] a1 = new int[20000];
            int[] a2 = new int[20000];
            int suma2 = 0;


            for (int i = 1; i < a1.Length; i++) //Generar los números aleatoriamente
            {

                //Console.WriteLine("Digame el valor del " + i + " apartado de la array");
                //a1[i] = int.Parse(Console.ReadLine());
                a1[i] = generador.Next();
                

            }

            Console.WriteLine("Los valores de la array a1 son; ");
            for (int i = 0; i < a2.Length; i++)
            {

                Console.Write(a1[i] + " ");

            }

            for(int contador = 0; contador < a2.Length; contador++)
            {

                suma2 = suma2 + contador;

            }

            Console.ReadLine() ;
            Console.WriteLine("Jajaja pensabas que ya se ha acabado???");

            for (int i = 1; i < a1.Length; i++)
            {

                Console.WriteLine("Digame el valor del " + i + " apartado de la array");
                a2[i] = int.Parse(Console.ReadLine());

            }

            Console.ReadLine();



        }
    }
}
