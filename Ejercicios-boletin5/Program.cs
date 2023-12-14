using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char continuar;
            do {

                /*while (i <= 150)
                {

                    Console.WriteLine(i + " ");
                    //sumandole 1a la "i"
                    i++; //lo mismo que escribir => "i = i +1;"

                }*/

                int ejercicio;
                ejercicio = 0;
                Console.WriteLine("Elije entre el ejercicio 5 y el 12");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio == 5)
                {
                    int i1 = 160;

                    while (i1 <= 320)
                    {

                        Console.WriteLine(i1 + " ");
                        //sumandole 1a la "i1"
                        //i1++; //lo mismo que escribir => "i1 = i +1;"
                        i1 = i1 + 20;

                    }
                    Console.ReadLine();
                    

                }

                if (ejercicio == 6)
                {

                    for (int i2 = 0; i2 <=100; i2++) 
                    {

                        if (i2 % 5 == 0 && i2 % 7 == 0) 
                        {
                        
                            Console.WriteLine("Los multiplos de 5 y 7 del 1 al 100 son " + i2);
                            Console.ReadLine() ;
                        
                        }
                    
                    }

                }// Llave ejercicio 6

                if (ejercicio == 7) 
                {

                    int i3 = 0;
                    Console.WriteLine("Digame un núnero para enseñate su taba de multiplicar:");
                    i3 = int.Parse(Console.ReadLine());

                    int i4 = 2;
                    int i5 = 0;

                    for (; i4 <= 10; i4++) 
                    {

                        i5 = i3 * i4;
                        Console.WriteLine(i5);

                    }
                
                }// Llave ejercicio 7

                if (ejercicio == 8) 
                {

                    int i6 = 0;
                    Console.WriteLine("Digame un núnero para enseñate su taba de multiplicar:");
                    i6 = int.Parse(Console.ReadLine());

                    int i7 = 2;
                    int i6 = 0;

                    for (; i7 <= 10; i7++)
                    {

                        i5 = i6 * i7;
                        Console.WriteLine(i5);

                    }

                }

                Console.WriteLine("desea continuar ? s/n");
                continuar = Convert.ToChar(Console.ReadLine());
            }
            while (continuar == 's');
    }   }
}
