using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A que programa quiere ir?");
            int ejercicios = int.Parse(Console.ReadLine());

            if (ejercicios == 1) //Creación de arrays con números random
            {

                Console.WriteLine("Aquí vamos a crear unas arrays(métodos)");
                Console.ReadLine();
                Console.WriteLine("Cuantas celdas queres que tenga el array?");
                int b1 = int.Parse(Console.ReadLine());
                int[] a1 = new int[b1];  

                for (int i = 0; i < a1.Length; i++)
                {
                    Random random = new Random();
                    a1[i] = random.Next();

                    Console.Write(a1[i] + " ");
                }

            }

            if (ejercicios == 2)
            {

                Console.WriteLine("Ahora vamos a crear una array con el tamaño que me digas y solo le daremos valor aleatorio (del 1 al 10) a las celdas impares");
                Console.ReadLine();
                Console.WriteLine("De que tamaño quieres que sea el array?");
                int b2 = int.Parse(Console.ReadLine());
                int[] a2 = new int[b2];

                for (int i = 0; i > a2.Length; i++)
                {

                    Random random = new Random();
                    a2[i] = random.Next(1, 11);



                    Console.Write(a2[i] + ", ");

                }

            }
            Console.ReadLine();

            
        }
    }
}
