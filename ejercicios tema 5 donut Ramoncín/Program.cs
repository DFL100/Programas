using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_tema_5_donut_Ramoncín
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio;
            Console.WriteLine("Escoge a que ejercicio queres ir (del 1 al 25)");
            ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 4)
            {

                char apartado;
                Console.WriteLine("quiere ir al apartado: a), b), c) ");
                apartado = char.Parse(Console.ReadLine());

                if (apartado == 'a')
                {
                    Console.WriteLine("a) "); // i siempre es cero por lo que solo d cero
                    int x = 0, i = 0;
                    while (i > 20)
                    {

                        if (i % 5 == 0)
                        {

                            x += i;

                        }

                    }
                    Console.WriteLine(x);
                    Console.ReadLine();
                }

                if (apartado == 'b')
                {
                    Console.WriteLine("b) "); //Da un bucle infinito

                    bool x4 = true;
                    while (x4)
                    {

                        Console.WriteLine("!");

                    }
                    Console.ReadLine();
                }

                if (apartado == 'c')
                {
                    Console.WriteLine("c) ");
                    int x44 = 100, i4 = 0, s = 0;
                    while (i4 < x44) ;
                    {

                        s += 1;
                        i4 *= 2;

                    }
                    Console.WriteLine(s);
                    Console.ReadLine();
                }

            }

        }
    }
}
