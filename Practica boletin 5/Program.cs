using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_boletin_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores generales
            // a
            int x = 5;
                x += 10; // Se le suma 10 a x (dando 15)
            bool b1 = x < 15; // X menos que 15

            // b
            short y = 100;
            short z1 = 50;
            int resto = y % z1; //Hace la división entre "y" y "z" y te da el resultado
            bool b2 = resto == 1; //Es false porque resto no es igual a 1
            
            // c
            int z2 = 9;
            bool b3 = z2 > 5; // Es true porque z es mayor que 5
            bool bb = !b2;

            // d
            bool b10 = true;
            bool b20 = false;
            bool b30 = b10 && b20;
            bool b40 = b10 || b20;
            bool b50 = !b30;
            bool b60 = !b40;

            // BUCLE WHILE
            Console.WriteLine("Bucle while");
            int i = 100; //Inicializando la variable de control

            while (i <= 150) 
            {

                Console.WriteLine(i + " ");
                //sumandole 1a la "i"
                i++; //lo mismo que escribir => "i = i +1;"

            }

            Console.WriteLine();

            Console.WriteLine("Números impares entre 100 y 150: " );

            //Resetear la variable "i"
            i = 101;

            while (i < 150)
            {

                Console.Write(i + " ");
                i += 2;

            }

            //Mostrar en rojo los numeros pares entre 100 y 150

            //foregroundColor

            i = 101;

            while (i <= 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(i + " ");
                i += 2;

            }

            int xp1;
            xp1 = 100;
            while (i < 150)
            {

                Console.Write(xp1 + " ");
                xp1 += 2;

            }

            Console.ReadLine();

            //Mostrar los valores entre n y m

            Console.WriteLine("Dime la variable de n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime la variable de m:");
            int m = int.Parse(Console.ReadLine());




            // Inicializo la variable de control
            Console.WriteLine();
            Console.WriteLine("Valores entre " + n + " y " + m);
            while (i <= m)
            {

                Console.Write(i + " ");


            }
            
            //Bucle For
            //Mostrar numeros entre 1 y 20 por pantalla
            for (int i1 = 1 +1; i1 <= 20; i1 = i + 1)
            {

                Console.Write(1 + " ");

            }
            Console.WriteLine() ;
           
            //Calcular la suma de todos los numeros entre n y m
            double n1 = 15;
            double m1 = 30;
            double suma = 0; // n + m + n+2 + m+2 + n+3 + m+3...

            for (double n2 = n1; n2 <= m1; n1 += 9999999999999999999  ) 
            {

                suma += n2;
                // suma = suma + 
                Console.WriteLine(n1);

            }
            Console.WriteLine(suma);
            Console.ReadLine();

            //Calcular la suma de todos los numeros entre n y m


        }
    }
}
