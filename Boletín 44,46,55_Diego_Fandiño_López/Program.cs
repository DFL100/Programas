using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletín_44_46_55_Diego_Fandiño_López
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;
          //do
            {

                Console.WriteLine("Escoja un ejercicio entre 44,46 y 55:");
                ejercicio = int.Parse(Console.ReadLine());

            }
            // while (ejercicio != 44 || ejercicio != 45 || ejercicio != 55);

            switch (ejercicio)
            {

                case 44:
                    //a
                    int[,] array44 = new int[3, 3];
                    int b44 = 0;
                    do
                    {
                        Console.WriteLine("Escoja una de las tres filas de la array");
                        b44 = int.Parse(Console.ReadLine());
                    }
                    while (b44 < 0 || b44 > 2);

                    for (int i = 0; i < array44.GetLength(1); i++)
                    {

                        Console.WriteLine(array44[b44, i]);

                    }
                    Console.ReadLine();

                    //añadir valores

                    Random random = new Random();

                    for (int i = 0; i < array44.GetLength(0); i++)
                    {

                        for (int j = 0; j < array44.GetLength(1);)
                        {

                            array44[i, j] = random.Next(1, 11);

                        }

                    }

                    //b

                    for (int i = 0; i < array44.GetLength(0); i++)
                    {

                        array44[i, 3] = 0;
                        array44[3, i] = 0;

                    }

                    //c

                    int suma441 = 0;

                    for (int i = 0; i < array44.GetLength(0); i++)
                    {

                        suma441 += array44[0, i];

                    }

                    //d 

                    for (int i = 0; i < array44.GetLength(0); i++)
                    {
                        if (array44[0, i] == 0)
                        {

                            suma441 += array44[0, i];

                        }


                    }

                    //e

                    suma441 = 0;
                    int contador = 0;

                    for (int i = 0; i < array44.GetLength(0); i++)
                    {

                        for (int j = 0; j < array44.GetLength(1); j++)
                        {

                            suma441 += array44[i, j];
                            contador++;

                        }

                    }
                    int media = suma441 / contador;
                    Console.WriteLine("La media es de " + media);

                    Console.ReadLine();

                    break;

                case 46:

                    //a

                    int[,] array46 = new int[3, 3];
                    double contador461 = 0;
                    double contador462 = 0;

                    Random random2 = new Random();

                    for (int i = 0; i < array46.GetLength(0); i++)
                    {

                        for (int j = 0; j < array46.GetLength(1); j++)
                        {

                            array46[i, j] = random2.Next(-10, 11);
                            contador461++;

                            if (array46[i, j] >= 0)
                            {

                                contador462++;

                            }

                        }

                    }
                    Console.WriteLine("El porcentaje de ceros del array es de " + (contador462 / contador461) * 100 + "%");
                    Console.ReadLine();

                    //b 

                    bool simetrico1 = false;

                    for (int i = 0; i < array46.GetLength(0); i++)
                    {

                        if (array46[i, i] == i)
                        {

                            simetrico1 = true;

                        }

                    }

                    if (simetrico1)
                    {

                        Console.WriteLine("El array es simetrico");

                    }

                    if (!simetrico1)
                    {

                        Console.WriteLine("No es simetrico");

                    }

                    //c

                    int suma33 = 0;

                    for (int i = 0; i < array46.GetLength(0); i++)
                    {

                        suma33 += array46[i, 0];

                    }

                    Console.WriteLine("La suma dela primera fila del array es de " + suma33);

                    //d

                    int suma34 = 0;

                    for (int i = 0; i < array46.GetLength(1); i++)
                    {

                        suma34 += array46[2, i];

                    }

                    Console.WriteLine("La suma de la ultima columna es de " + suma34);

                    break;

                case 55:





                    int[,] matriz = new int[5, 5];
                    int vidas = 6;

                    // Completar el array con números aleatorios, excepto en 3 sitios que se llenan con el número 0
                    Random random9 = new Random();
                    for (int i = 0; i < 3; i++)
                    {
                        int fila = random9.Next(0, 5);
                        int columna = random9.Next(0, 5);
                        matriz[fila, columna] = 0;
                    }

                    while (vidas > 0)
                    {
                        // Imprimir la matriz
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(matriz[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.Write("Introduce la fila ( entre el 0-4 ): ");
                        int fila;

                        //El "out" sirve para devolver un valor entero junto con uno booleano (true o false)
                        //El int.tryParse sirve para intentar convertir la cadena en un numero de tipo int
                        bool filaValida = int.TryParse(Console.ReadLine(), out fila);

                        Console.Write("Introduce la columna ( entre el 0-4 ): ");
                        int columna;
                        bool columnaValida = int.TryParse(Console.ReadLine(), out columna);

                        if (filaValida && columnaValida)
                        {
                            if (0 <= fila && fila < 5 && 0 <= columna && columna < 5)
                            {
                                if (matriz[fila, columna] == 0)
                                {
                                    Console.WriteLine("¡Correcto! Has dado en el blanco.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrecto. Pierdes una vida.");
                                    vidas--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Coordenadas incorrecta. Pierdes una vida malo :)");
                                vidas--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor, Introduce una coordenada dentro del margen amigo.");
                        }
                    }

                    if (vidas == 0)
                    {
                        Console.WriteLine("Te quedaste sin vidas crack");
                    }

                    /*a55[0,i] = Valores.Next(0, 1);
                      a55[1, i] = Valores.Next(0, 1);
                      a55[2, i] = Valores.Next(0, 1);
                      a55[3, i] = Valores.Next(0, 1);
                      a55[4, i] = Valores.Next(0, 1);*/

                    /*if (lol == 0)
                    {

                        for (int i = 0; i < a55.GetLength(0); i++)
                        {

                            Console.Write(a55[i, lol]);
                                
                        }
                        lol++;

                    }*/

                    /*for (int i = 0; i < a55.GetLength(0); i++)
                    {

                        Console.Write(a55[0, i]);
                        Console.WriteLine(" ");
                        Console.Write(a55[1, i]);
                        Console.WriteLine(" ");
                        Console.Write(a55[2, i]);
                        Console.WriteLine(" ");
                        Console.Write(a55[3, i]);
                        Console.WriteLine(" ");
                        Console.Write(a55[4, i]);
                        if (i < a55.GetLength(1))
                          {
                              Console.WriteLine(a55[lol, i] = Valores.Next(0, 1));
                          }
                    }*/
                    break;

                default:

                    Console.WriteLine("No puedes llegar aquí :)");    

                    break;

            }
            Console.ReadLine();
        }
    }
}
