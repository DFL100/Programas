using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            char continuar;

            

                Console.WriteLine("Escoje una opción:");
                Console.WriteLine("a ) Saludar");
                Console.WriteLine("b ) Alejar ");
                Console.WriteLine("C ) Despedir");
            opcion = char.Parse(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 'a':
                        Console.WriteLine("Hola!!!");
                        break;

                    case 'b':
                        Console.WriteLine("Que bien!!!");
                        break;

                    default:
                        Console.WriteLine("Te equivocaste :(");
                        break; //Opcional

                }//Llave del switch

                Console.WriteLine("Volvemos al menu? s/n ");
                continuar = Console.ReadKey().KeyChar;



            }
            
            while (continuar == 's');
            
        }

    }

    
}
