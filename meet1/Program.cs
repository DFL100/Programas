using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (int valor in numeros)
            {

                Console.Write(valor + " , ");

            }
            */
//_____________________________________________________________________________________

            Console.WriteLine("Dime cuantos valores tiene la array:");
            int a11 = int.Parse(Console.ReadLine());
            int[] Ramon_dame_un_10 = new int[a11];

            bool cinco = false;
            for(int valor = 0; valor < Ramon_dame_un_10.Length; valor++)
            {

                if (Ramon_dame_un_10[valor] % 5 == 0)
                {

                    cinco = true;
                    Console.WriteLine(Ramon_dame_un_10[valor]);

                }

            }
            if(cinco = false)
            {

                Console.WriteLine("No hay multiplos de cinco.");

            }

            //algoritmo que suma y los cinco últimos elementos de un array

            Console.WriteLine("Dime cuantos valores tiene la array:");
            int a12 = int.Parse(Console.ReadLine());
            int[] Montecastelo = new int[a12];
            int sumaa = 0;

            for (int valor = Montecastelo.Length-5; valor < Montecastelo.Length; valor++)
            {

                sumaa += Montecastelo[valor];
                Console.WriteLine(Montecastelo[valor]);

            }
            Console.WriteLine("Suma final: " + sumaa);
            Console.ReadLine();


            //_________________________________________________________________________________________

            Console.WriteLine("Dime cuantos valores tiene la array:");
            int a13 = int.Parse(Console.ReadLine());
            int[] Jesus = new int[a12];
            int suma20 = 0;

            for (int valor = 0;  valor < Jesus.Length; valor +=2)
            {

                /*if (Jesus[valor] % 2 == 0)
                {

                    suma20 += Jesus[valor];

                }*/

                suma20 += Jesus[valor];

            }
            Console.WriteLine("La suma da: " + Math.Pow(suma20, 3));
            Console.ReadLine();

            //Porcentage de números negativos en el array

            Console.WriteLine("Dime cuantos valores tiene la array:");
            int a14 = int.Parse(Console.ReadLine());
            int[] Prime = new int[a12];
            int suma202 = 0;

            int contadorxd = 0;

            for ( int valor = 0;valor < Prime.Length; valor++)
            {

                if (Prime[valor] <= 0)
                {

                    contadorxd += 1;

                }

            }

            int porcentaje = (contadorxd / Prime.Length ) * 100;
            Console.WriteLine("El porcentaje de números negtivos es de: " + porcentaje);
            Console.ReadLine();

        }
    }
}
