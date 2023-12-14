using System;

namespace boletin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;
            Console.WriteLine("Entre el 8 y el 19 a que ejercicio quiere ir?");
            ejercicio = int.Parse(Console.ReadLine());
            {
                if (ejercicio == 8)
                {
                    // Ejercicio 8

                    // Solicitar al usuario que ingrese un número
                    Console.Write("Ingrese un número: ");
                    int numeroBase = int.Parse(Console.ReadLine());

                    // Mostrar encabezado de la tabla
                    Console.WriteLine("Número Cuadrado Cubo");

                    // Llamar al método para generar la tabla
                    GenerarTabla(numeroBase);
                }

                if (ejercicio == 9)
                {
                    // Ejercicio 9

                    // Inicializar la variable n a 16
                    double n = 16.0;

                    // Mostrar encabezado de la tabla
                    Console.WriteLine("Número Raíz Cuadrada");


                    for (; n >= 0; n -= 2.5)
                    {

                        double raizCuadrada = Math.Sqrt(n);

                        // Mostrar los resultados en una tabla
                        Console.WriteLine($"{n}\t\t{raizCuadrada}");

                    }
                }

                if (ejercicio = 10)
                {
                    // Ejercicio 10 

                    // Pedir al usuario que introduzca un número
                    int m;
                    do
                    {

                        Console.Write("Ingrese un número no negativo: ");

                    }
                    while (!int.TryParse(Console.ReadLine(), out m) || m < 0);

                    // Calcular la suma de los primeros m números y enseñar el resultado
                    int sumaFor = 0;
                    for (int i = 1; i <= m; i++)
                    {

                        sumaFor += i;

                    }

                    Console.WriteLine("La suma de los primeros " + m + " números es: " + sumaFor);

                    // Ejercicio 10 

                    // Reiniciar la variable m
                    m = 0;

                    // Pedir al usuario que introduzca un número
                    while (m <= 0)
                    {

                        Console.Write("Ingrese un número: ");
                        int.TryParse(Console.ReadLine(), out m);

                    }

                    // Calcular la suma de los primeros m números e imprimir el resultado
                    int sumaWhile = 0;
                    int j = 1;
                    while (j <= m)
                    {

                        sumaWhile += j;
                        j++;

                    }

                    Console.WriteLine("La suma de los primeros " + m + " números es: " + sumaWhile);
                }

                if (ejercicio = 11)
                {
                    // Ejercicio 11

                    // Pedir al usuario que introduzca un número positivo 
                    int nSerie;
                    do
                    {

                        Console.Write("Ingrese un número positivo: ");

                    }
                    while (!int.TryParse(Console.ReadLine(), out nSerie) || nSerie <= 0);

                    // Calcular la suma de la serie 
                    double sumaSerieFor = 0.0;
                    for (int i = 1; i <= nSerie; i++)
                    {

                        sumaSerieFor += 1.0 / (i * i * i);

                    }

                    Console.WriteLine($"La suma de la serie es: " + sumaSerieFor);

                    // Reiniciar la variable n 
                    int nSerieWhile = 0;

                    // Pedir al usuario que introduzca un número positivo
                    while (nSerieWhile <= 0)
                    {

                        Console.Write("Ingrese un número positivo: ");
                        int.TryParse(Console.ReadLine(), out nSerieWhile);

                    }

                    // Calcular la suma de la serie 
                    double sumaSerieWhile = 0.0;
                    int k = 1;

                    while (k <= nSerieWhile)
                    {

                        sumaSerieWhile += 1.0 / (k * k * k);
                        k++;

                    }

                    Console.WriteLine($"La suma de la serie es: " + sumaSerieWhile);
                }

                if (ejercicio = 12)
                {
                    // Ejercicio 12

                    // Pedir al usuario que introduzca un número no negativo para calcular la suma
                    int numeroDivisores;

                    do
                    {

                        Console.Write("Ingrese un número: ");

                    }
                    while (!int.TryParse(Console.ReadLine(), out numeroDivisores) || numeroDivisores < 0);

                    // Calcular la suma de los divisores
                    int sumaDivisoresFor = 0;
                    Console.Write($"Divisores de " + numeroDivisores);
                    for (int i = 1; i <= numeroDivisores; i++)

                    {

                        if (numeroDivisores % i == 0)
                        {

                            sumaDivisoresFor += i;
                            Console.Write(i);

                        }

                    }
                    Console.WriteLine("La suma de los divisores es: " + sumaDivisoresFor);

                    // Calcular la suma de los divisores
                    int sumaDivisoresWhile = 0;
                    int l = 1;
                    Console.Write("Divisores da " + numeroDivisores);
                    while (l <= numeroDivisores)
                    {

                        if (numeroDivisores % l == 0)
                        {

                            sumaDivisoresWhile += l;
                            Console.Write($"{l} ");

                        }
                        l++;
                    }

                    Console.WriteLine("La suma de los divisores es: " + sumaDivisoresWhile);

                    // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
                    Console.ReadKey();
                

                    // Método para generar la tabla 
                    void GenerarTabla(int numeroBase)
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            int numeroActual = numeroBase + i;
                            int cuadrado = numeroActual * numeroActual;
                            int cubo = numeroActual * numeroActual * numeroActual;

                            // Enseñar los resultados en forma de tabla
                            Console.WriteLine(numeroActual + cuadrado + cubo);
                        }
                }   }
            }
        }
    }
}
