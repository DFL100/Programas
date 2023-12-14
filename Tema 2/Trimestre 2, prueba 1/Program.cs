using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestre_2__prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio1
            //De forma manual

            int[] Notas = new int[32];

            Console.WriteLine("Primero de forma manual");
            Console.ReadLine();

            Console.WriteLine("Inserte la primera nota: ");
            Notas[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la segunda nota: ");
            Notas[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la tercera nota: ");
            Notas[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la cuarta nota: ");
            Notas[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la quinta nota: ");
            Notas[5] = int.Parse(Console.ReadLine());

            Console.Write( Notas [1]+ " " + Notas [2]+ " " + Notas [3] + " " + Notas [4]+ " " + Notas[5] + " ");
            Console.WriteLine();
            int media1 = (Notas[1] + Notas[2] + Notas[3] + Notas[4] + Notas[5]) / 5;
            Console.WriteLine("La media general es de " + media1);
            Console.ReadLine();

            //De forma automática

            int[] Notas2 = new int[32];

            Console.WriteLine("Ahora de forma automática");
            Console.ReadLine();

            for ( int i = 0; i <=5; i++) 
            {

                Console.WriteLine("Inserte la nota " + i + ": ");
                Notas2[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();


            for ( int z = 0; z <= 5;  z++) 
            {

                Console.WriteLine("La nota " + z + " es " + Notas2[z]);
                
            
            }
            Console.WriteLine();

            for (int y = 0; y <= 5;y++) 
            {
                int media2 = (Notas2[1] + Notas2[2] + Notas2[3] + Notas2[4] + Notas2[5]) / 5;

                Console.WriteLine("La media de todas las notas es " + media2 );
            
            }
            
            Console.ReadLine();
            

        }
    }
}
