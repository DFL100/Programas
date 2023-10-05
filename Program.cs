using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Registramos el espacio
            double espacio;
            Console.WriteLine("Dime un espacio en metros: ");
            espacio = Convert.ToDouble(Console.ReadLine());

            //Registramos el tiempo
            double tiempo;
            Console.WriteLine("Dime cuanto tiempo en segundos: ");
            tiempo = Convert.ToDouble(Console.ReadLine());

            //Calcular la velocidad
            double velocidad;
            velocidad = espacio / tiempo;
            Console.WriteLine("La velocidad es de " + velocidad + " metros/segundos");
            Console.ReadLine();

        }
    }
}
