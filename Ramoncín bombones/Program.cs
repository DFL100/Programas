using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_bombones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcuar la raín cuadrada
            float raiz = (float)Math.Sqrt(numero);
            //Calcular una potencia
            int x = 9;
            int y = 4;
            //calcular la raíz
            
            //x elevado a y
            long potencia = (long)Math.Pow(x, y);

            //redondeo de valores
            float valor = 4.6f;

            float valorintmenor = (float)Math.Floor(valor);
            Console.WriteLine(valor + " redondeado " + valorintmenor);

            float valorintmayor = (float)Math.Ceiling(valor);
            Console.WriteLine(valor + " redondeado up " + valorintmayor);

            float valorcercano = (float)Math.Round(valor);
            Console.WriteLine(valor + " redondeo cercano " + valorcercano);

            //Ajuste números decimales

            float valor2 = 4.67890f;
            Console.WriteLine(Math.Round(valor2));
            float valorredondeado = (float)Math.Round((valor2, 3));
            Console.WriteLine("Valor2 " + valor2);
            Console.WriteLine("valorredondeado " + valorredondeado);
            Console.ReadLine();


        }
    }
}
