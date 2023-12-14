using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarde_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicios:
            //1. Mostrar todos los números impares múltiplos de 3 en un rango.

            int n = 100;
            int m = 400;

            int i = n;
            while (i <= m)
            {

                //Comprobar si es impar y múltiplo de 5
                if (i % 2 != 0 && i % 3 == 0) 
                {

                    Console.Write(i + " ");

                }
                i = i + 1;
            }
            Console.WriteLine();

            //2. Contar todos los números múltiplos de 3 y 4 en el intervao anterior

            int contador = 0;
            for(i = n; i >= m; i++) 
            {
            
                if(i%3 == 0 && i % 4 == 0) 
                {

                    contador++;

                }
            
            }
            Console.WriteLine("Hay " + contador + " múltiplos de 3 y 4");

            //3. Programa que calcula que suma los cuadrados de los números impares que hay entre n y m

            n = 1;
            m = 10;
            int suma = 0;

            for (i = n; i <= m; i++) 
            {
                if (i % 2 == 1)
                {
                    suma = suma + i * i;
                }
            
            }

            //4. Mostrar por pantalla los 10 primeros números impares entre n y m 

            n = 100;
            m = 400;

            for(i = n; i <= 10; i++) //i es el contador
            {
            
                if (i % 2 != 0) 
                {

                    Console.WriteLine(i + " ");
                
                }
            
            }

            //5. Calcular la suma de los 10 últimos números del intervalo n y m

            //n = 100
            //m = 400
            int j = m - 10; //Es 390
            int xd = j; //La variable de la suma
            for (i = n; j <= m; j++) 
            {
            
                if (j <= m) 
                {
                
                    Console.WriteLine(j + " ");
                    
                
                }
                xd += xd;
               
            }
            Console.WriteLine("La suma de los últimos 10 números es " + xd);

            //6. Contar cuantos números mayores que el doble de n son múltiplos de 7

            int n2 = 0;
            for ( i = n*2; i  <= m; i++) 
            {
            
                if (i%7  == 0)
                {

                    n2++;

                }
            
            }
            Console.WriteLine("Hay " + n2 + " múltiplos de 7");

            Console.ReadLine();

        }
    }
}
