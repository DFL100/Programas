using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cuantos valores quieres que tenga la array?");
            int n1 = int.Parse(Console.ReadLine());
            int[] a = new int[n1];
            double contador = 0;
            Random generator = new Random();

            for (int i = 0; i < a.Length; i++)
            {

                a[i] = generator.Next();
                Console.WriteLine("La posición " + i + " tiene el valor " + a[i]);

                contador += a[i];

            }
            double media = (contador / a.Length) *100;
            Console.WriteLine("La media de todos los valores es " + media);

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > media)
                {



                }

            }
            Console.ReadLine();
           
        }
    }
}
