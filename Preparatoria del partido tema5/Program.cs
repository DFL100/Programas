using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparatoria_del_partido_tema5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabla de multiplicar del 1: ");
            for(int j = 1; j <= 10; j++) 
            {

                Console.WriteLine("1 * " + j + " = " + 1 * j);
            
            }
            Console.ReadLine();

            for(int j2 = 1; j2 <=10; j2++) 
            {

                Console.WriteLine("2 * " + j2 + " = " + 2 * j2);
            
            }
            Console.ReadLine();


            Console.WriteLine("De que número quiere saber la tabla de multiplicar?");
            int j33 = int.Parse(Console.ReadLine());
            for(int j3 = 1; j3 <=10; j3++)
            {

                Console.WriteLine( j3 +" * " + j33 + " es " + j33 * j3);

            }
            Console.ReadLine();

            Console.WriteLine("Quiere hacer el ejercicio? s/n");
            char x = char.Parse(Console.ReadLine());
            do
            {
                int filas = 8;
                int asteriscos = filas;
                for (int i = 1; i <= filas; i++) //Filas = 8
                {
                    for (int j = 1; j <= asteriscos; j++) //asteriscos = 8
                    {

                        /*Console.Write("* ");
                        if ( j > 8) 
                        {

                            break;
                            
                        }*/

                        
                    }
                    Console.WriteLine();
                    asteriscos--;
                   /* int i4 = i;
                    if (i4 = 8) 
                    {
                        break;
                    }
                   */
                }


            } while (x == 's');









        }
    }
}
