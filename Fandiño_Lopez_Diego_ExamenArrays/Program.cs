using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fandiño_Lopez_Diego_ExamenArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char continuar = ' ';
            do
            {
                int ejercicio = 0;
                do
                {
                    Console.WriteLine("Elije a que ejercicio quiere ir (del 1 al 4)");
                    ejercicio = int.Parse(Console.ReadLine());

                }
                while (ejercicio < 1 || ejercicio > 4);

                switch (ejercicio)
                {

                    case 1:

                //Tamaño del array
                        Console.WriteLine("Cual quiere que sea el tamaño de la array?");
                        int a2 = int.Parse(Console.ReadLine());

                        Random Random1 = new Random();
                        int[] a1 = new int[a2];

                //Valores del array
                        Console.WriteLine("Sus valores son:");
                        for (int i = 0; i <= a1.Length -1; i++)
                        {

                            a1[i] = Random1.Next(1,10);
                            Console.Write(a1[i] + " ");

                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                //Pautas ejercicio:
                        for (int i = 0; i <= a1.Length; i++)
                        {

                            if (a1[i] % 2 == 0)
                            {

                                a1[i] = a1[i] * a1[i] * a1[i];  //Math.Pow(a1[i], 3);
                                Console.WriteLine("La posición " + i + " del array es impar, y si lo elevamos al cubo nos da " + a1[i]);
                                break;

                            }

                        }

                        break;

                    case 2:
                
                //Tamaño del array 
                        Console.WriteLine("Que capacidad quiere que tenga el array?");
                        int b2 = int.Parse(Console.ReadLine());

                        int[] b1 = new int[b2];
                        Random Random2 = new Random();

                //Variables
                        int media2 = 0;
                        int desviacion2 = 0;
                        int contador2 = 0;
                        int suma2 = 0;
                        int contador2_1 = 0;
                        int suma2_1 = 0;
                        int media2_1 = 0;

                        //Valores del array
                        Console.WriteLine("Sus valores son:");
                        for (int i = 0; i <= b1.Length - 1; i++)
                        {

                            b1[i] = Random2.Next(1, 10);
                            Console.Write(b1[i] + " ");

                        }

                //Pautas ejercicio:
                    //Calcular la media general
                        for (int i = 0; i <= b1.Length -1; i++)
                        {

                            suma2 += b1[i];
                            contador2++;

                        }
                        Console.WriteLine(" ");
                        media2 = suma2 / contador2;
                        Console.WriteLine("La media es de " + media2);

                    //Calcular la media de las 5 últimas posiciones
                        for (int i = b1.Length - 5; i <= b1.Length - 1; i++)
                        {

                            suma2_1 += b1[i];
                            contador2_1++;

                        }
                        media2_1 = suma2_1 / contador2_1;
                        Console.WriteLine("La media de las cinco últimas posiciones es de " + media2_1);

                    //Calcular la desviación

                        for (int i = b1.Length - 5; i <= b1.Length - 1;i++)
                        {

                        desviacion2 = b1[i] - media2_1;
                            if (desviacion2 > 0)
                            {

                                Console.WriteLine("La desviación de " + i + " es de " + desviacion2);

                            }

                            if (desviacion2 < 0)
                            {

                                desviacion2 -= desviacion2 + desviacion2;
                                Console.WriteLine("La desvición de" + i + " es de " + desviacion2);

                            }

                        }

                        
                        break;

                    case 3:

                //Tamaño del array
                        Console.WriteLine("Cual quiere que sea el tamaño de la array?");
                        int c2 = int.Parse(Console.ReadLine());

                        Random Random3 = new Random();
                        int[] c1 = new int[c2];

                //Array copia
                        int[] c3 = new int[c2];

                //Valores del array
                        Console.WriteLine("Sus valores son:");
                        for (int i = 0; i <= c1.Length - 1; i++)
                        {

                            c1[i] = Random3.Next(1, 10);
                            Console.Write(c1[i] + " ");

                        }

                //Pautas del ejercicio
                    //Mostrar los valores múltiplos de 3 y insertarlos en la copia
                        for(int i = 0; i <= c1.Length - 1; i++)
                        {

                            if (c1[i] % 3 == 0)
                            {

                                Console.WriteLine("El valor " + i + " es múltiplo de 3, con el valor " + c1[i]);
                                c3[i] = c1[i];

                            }

                        }
                        Console.WriteLine(" ");

                    //Insertar los valores múltilos de 3 en la copia
                        Console.WriteLine("Ahora crearemos una copia:");
                        Console.WriteLine("Los valores de la copia son:");
                        for (int i = 0; i <= c3.Length - 1; i++)
                        {

                            Console.WriteLine("El valor " + i + " de la copia tiene el valor de " + c3[i]);

                        }


                        break;

                    case 4:

                //Tamaño del array 
                        Console.WriteLine("Que capacidad quiere que tenga el array?");
                        int d2 = int.Parse(Console.ReadLine());

                        int[] d1 = new int[d2];
                        Random Random4 = new Random();

                //Variables
                        int contador4 = 0;
                        int media = 0;
                        int suma4 = 0;

                //Valores del array
                        Console.WriteLine("Sus valores son:");
                        for (int i = 0; i <= d1.Length - 1; i++)
                        {

                            d1[i] = Random4.Next(-10, 10);
                            Console.Write(d1[i] + " ");

                        }

                //Pautas del ejercicio
                        for (int i = 0; i <= d1.Length -1; i++)
                        {

                            if (d1[i] < 0)
                            {

                                Console.WriteLine("El valor " + d1[i] + " de la posición " + i + " de la array es negativo");
                                contador4++;
                                
                            }
                            suma4++;
                        }

                        //numero de elementos entre el total por 100
                        Console.WriteLine(" ");
                        Console.WriteLine("El porcentaje de números negativos de la array es del " + (contador4/suma4)*100 + "%");

                        break;

                }


                Console.ReadLine();
                Console.WriteLine("Quiere continuar? s/n");
                continuar = char.Parse(Console.ReadLine());
            }
            while (continuar == 's');
            //Diego Fandiño López

        }
    }
}
