using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double presión;
            Console.WriteLine("Dígame un número para la presión: ");
            presión = double.Parse(Console.ReadLine());

            double volumen;
            Console.WriteLine("Dígame un número para el volumen: ");
            volumen = double.Parse(Console.ReadLine());

            double n;
            Console.WriteLine("Dígame un número número de moles: ");
            n = double.Parse(Console.ReadLine());

            double R;
            R = 0.082;

            double T;
            Console.WriteLine("Dígame un número para la temperatura kelvin; ");
            T = double.Parse(Console.ReadLine());

            double goat_CR7;
            goat_CR7 = presión * volumen;
            double goat_Messi;
            goat_Messi = n * R * T;
            double Madrid;
            Madrid = (goat_CR7 = goat_Messi);
            Console.WriteLine("La formula de los gases ideales segun sus números es de " + Madrid);
            Console.ReadLine();

        }
    }
}
