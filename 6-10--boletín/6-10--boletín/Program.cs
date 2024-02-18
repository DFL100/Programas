using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace _6_10__boletín
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio6

             string texto = "abacaba abajo abacate abadía";
             string Buscar = "aba"; 

             //Partir el texto en palabras
             string[] palabras = texto.Split(' ');

             int contar = 0;

             //Contar el número de palabras
             foreach (string palabra in palabras)
             {
                 if (palabra.Contains(Buscar))
                 {
                     contar++;
                 }

             }
            Console.WriteLine("Hay " + contar + " palabras que contienen '" + Buscar + "'");
            Console.ReadLine();

            //Ejercicio7

            string email = "realramonrs@gmail.com";

            string[] partes = email.Split('@');

            //0 es antes del @ y 1 es después
            string dominio = partes[1];

            //Enseñar el dominio
            Console.WriteLine("El dominio del correo electrónico es: " + dominio);
            Console.ReadLine() ;

            //Ejercicio8

            Console.WriteLine("Escribe un texto en formato AA99:");
            string texto8 = Console.ReadLine();

            bool formatoCorrecto = true;

            if (texto8.Length != 4)
            {
                Console.WriteLine("Error: Es muy largo");
                formatoCorrecto = false;
            }

            //Ver si los primeros dos caracteres son letras
            if (!Char.IsLetter(texto8[0]) || !Char.IsLetter(texto8[1]))
            {
                Console.WriteLine("Error: No empezaste por una letra");
                formatoCorrecto = false;
            }

            //Ver si los dos últimos son números
            if (Char.IsLetter(texto8[2]) || Char.IsLetter(texto8[3]))
            {
                Console.WriteLine("Error: Los dos últimos tienen que ser números");
                formatoCorrecto = false;
            }

            //Si todo está bien sale esto
            if (formatoCorrecto == true)
            {
                Console.WriteLine("Lo escribiste bien chaval");
            }
            
            Console.ReadLine();

            //Ejercicio9

            Console.WriteLine("Escribe una frase");
            string cadena = Console.ReadLine();

            //Remplazar los espacios
            string cadenaModificada = cadena.Replace(' ', '*');

            //Enseñar la frase cambiada
            Console.WriteLine("Cadena modificada: " + cadenaModificada);

            Console.ReadLine();

            //Ejercicio10

            string Pedro = "Pedro Jimenez*14Julio1990?2500";
            string Maria = "Maria Benitez*9070!06Agosto1998";

            string salarioPedro1 = Pedro.Substring(Pedro.IndexOf('?') + 1);
            int salarioPedro2 = int.Parse(salarioPedro1);


            //Ver si el salario de Pedro es mayor a 1000
            if (salarioPedro2 > 1000)
            {
                Console.WriteLine("El salario de Pedro es: " + salarioPedro2);
            }
            else
            {
                Console.WriteLine("El salario de Pedro no es mayor a 1000.");
            }

            string salarioMaria1 = Maria.Substring(Maria.IndexOf('o') + 1);
            int salarioMaria2;

            //convertir a un número
            if (int.TryParse(salarioMaria1, out salarioMaria2))
            {
                //Ver si el salario de Maria es más que 1000
                if (salarioMaria2 > 1000)
                {
                    Console.WriteLine("El salario de Maria es: " + salarioMaria2);
                }
                else
                {
                    Console.WriteLine("El salario de Maria no es mayor a 1000.");
                }
            }
            else
            {
                Console.WriteLine("No se pudo obtener el salario de Maria.");
            }

            Console.ReadLine();
        }
    }
}
