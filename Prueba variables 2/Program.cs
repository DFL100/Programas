using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_variables_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Dos tipos de conversión implicitas y explicitas
             * Implicitas: Pasamos un valor de una variable de menor capacidad a otra de mayor capacidad
             */

            byte n1 = 9;
            short n1copia = n1;
            int n1copia2 = n1copia;

            float n2 = 4.5f;
            double n2copia = n2;

            /*
             * Explicitas: Pasamos un valor de una variable de mayor capacidad a otra de menos capacidad
            */

            int numero1 = 2400;
            short numero1copia = (short)numero1;
            short numero1copia2 = Convert.ToInt16(numero1);

            double numero2 = 5.678;
            float numero2copia = (float)numero2;

            /* Son inseguras: Dos tipos de problemas
             *      :( Overflow  :( perdida
            */

            short n3 = 300;
            byte n3copia = (byte)n3;


            //      :( Perdida de precisión

            float r1 = 9.56f;
            int r1Copia = (int)r1;
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r1copia = " r1Copia);

            Console.ReadLine();

        }
    }
}
