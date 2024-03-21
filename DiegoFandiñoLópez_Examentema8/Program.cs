using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiegoFandiñoLópez_Examentema8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            Console.WriteLine("Ejercicio");
            ejercicio = int.Parse(Console.ReadLine());

            List<int> lista1 = new List<int>(20);
            List<int> lista2 = new List<int>();

            switch (ejercicio)
            {
                case 1:

                    //Crea una lista en la que se puedan guardar números enteros.
                    //Diego Fandiño López

                    Console.WriteLine("Introduzca un´número entero a la lista");
                    int nuevovalor = int.Parse(Console.ReadLine());
                    
                    lista1.Add(nuevovalor);
                    lista1.Add(0);

                    Console.WriteLine("La lista con el valor es:");
                    foreach(int i in lista1)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    break;

                case 2:

                    // Guarda 20 números generados aleatoriamente dentro del rango [-10,10]
                    //Diego Fandiño López

                    Random random = new Random();

                    for(int i = 0; i == 19; i++)
                    {
                        //lista1[i] = lista1.Add(random.Next(-10, 11));
                    }

                    foreach (int i in lista1)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();

                    break;

                case 3:
                    //Obtén la capacidad de la lista y cuantas posiciones quedarían por llenar.
                    //Diego Fandiño López

                    Console.WriteLine(lista1.Capacity);
                    Console.ReadLine();

                    int contador = 0;

                    foreach (int i in lista1)
                    {
                        if (lista1[i] == null )
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine(contador);

                    break;

                case 4:

                    //Obtén la posición del primer cero , en caso de que no haya mostrar mensaje por pantalla.
                    //Diego Fandiño López
                    int cero = 0;

                    if (lista1.IndexOf(cero, false))
                    {
                        Console.WriteLine("El primer cero está en la posición: " + lista1);
                    }
                    else
                    {
                        Console.WriteLine("No hay ceros");
                    }
                    Console.ReadLine();
                    
                        
                    


                    break;

                case 5:
                    //Ajusta la capacidad de la lista  al número de elementos que contiene.
                    Console.WriteLine(lista1.Capacity);
                    Console.ReadLine();


                    break;

                case 6:
                    //Añade un número superior a 10 en la posición 2 de la lista.
                    //Diego Fandiño López
                    lista1[2] = lista1.Add(15);

                    break;



                case 7:
                    //Elimina el elemento situado en la posición 5
                    //Diego Fandiño López
                    lista1.Remove(lista1[5]);

                    break;

                case 8:
                    //Elimina el primer número 3 que haya en la lista.
                    //Diego Fandiño López
                    lista1.Remove(lista1.IndexOf(3));


                    break;

                case 9:
                    //Crea otra lista en la que se guardarán todos los elementos de la primera.
                    //Diego Fandiño López
                    
                    foreach(int i in lista2)
                    {
                        lista2.Add(lista1[i]);
                    }

                    
                    break;

                case 10:
                    //Crea otra lista en la que se guardarán sólo los valores negativos almacenados en la primera lista.
                    //Diego Fandiño López
                    List<int> lista3 = new List<int>();
                    foreach (int i in lista2)
                    {
                        if (lista2[i] > 0)
                        {
                            lista3.Add(lista2[i]);
                        }

                        
                    }

                    break;

                case 11:
                    //Muestra todos los valores sin duplicados.
                    //Diego Fandiño López

                    HashSet<int> set = new HashSet<int>();
                    foreach (int i in lista3)
                    {
                        set.Add(lista3[i]);
                        Console.WriteLine(set[i]);
                    }

                    break;
            }

        }
    }
}
