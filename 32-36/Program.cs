using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _32_36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Que ejercicio quiere hacer del 31 al 36?");
            int ejercicio = int.Parse(Console.ReadLine());

            int media = 0;
            int suma = 0;
            int contador = 0;
            switch (ejercicio)
            {

                case 32:
                    Console.WriteLine("Cuantos valores quieres que tenga la array?");
                    int a1 = int.Parse(Console.ReadLine());
                    int[] a = new int[a1];
                    int[] b = new int[a1];

                    Random random = new Random();

                    for (int i = 0; i < a.Length; i++)
                    {

                        a[i] = random.Next(0, 11);
                        b[i] = a[i];
                        Console.WriteLine("el valor " + i + " de a y b es " + a[i]);

                    }



                    for (int i = 0; i < b.Length; i++)
                    {

                        suma += a[i];
                        contador++;

                    }
                    media = suma / contador;
                    Console.WriteLine("La media es de " + media);

                    int contador2 = 0;
                    for (int i = 0; i < a.Length; i++)
                    {

                        if (a[i] > media)
                        {

                            contador2++;

                        }

                    }
                    Console.WriteLine("Hay " + contador2 + " números por encima de la media");

                    //if (media < 5 && media = 4)
                    {
                        Console.WriteLine("SUSPENDISTE MALO");
                    }

                    if (media <= 5 && media > 7)
                    {
                        Console.WriteLine("Aprobado");
                    }

                    if (media < 7 && media > 9)
                    {
                        Console.WriteLine("Notable");
                    }

                    if (media < 9 && media > 10)
                    {
                        Console.WriteLine("sobresaliente");
                    }

                    if (media < 4) 
                    {
                        Console.WriteLine("Error");
                    }

                    Console.ReadLine();
                    break;

                case 33:

                    Console.WriteLine("Digame el valor de la array n");
                    int n1 = int.Parse(Console.ReadLine());
                    double[] n = new double[n1];
                    double n2 = 0;
                    double suma2 = 0;
                    Random random2 = new Random();

                    for (int i = 0; i < n.Length; i++)
                    {
                        n[i] = random2.Next(0, 11);
                        Console.WriteLine("La desviación es de " + (n[i] - media));
                        n2 = n[i] - media;
                        suma2++;

                    }
                    Console.ReadLine();

                    double desviación = 0;
                    for (int i = 0; i < n.Length; i++)
                    {

                        Console.WriteLine("La media es de " + (n[i] / suma2) * 100);
                        desviación = Math.Abs(n[i] / suma2);

                    }

                    Console.ReadLine();

                    break;
                case 34:

                    int z1 = 0;
                    double[] z = new double[5];

                    for (int i = 0; i < z.Length; i++)
                    {

                        Console.WriteLine("Dime el valor del" + i + "º recuadro de la array");
                        z1 = int.Parse(Console.ReadLine());
                        z[i] = z1;

                    }

                    double[] z50 = new double[5];
                    for (int i = 0; i < z.Length; i++)
                    {

                        z50[i] = z[i] + 10;
                        Console.WriteLine("El valor de la segunda variable + 10 es " + z50[i]);

                    }
                    Console.ReadLine();

                    break;
                case 35:

                    Console.WriteLine("Digame que número de valores quiere tener en su variable ");
                    int x2 = int.Parse(Console.ReadLine());
                    int[] x = new int[x2];
                    int suma50 = 0;
                    Random random50 = new Random();

                    for (int i = 0; i < x.Length; i++)
                    {

                        x[i] = random50.Next(0, 11);
                        Console.WriteLine("El " + i + "º valor elevado al cuadrado de la array es " + Math.Sqrt(x[i]));

                    }
                    Console.ReadLine();

                    for (int i = 0; i < x.Length; i++)
                    {

                        x[i] = random50.Next(0, 11);
                        Console.WriteLine("Laraíz del " + i + "º valor elevado al cuadrado de la array es " + (Math.Sqrt(x[i])));

                    }
                    break;
                case 36:

                    int[] a100 = new int[10000];
                    Random random100 = new Random();

                    for (int i = 0; i <= a100.Length - 1; i++)
                    {

                        a100[i] = random100.Next(-10, 11);
                        Console.WriteLine("El valor " + i + " es " + a100[i]);

                    }

                    for (int i = 0; i <= a100.Length -1; i++)
                    {

                        if (a100[i] < 0)
                        {

                            Console.WriteLine("El primer valor negativo es " + a100[i] + " en la posición " + i);
                            break;

                        }
                    }

                    Console.ReadLine();

                    break;

                case 38:

                    int[] nombre1 = new int[100];


                    break;
                case 45:

                    //int[,] a45 = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 } };
                    int meses = 12;
                    int dias = 30;
                    int[,] a45 = { { meses }, { dias } };
                    int contador45 = 0;
                    int contador245 = 0;

                    Random temperatura = new Random();
                     for (int i = 0; i < a45.GetLength(0) ; i++)
                    {
                     //a45[i,] += 1;

                        for (int j = 0; j < a45.GetLength(1) ; j++)
                        {
                            //a45[,j] += 1;
                            a45[i, j] = temperatura.Next(-20, 40);
                            Console.WriteLine(a45[i, j] + " ");
                            contador45 = contador45 +a45[i, j];
                            contador245 = contador245 + 1;
                        }

                    }
                   

                    Console.WriteLine("La media de temperatura es de " + contador45 / contador245 + "º");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
