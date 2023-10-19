using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            Console.WriteLine("Dime un ejercicio del 4 al 8");
            ejercicio = int.Parse(Console.ReadLine());
            Console.ReadLine();
            {
                if (ejercicio == 4)

                {
                    int nota1;
                    Console.WriteLine("Digame su primera nota del uno al 10:");
                    nota1 = int.Parse(Console.ReadLine());

                    int nota2;
                    Console.WriteLine("Digame su segunda nota del uno al 10:");
                    nota2 = int.Parse(Console.ReadLine());

                    int nota3;
                    Console.WriteLine("Digame su tercera nota del uno al 10:");
                    nota3 = int.Parse(Console.ReadLine());

                    int notafinal = (nota1 + nota2 + nota3) / 3;

                    if (notafinal < 5 ) 
                    {
                        Console.WriteLine("Suspendiste zopenco");
                    }
                    else
                    {
                        Console.WriteLine("Aprobaste crack");
                    }
                    Console.ReadLine();

                }

                if (ejercicio == 5)

                {

                    double numero1;
                    Console.WriteLine("Digame un número");
                    numero1 = double.Parse(Console.ReadLine());

                    double numero2;
                    Console.WriteLine("Digame otro número");
                    numero2 = double.Parse(Console.ReadLine());

                    double sumanúmeros = numero1 + numero2;

                    if (sumanúmeros > 0)

                    {
                        double númeroPositivo = Math.Sqrt(sumanúmeros);
                        Console.WriteLine("Como es positivo su raíz cuadrada es de " + númeroPositivo);

                    }
                    else
                    {

                        Console.WriteLine("Su número es negativo.");
                            
                    }
                    Console.ReadLine ();

                }

                if (ejercicio == 6) 
                {

                    string contraseña1;
                    Console.WriteLine("Escribe una contraseña:");
                    contraseña1 = Console.ReadLine();

                    string contraseña2;
                    Console.WriteLine("Vuelve a escribir la contraseña:");
                    contraseña2 = Console.ReadLine();

                    if (contraseña1 == contraseña2)

                    {

                        Console.WriteLine("Su contraseña es válida");

                    }
                    else 
                    
                    {

                        Console.WriteLine("Sus contraseñas no son similares");
                            
                    }
                    Console.ReadLine();

                }

                if (ejercicio == 7) 
                {

                    int Numero1;
                    Console.WriteLine("Digame un número:");
                    Numero1 = int.Parse(Console.ReadLine());

                    int Numero2;
                    Console.WriteLine("Digame otro número:");
                    Numero2 = int.Parse(Console.ReadLine());

                    if (Numero1 > Numero2)
                    {

                        int Variable1;
                        Variable1 = Math.pow(Numero2, Numero1);
                        Console.WriteLine(Numero2 + " elevado a " + Numero1 + " es igual a " + Variable1);

                    }
                    else if (Numero2 > Numero1) 
                    {

                        int Variable2;
                        Variable2 = Math.pow(Numero1, Numero2);
                        Console.WriteLine(Numero1 + " elevado a " + Numero2 + " es igual a " + Variable2);

                    }
                    Console.ReadLine() ;

                }

                if (ejercicio == 8) 
                {

                    Console.WriteLine("Homer, aqui tienes el programa por gordita:");
                    Console.ReadLine();

                    int presion;
                    Console.WriteLine("Introduce la presión en atm: ");
                    presion = int.Parse(Console.ReadLine());

                    int temperatura;
                    Console.WriteLine("Digame la temperatura en Kelvin: ");
                    temperatura = int.Parse(Console.ReadLine());

                    if (presion > 2 && temperatura > 500)

                    {

                        Console.WriteLine("Abrir válvula de seguridad y reducir la temperatura ");

                    }

                    else if (presion > 2)
                    {

                        Console.WriteLine("Abrir válvula de seguridad");

                    }

                    else if (temperatura > 500)
                    {

                        Console.WriteLine("Reducir la temperatura ");

                    }
                    
                    else
                    {

                        Console.WriteLine("Todo en orden");
                            
                    }

                }
            }

        }
    }
}
