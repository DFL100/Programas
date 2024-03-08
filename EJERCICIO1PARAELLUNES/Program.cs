using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EJERCICIO1PALLUNES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            do
            {

                Console.WriteLine("A que ejercicio quiere ir?");
                ejercicio = Convert.ToInt32(Console.ReadLine());

            }
            while (ejercicio > 1);
            switch(ejercicio)
            {
                case 1:

                    Random random1a = new Random();

                    //Creamos la lista
                    List<int> Lista = new List<int>(20);

                    //Insertamos los valores
                    for (int i = 0; i < 20; i++)
                    {
                        Lista.Add(random1a.Next(1, 26));
                    }

                    //Enseño los valores
                    Console.WriteLine("Los valores de la lista son:");
                    foreach (int i in Lista)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();


                    //Apartado1
                    Console.WriteLine("APARTADO1");

                    if (Lista.Contains(2))
                    {
                        Console.WriteLine("El número 2 está en la lista:");
                        foreach (int i in Lista)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay ningún 2 en la lista.");
                    }

                    //Apartado2
                    Console.WriteLine("APARTADO2");

                    int suma1a = 0;

                    foreach (int valor in Lista)
                    {
                        suma1a += valor;
                    }

                    Console.WriteLine("La suma de los valores generados es: " + suma1a);


                    //Apartado3
                    Console.WriteLine("APARTADO3");

                    int suma = 0;

                    foreach (int valor in Lista)
                    {
                        suma += valor;
                    }

                    double media = (double)suma / Lista.Count;

                    Console.WriteLine("La media de los valores generados es: " + media);

                    //Apartado4
                    Console.WriteLine("APARTADO4");

                    int conteoSuperioresA20 = 0;

                    foreach (int valor in Lista)
                    {
                        if (valor > 20)
                        {
                            conteoSuperioresA20++;
                        }
                    }

                    double porcentaje = (double)conteoSuperioresA20 / Lista.Count * 100;

                    Console.WriteLine("El porcentaje de números superiores a 20 en la lista es: " + porcentaje.ToString("0.00") + "%");

                    //APARTADO5
                    Console.WriteLine("APARTADO5");

                    HashSet<int> valoresUnicos = new HashSet<int>(Lista);

                    Console.WriteLine("Valores únicos en la lista:");
                    foreach (int valor in valoresUnicos)
                    {
                        Console.Write(valor + " ");
                    }
                    Console.WriteLine();


                    break;
            }
            Console.ReadLine();

        }
    }
}
