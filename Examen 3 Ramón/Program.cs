using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3_Ramón
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            Console.WriteLine("A que ejercicio quiere ir? 1, 2, 3, 4");
            ejercicio = int.Parse(Console.ReadLine());
            

            do
            {

                int x = 12;
                int y = 100;
                while (x < 53) 
                {

                    Console.Write(x + ", ");
                    x = x + 10;
                
                }

                while ( y < 20) 
                {

                    Console.Write(y + ", ");
                    y = y - 20;
                
                }
                Console.ReadLine();
                break;

            } while (ejercicio == 1);
            

            do 
            {

                int n = 0;
                int m = 0;
                int contador1 = 0;

                Console.WriteLine("Que número le quiere asignar a n?");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Que número mayor que n le quiere asignar a m?");
                m = int.Parse(Console.ReadLine());

                for (int i = contador1; contador1 <= 10; n++) 
                {

                    while (n % 2 != 0 && n % 7 == 0)

                        Console.WriteLine(n + " es el " + contador1 + " múltiplo de 7 impar");

                    contador1++;
                
                }
                Console.ReadLine();
            
            }while(ejercicio == 2);

            do 
            {

                Console.WriteLine("Vamos a hacer la siguiente suma: 1 + i / (i(3) + 1)");

            
            }while (ejercicio == 3);

            do 
            { 
            
            
            
            } while (ejercicio == 4);

        }
    }
}
