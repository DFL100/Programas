using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ver si la suma de los divisores de dos números es la misma

            const int reset = 0;
            int número0 = 0;
            int número1 = 0;
            int contador0 = 0;
            int contadorInterno0 = 1;
            int contador1 = 0;
            int contadorInterno1 = 1;
            int continuar = 0;
            if (reset == 0)
            {
                contador0 = 0;
                contadorInterno0 = 1;
                contador1 = 0;
                contadorInterno1 = 1;
            }
            do
            {

                do
                {
                    Console.WriteLine("Digame un número mayor que 0");
                    número0 = int.Parse(Console.ReadLine());
                }
                while (número0 < 0);

                for (int i = 1; i < número0 / 2; i++)
                {

                    if (número0 % i == 0)
                    {
                        contador0 += i;
                        Console.WriteLine("El " + contadorInterno0 + "º múltiplo de " + número0 + " es " + i);
                        contadorInterno0++;
                    }

                }
                Console.WriteLine("La suma de todos los múltiplos de " + número0 + " es " + contador0);
                Console.ReadLine();

                do
                {
                    Console.WriteLine("Digame otro número mayor que 0");
                    número1 = int.Parse(Console.ReadLine());
                }
                while (número1 < 0);

                for (int i = 1; i < número1/2; i++)
                {

                    if (número1 % i == 0)
                    {
                        contador1 += i;
                        Console.WriteLine("El " + contadorInterno1 + "º múltiplo de " + número1 + " es " + i);
                        contadorInterno1 += 1;
                    }

                }
                Console.WriteLine("La suma de todos los múltiplos de " + número1 + " es " + contador1);
                Console.ReadLine();

                if (contador0 == contador1)
                {

                    Console.WriteLine("Son números primos porque la suma de sus divisores es " + contador1);

                }
                else
                {

                    Console.WriteLine("No son números primos porque la suma de sus divisores no es la misma.");

                }
                Console.ReadLine();

                Console.WriteLine("Quiere repetir el ejercicio? s/n");
                char repetir = char.Parse(Console.ReadLine());

                if (repetir == 's')
                {

                    continuar++;

                }
            }
            while (continuar > 0);


            Random random = new Random();
            int[] matriz = new int[100];

            for (int i = 0; i < matriz.Length; i++)
            {

                matriz[i] = random.Next(10, 100);

            }

            for (int i = 0; i < matriz.Length; i++)
            {

                for (int j = 0; j < matriz.Length - 1; j++)
                {

                    if (matriz[j] > matriz[j + 1])
                    {

                        int aux = matriz[j];
                        matriz[j] = matriz[j + 1];
                        matriz[j + 1] = aux;

                    }

                }

            }
            
            for (int i = 0; i < matriz.Length; i++)
            {

                Console.Write(matriz[i] + " ");

            }

            Console.ReadLine();

        }
    }
}
