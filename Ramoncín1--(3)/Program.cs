using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín1___3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4:
                //Establece valor de Radio
            double radio;
            Console.WriteLine("Escriba un numero a continuación: ");
            radio = Convert.ToDouble(Console.ReadLine());

            //Calcular el Área del circulo y su volumen
            double PI;
            PI = 3.141516;
            double longitud;
            longitud = radio * 2;
            double area;
            area = PI * (radio * 2);
            double volumen;
            volumen = 4f / 3 * (PI * PI * PI);
            Console.WriteLine("El área del círculo con rádio " + radio + " es " + area + ". Y su volumen es " + volumen );
            Console.ReadLine();
            



        }
    }
}
