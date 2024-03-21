using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicos_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            Console.WriteLine("Dime un ejercicio del 4 al 23");
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

                    if (notafinal < 5)
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
                    Console.ReadLine();

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

                        Console.WriteLine(Numero2 + " elevado a " + Numero1 + " es igual a " + Math.Pow(Numero2, Numero1));

                    }
                    else if (Numero2 > Numero1)
                    {

                        Console.WriteLine(Numero1 + " elevado a " + Numero2 + " es igual a " + Math.Pow(Numero1, Numero2));

                    }
                    Console.ReadLine();

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
                        Console.ReadLine();
                    }
                }

                else if (ejercicio == 9)
                {

                    int numeroA;
                    Console.WriteLine("Digame un número:");
                    numeroA = int.Parse(Console.ReadLine());

                    if (numeroA % 2 == 0 && numeroA % 3 == 0)
                    {

                        Console.WriteLine("Es múltiplo de 2 y de 3.");

                    }
                    else if (numeroA % 2 == 0)
                    {

                        Console.WriteLine("Este número es múltiplo de 2.");

                    }
                    else if (numeroA % 3 == 0)
                    {

                        Console.WriteLine("Este número es múltiplo de 3.");

                    }
                    else
                    {

                        Console.WriteLine("Este número no es múltiplo de 2 ni de 3.");

                    }

                }


                else if (ejercicio == 10)
                {

                    double precio1;
                    Console.WriteLine("Digame el precio del producto:");
                    precio1 = int.Parse(Console.ReadLine());

                    if (precio1 > 100)
                    {

                        double descuento10;
                        descuento10 = (precio1 / 0.10) - precio1;
                        Console.WriteLine("Su producto al ser menor a 100€ se le plicará un 10% de descuento quedando en " + descuento10);

                    }
                    if (precio1 < 100)
                    {

                        double descuento15;
                        descuento15 = (precio1 / 0.15) - precio1;
                        Console.WriteLine("Su precio al ser superior a 100€ se le aplicará un descuento del 15% quedando en " + descuento15);
                    }
                    Console.ReadLine();
                }
                else if (ejercicio == 11)
                {

                    double nota;
                    Console.WriteLine("Cual es su nota?");
                    nota = double.Parse(Console.ReadLine());

                    if (nota < 0 && nota > 10)
                    {

                        Console.WriteLine("Nota no valida.");

                    }

                    else if (nota < 5 && nota > 0)
                    {

                        Console.WriteLine("Estas suspenso.");

                    }

                    else if (nota == 5)
                    {

                        Console.WriteLine("Aprobado por los pelos de un calvo");

                    }

                    else if (nota < 6.5 && nota > 5)
                    {

                        Console.WriteLine("Aprobado");

                    }

                    else if (nota == 6.5)
                    {

                        Console.WriteLine("Notable");

                    }

                    else if (nota > 6.5 && nota < 8.5)
                    {

                        Console.WriteLine("Notable");

                    }

                    else if (nota == 8.5)
                    {

                        Console.WriteLine("Sobresaliente :)");

                    }

                    else if (nota < 10 && nota > 8.5)
                    {

                        Console.WriteLine("Sobresaliente :)");

                    }
                    Console.ReadLine();
                }
                else if (ejercicio == 12)
                {

                    double numero777;
                    Console.WriteLine("Escriba un número");
                    numero777 = double.Parse(Console.ReadLine());

                    if (numero777 % 4 == 0)
                    {

                        Console.WriteLine("El número " + numero777 + " es múltiplo de 4 por lo que si le sumamos 25 es " + (numero777 + 25));

                    }

                    else if (numero777 % 5 == 0)
                    {

                        Console.WriteLine("El número " + numero777 + " es múltiplo de 5 por lo que se si le sumamos 50 es " + (numero777 + 50));

                    }
                    else
                    {

                        Console.WriteLine("Como el número " + numero777 + " no es ni múltiplo de 4 ni de 5 entonces le sumaremos 100, dando " + (numero777 + 100));

                    }
                    Console.ReadLine();


                }
                else if (ejercicio == 13)
                {

                    double temp;
                    Console.WriteLine("Escribe un número para la temperatura de un objeto:");
                    temp = double.Parse(Console.ReadLine());

                    if (temp < 0)
                    {

                        Console.WriteLine("El material es sólido.");

                    }

                    else if (temp < 100 && temp > 0)
                    {

                        Console.WriteLine("El material es líquido.");

                    }

                    else if (temp < 1000000 && temp > 100)
                    {

                        Console.WriteLine("El material es vapor");

                    }


                    {

                        Console.WriteLine("El material es plasma");

                    }


                }

                else if (ejercicio == 14)
                {
                    Console.WriteLine("Escriba lo que quiere hacer:");
                    Console.WriteLine("a ) Sumar");
                    Console.WriteLine("b ) Restar");
                    Console.WriteLine("c ) Multiplicar");
                    Console.WriteLine("d ) Dividir");
                    Console.WriteLine("e ) Raíz de la suma");
                    char operación1;
                    operación1 = char.Parse(Console.ReadLine());
                    switch (operación1)
                    {

                        case 'a':
                            Console.WriteLine("Escriba un número que quiere sumar:");
                            int numero01 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escriba el otro número");
                            int numero10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La suma de " + numero01 + " y de " + numero10 + " es de " + (numero10 + numero01));
                            Console.ReadLine();
                            break;

                        case 'b':
                            Console.WriteLine("Escriba un número para restar:");
                            int resta01 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escriba el otro número:");
                            int resta10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La resta de " + resta01 + " y de " + resta10 + " es de " + (resta01 - resta10));
                            Console.ReadLine();
                            break;

                        case 'c':
                            Console.WriteLine("Escriba u número para multiplicar:");
                            int multiplicacion01 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe el número por el que lo vas a multiplicar:");
                            int multiplicacion10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La multiplicación de " + multiplicacion01 + " por " + multiplicacion10 + " da el resultado de " + (multiplicacion01 * multiplicacion10));
                            Console.ReadLine();
                            break;

                        case 'd':
                            Console.WriteLine("Escribe un número para dividir:");
                            int division01 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe el número por el que lo vas a dividir:");
                            int division10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La división de " + division01 + " entre " + division10 + " da el resultado de " + (division01 / division10));
                            Console.ReadLine();
                            break;

                        case 'e':
                            Console.WriteLine("Escribe un número para la raíz de una suma:");
                            int raiz01 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe el otro número de la suma para la raíz:");
                            int raiz10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("La raíz de " + (raiz01 + raiz10) + " es " + Math.Sqrt(raiz01 + raiz10));
                            Console.ReadLine();
                            break;

                    }


                }
                else if (ejercicio == 15)
                {

                    Console.WriteLine("Usted cuantos litros de agua gasta al mes?");
                    double litrosagua = int.Parse(Console.ReadLine());

                    if (litrosagua < 50)
                    {

                        Console.WriteLine("Como usted gasta menos de 50 liros de agua solo tendrá que pagar la cuota mínima de 45 euros");
                        Console.ReadLine();
                        Console.WriteLine("Paga 45 euros, RAPIDO!!! >:(");

                    }

                    else if (litrosagua < 200 && litrosagua > 50)
                    {

                        double pago1 = (litrosagua - 50) * 4.75;
                        Console.WriteLine("Usted debe pagar " + pago1 + " euros");
                        Console.ReadLine();

                    }

                    else if (litrosagua > 200)
                    {

                        double pago2 = (litrosagua - 200) * 20 + (150 * 4.75);
                        Console.WriteLine("Su pago es de " + pago2 + " euros por haber superado los 200 litros melón.");
                        Console.ReadLine();
                        Console.WriteLine("Más te vale pagar ehh");
                        Console.ReadLine();

                    }

                }
                else if (ejercicio == 16)
                {

                    Console.WriteLine("Inserte el precio del primer producto:");
                    double producto1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Inserte el precio del segundo producto:");
                    double producto2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Inserte el precio del tercer producto:");
                    double producto3 = double.Parse(Console.ReadLine());

                    double preciosproductos = producto1 + producto2 + producto3;

                    if (preciosproductos < 500.00)
                    {

                        Console.WriteLine("No se aplican descuentos a compras inferiores a 500.00 euros.");
                        Console.WriteLine("La dolorosa es de " + preciosproductos + " euros");
                        Console.ReadLine();

                    }

                    else if (preciosproductos > 500.00 && preciosproductos < 1000.00)
                    {

                        double rebaja1 = preciosproductos - (preciosproductos * 0.03);
                        Console.WriteLine("Se le aplican un 3% de rebajas a las compras de entre 1.000 y 500 euros.");
                        Console.WriteLine("Su dolorosa le va a suponer un gasto de " + rebaja1 + " euros");
                        Console.ReadLine();

                    }

                    else if (preciosproductos > 1000.00 && preciosproductos < 2000.00)
                    {

                        double rebaja2 = preciosproductos - (preciosproductos * 0.05);
                        Console.WriteLine("Se le aplican un 5% de rebajas a las compras de entre 1.000 y 2.000 euros.");
                        Console.WriteLine("Su dolorosa le va a suponer un gasto de " + rebaja2 + " euros");
                        Console.ReadLine();

                    }

                    else if (preciosproductos > 2000.00 && preciosproductos < 3000.00)
                    {

                        double rebaja3 = preciosproductos - (preciosproductos * 0.07);
                        Console.WriteLine("Se le aplican un 7% de rebajas a las compras de entre 1.000 y 2.000 euros.");
                        Console.WriteLine("Su dolorosa le va a suponer un gasto de " + rebaja3 + " euros");
                        Console.ReadLine();

                    }

                    else if (preciosproductos > 1000.00 && preciosproductos < 2000.00)
                    {

                        double rebaja4 = preciosproductos - (preciosproductos * 0.10);
                        Console.WriteLine("Se le aplican un 10% de rebajas a las compras de entre 1.000 y 2.000 euros.");
                        Console.WriteLine("Su dolorosa le va a suponer un gasto de " + rebaja4 + " euros");
                        Console.ReadLine();

                    }

                }
                else if (ejercicio == 17)
                {

                    Console.WriteLine("Inserte el número de horas que trabaja al més:");
                    double horastrabajadas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserte su salario bruto mensual:");
                    double salariobruto = double.Parse(Console.ReadLine());

                    if (horastrabajadas < 38)
                    {

                        Console.WriteLine("Usted cobra " + salariobruto + " por trabajar menos de 38 horas mensuales.");
                        Console.ReadLine();

                    }

                    else
                    {

                        double salariobruto2 = salariobruto + (salariobruto / 2);
                        Console.WriteLine("Usted cobra " + salariobruto2 + " Por trabajar más de 38 horas mensuales.");
                        Console.ReadLine();

                    }

                    if (salariobruto < 300)
                    {

                        Console.WriteLine("Usted no cobrará impuestos por cobrar menos de 300 euros.");
                        Console.ReadLine();

                    }
                    else
                    {

                        double robodesueldo = (salariobruto - (salariobruto * 0.1)) + (salariobruto / 2);
                        Console.WriteLine("A usted le robamos el 10% de su sueldo paa pintar bancos de morado. Quedando en " + robodesueldo);
                        Console.ReadLine();

                    }


                }

                else if (ejercicio == 18)
                {

                    char indicador;
                    char continuar;

                    do
                    {

                        Console.WriteLine("CALOR pulsar 1");
                        Console.WriteLine("TEMPLADO pulsar 2");
                        Console.WriteLine("FRIO pulsar 3");
                        Console.WriteLine("FUERA DE RANGO pulsar 4");
                        indicador = char.Parse(Console.ReadLine());
                        switch (indicador)
                        {
                            case '1':
                                Console.WriteLine("Hola !!!");
                                break;
                            case '2':
                                Console.WriteLine("Vamoooos !!!");
                                break;
                            case '3':
                                Console.WriteLine("Hasta la próxima!!!");
                                break;
                            default:
                                Console.WriteLine("Te has equivocado.");
                                break; //Opcional

                        } // Llave que cierra el switch
                        Console.WriteLine("Quiere volver al menú: s->sí/n->no");
                        continuar = Console.ReadKey().KeyChar;//Para que no espere a que el usuario pulse Enter
                        Console.WriteLine();

                    }
                    while (continuar == 's');
                }
                else if (ejercicio == 19)
                {

                    char color;
                    char continuar;

                    do
                    {

                        Console.WriteLine("ROJO pulsar 'r' o 'R'");
                        Console.WriteLine("VERDE pulsar 'v' o 'V'");
                        Console.WriteLine("AZUL pulsar 'a' o 'A'");
                        Console.WriteLine("NEGRO pulsar cuaquier otra :)");
                        color = char.Parse(Console.ReadLine());
                        switch (color)
                        {
                            case 'r':
                                Console.WriteLine("Eres un Rojo >:(");
                                break;
                            case 'R':
                                Console.WriteLine("Eres un Rojo >:( (pero con mayuscula)");
                                break;

                            case 'v':
                                Console.WriteLine("Eres verde como er beti :)");
                                break;
                            case 'V':
                                Console.WriteLine("Eres tan verde como er beti :)");
                                break;

                            case 'a':
                                Console.WriteLine("Eres azul sin mas");
                                break;
                            case 'A':
                                Console.WriteLine("Eres azul en mayusculas");
                                break;

                            default:
                                Console.WriteLine("Negro...");
                                break; //Opcional

                        } // Llave que cierra el switch
                        Console.WriteLine("Quiere volver al menú: s->sí/n->no");
                        continuar = Console.ReadKey().KeyChar;//Para que no espere a que el usuario pulse Enter
                        Console.WriteLine();

                    }
                    while (continuar == 's');

                }
                else if (ejercicio == 20)
                {

                    char continuar;
                    double numero;
                    do
                    {

                        Console.WriteLine("Escriba un número de 1 a 6 cifras:");
                        numero = double.Parse(Console.ReadLine());

                        if (numero < 9)
                        {

                            Console.WriteLine("Su número tiene 1 cifra");
                            Console.ReadLine();

                        }

                        else if (numero < 99)
                        {

                            Console.WriteLine("Su número es de 2 cifras");
                            Console.ReadLine();
                        }

                        else if (numero < 999)
                        {

                            Console.WriteLine("Su número es de 3 cifras");
                            Console.ReadLine();

                        }

                        else if (numero < 9999)
                        {

                            Console.WriteLine("Su número es de 4 cifras");
                            Console.ReadLine();

                        }

                        else if (numero < 99999)
                        {

                            Console.WriteLine("Su número es de 5 cifras");
                            Console.ReadLine();

                        }
                        else if (numero < 999999)
                        {

                            Console.WriteLine("Su número es de 6 cifras");
                            Console.ReadLine();
                        }







                        Console.WriteLine("Quiere volver al menú: s->sí/n->no");
                        continuar = Console.ReadKey().KeyChar;//Para que no espere a que el usuario pulse Enter
                        Console.WriteLine();

                    }
                    while (continuar == 's');

                }

                else if (ejercicio == 21)
                {
                    char continuar2;
                    do
                    {
                        Console.WriteLine("Hagamos una ecuación de seguno grado;");
                        Console.WriteLine("Introduzca el valor de 'a'");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el valor de 'b'");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el valor de 'c'");
                        double c = double.Parse(Console.ReadLine());

                        if (a == 0)
                        {
                            double x1, x2;
                            x1 = 0;
                            x2 = c / b;
                            Console.WriteLine("la solución es " + x1 + x2);
                            Console.ReadLine();

                        }

                        else if (b == 0)
                        {

                            double x3, x4;
                            x3 = 0;
                            x4 = Math.Sqrt(c / a);
                            Console.WriteLine("La solución es " + x3 + x4);
                            Console.ReadLine();

                        }

                        else if (c == 0)
                        {

                            double x5, x6;
                            x5 = 0;
                            x6 = (b / a);

                            Console.WriteLine("La solució es " + x5 + x6);
                            Console.ReadLine();

                        }

                        else if (b > 0 && c > 0)
                        {

                            double x7, x8;
                            x7 = 0;
                            x8 = -b + Math.Sqrt(b * b - 4 * a * c) / 2 * a;
                            Console.WriteLine("La solución es " + x7 + x8);
                            Console.ReadLine();

                        }

                        Console.WriteLine("Quiere volver atras? s/n");
                        continuar2 = Console.ReadKey().KeyChar;

                    }
                    while (continuar2 == 's');

                }
                else if (ejercicio == 22)
                {

                    char continuar3;
                    int numeroAño;
                    do
                    {

                        Console.WriteLine("Esribe un año:");
                        numeroAño = int.Parse(Console.ReadLine());

                        if (numeroAño % 100 == 0 && numeroAño % 400 == 0)
                        {

                            Console.WriteLine("El año" + numeroAño + " es visiesto");
                            Console.ReadLine();

                        }

                        else if (numeroAño % 4 == 0)
                        {

                            Console.WriteLine("El año" + numeroAño + " es visiesto");
                            Console.ReadLine();

                        }

                        else
                        {

                            Console.WriteLine("No es un año visiesto");
                            Console.ReadLine();

                        }


                        Console.WriteLine("Quiere volver atrás? s/n");
                        continuar3 = Console.ReadKey().KeyChar;
                    }
                    while (continuar3 == 's');

                }
                else if (ejercicio == 23)
                {

                    char continuar777;
                    do
                    {
                        Console.WriteLine("Escriba un número:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba otro número:");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Te juro que este es el último número que tienes que poner:");
                        int n3 = int.Parse(Console.ReadLine());

                        if (n1 > n2) // n1 es mayor que n2 
                        {

                            int menor = n2; 

                            if (menor > n3) // n2 es mayor que n3
                            {

                                Console.WriteLine(n3 + " es el número más pequeño.");
                                Console.WriteLine(menor + " es el número intermedio.");
                                Console.WriteLine(n1 + " es el número mayor.");

                            }

                            else // n3 es mayor que n2
                            {

                                Console.WriteLine(menor + " es el núero más pequeño.");
                                Console.WriteLine(n3 + " es el número intermedio.");
                                Console.WriteLine(n1 + " es el número mayor.");

                            }
                        }
                        else // n2 es mayor que n1
                        {

                            int menor = n1;

                            if (menor > n3) // n1 es mayor que n3
                            {

                                Console.WriteLine(n3 + " es el número más pequeño.");
                                Console.WriteLine(n2 + " es el número intermedio.");
                                Console.WriteLine(n1 + " es el número mayor.");

                            }
                            else // n3 es mayor que n1
                            {

                                Console.WriteLine(n3 + " es el número intermedio.");
                                Console.WriteLine(n2 + " es el número más pequeño.");
                                Console.WriteLine(n1 + " es el número mayor.");

                            }

                        }
                        if (n3 > n1) // n3 es mayor que n1
                        {
                        
                            if (n1 < n2) // n1 es mayor que n2
                            {

                                Console.WriteLine(n3 + " es el número mayor.");
                                Console.WriteLine(n2 + " es el número más pequeño.");
                                Console.WriteLine(n1 + " es el número intermedio.");

                            }
                            else // n2 es mayor que n1
                            {

                                Console.WriteLine(n3 + " es el número mayor.");
                                Console.WriteLine(n2 + " es el número intermedio.");
                                Console.WriteLine(n1 + " es el número más pequeño.");

                            }
                        
                        }

                        Console.WriteLine("Quiere volver hacia atras? s/n");
                        continuar777 = Console.ReadKey().KeyChar;
                    }
                    while (continuar777 == 's');


                }

            }
        }
    }
}
