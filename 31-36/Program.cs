using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            do
            {
                Console.WriteLine("Escoja un ejercicio entre el 31 y el 36:");
                int ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {

                    case 31:

                        Random random = new Random();

                        Console.WriteLine("Digame cuantos recuadros de espacio quiere que tenga la array");
                        int recuadros = int.Parse(Console.ReadLine());

                        int[] a = new int[recuadros];

                        Console.WriteLine("a)");

                        for (int i = 5; i <= recuadros - 5; i++)
                        {

                            a[i] = random.Next(-2000, 0);
                            Console.WriteLine("Recuadro " + i + " tiene el valor "+ a[i]);
                        }
                        Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine("b)");

                        for (int i = 0; i <= 5; i++)
                        {
                            a[i] = random.Next(0, 10000);
                            Console.WriteLine("El " + i + "º es " + a[i]);
                        }

                        for (int i = a.Length - 5; i <= a.Length -1; i++)
                        {
                            a[i] = random.Next(0, 10000);
                            Console.WriteLine("El " + i + "º es " + a[i]);
                        }

                        Console.ReadLine();
                        Console.WriteLine("c)");
                        Console.WriteLine("Digame un número para las posiciones que no sean ni las 5 primeras ni las 5 últimas:");
                        int NuevoNumero = int.Parse(Console.ReadLine());

                        for (int i = 5; i < a.Length -5; i++)
                        {

                            a[i] = NuevoNumero;
                            Console.WriteLine("La posición " + i + " de la array tiene el nuevo valor de " + NuevoNumero); 

                        }
                        Console.ReadLine();

                        Console.WriteLine("d)");
                        Console.WriteLine("La primera posición tiene el valor de " + a[0]);
                        Console.WriteLine("La última posición de la array tiene el valor de " + a{ a.Length - 1});
                        Console.ReadLine();

                        Console.WriteLine("e)");
                        int[] b = new int[recuadros];
                        for (int i = 0; i <= a.Length -1; i++)
                        {
                            b[i] = a[i];
                            Console.WriteLine("Los nuevos valores de la array b son " + b[i]);
                        }
                        Console.ReadLine();

                        Console.WriteLine("f)");

                        for (int i = 0; i < b.Length - 1; i++)
                        {

                            if (b[i] < b[i +1])
                            {

                                int qwerty = b[i + 1];
                                
                                b[i + 1] = b[i];
                                b[i] = qwerty;

                            }

                            Console.Write(a[i] + " ");
                        }
                        Console.ReadLine();

                        Console.WriteLine("g)");
                        int contador = 0;
                        for (int i = 0; i <= 10; i++)
                        {

                            contador += a[i];
                            contador += b[i];

                        }

                        Console.WriteLine("La suma de los diez primeros números de la array da " + contador);
                        Console.ReadLine();

                        Console.WriteLine("h)");

                        for (int i = 0; i < b.Length - 1; i++)
                        {

                            b[i] += 10;
                            Console.WriteLine("El nuevo valor de b tras sumarle 10 a todas sus posiciones es de " + b[i] + " en la posición " + i);
                        }
                        Console.ReadLine();

                        Console.WriteLine("i)");

                        int media = 0;
                        int media2 = 0;
                        int cantidad = 0;
                        int cantidad2 = 0;
                        int suma = 0;
                        int suma2 = 0;
                        for (int i = 0; i < a.Length - 1; i++)
                        {

                            suma += a[i];
                            cantidad++;

                        }

                        for (int i = 0; i < b.Length - 1; i++)
                        {

                            suma2 += b[i];
                            cantidad2++;

                        }

                        media = suma / cantidad;
                        media2 = suma2 / cantidad2;

                        for (int i = 0; i < a.Length - 1; i++)
                        {

                            if (a[i] < media || b[i] < media2)
                            {

                                a[i] = 0;
                                b[i] = 0;

                            }
                            Console.WriteLine("el nuevo valor de la array a es " + a[i] + " y el de b es " + b[i] );
                        }
                        Console.ReadLine();

                        Console.WriteLine("j)");

                        Console.WriteLine("Busque un valor en la array:");
                        int numero13 = int.Parse( Console.ReadLine() );
                        for (int i = 0; i < b.Length - 1; i++)
                        {

                            if (a[i] == numero13)
                            {

                                Console.WriteLine("El apartado " + i + " de la array a tiene el valor " + a[i] );

                            }

                            if(b[i] == numero13)
                            {

                                Console.WriteLine("El apartado " + i + " de la array b tiene el valor " + b[i]);

                            }

                        }
                        Console.ReadLine();

                        break;

                    case 2:

                        Console.WriteLine("Digame cuantos espacios quieres que tenga la array");
                        int n = int.Parse(Console.ReadLine());

                        int[] n2 = new int[n];
                        Random random2 = new Random();

                        for (int i = 0; i < n2.Length; i++)
                        {

                            n2[i] = random2.Next(0, 11);
                            Console.WriteLine("El valor " + i + " de la nueva array llamada n2 tiene el valor de " + n2[i]);

                        }
                        Console.ReadLine();

                        break;

                }

            }
            while (ejercicio < 36 || ejercicio > 31);

        }
    }
}
