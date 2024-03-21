using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Fandiño_Lopez_BoletínT7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;
            do
            {

                Console.WriteLine("Escoge un ejercicio entre el 1 y el 26");
                ejercicio = int.Parse(Console.ReadLine());

            }
            while (ejercicio > 26 || ejercicio < 1);

            switch(ejercicio)
            {

                case 1:

                    string[] matriculasnumero1 = new string[7];
                    

                    string[] matriculasnumero2 = new string[7];
                    

                    string[] matriculasnumero3 = new string[7];
                    

                    string[] matriculasnumero4 = new string[7];
                  

                    string[] matriculasnumero5 = new string[7];
                    

                    string[] matriculasnumero6 = new string[7];


                    string[] matriculasnumero7 = new string[7];
                    

                    string[] matriculasnumero8 = new string[7];
                    

                    string[] matriculasnumero9 = new string[7];
                    

                    string[] matriculasnumero10 = new string[7];

                    //_________________________________________________
                    //GENERAR LETRAS ALEATORIAS

                    {
                        // Crear una instancia de la clase Random
                        Random random1 = new Random();

                        // Especificar la longitud de la secuencia de letras
                        int longitudSecuencia = 10;

                        // Generar y mostrar la secuencia de letras aleatorias
                        Console.WriteLine("Secuencia de letras aleatorias:");

                        for (int i = 0; i < longitudSecuencia; i++)
                        {
                            char letraAleatoria = GenerarLetraAleatoria(random1);
                            Console.Write(letraAleatoria + " ");
                        }

                        // Esperar antes de cerrar la consola (opcional)
                        Console.ReadLine();
                    }

                    char GenerarLetraAleatoria(Random random1)
                    {
                        // Definir el rango de letras en el código ASCII
                        int minAscii = (int)'A';
                        int maxAscii = (int)'Z';

                        // Generar un número aleatorio en el rango de las letras
                        int numeroAleatorio = random1.Next(minAscii, maxAscii + 1);

                        // Convertir el número a un carácter
                        char letraAleatoria = (char)numeroAleatorio;

                        return letraAleatoria;
                    }
                    //_________________________________________________

                    Random random = new Random();
                    Random rambo1 = new Random();
                    int matricula = 0;
                    int contador1 = 0;


                    for(int i = 1; i < 10; i++)
                    {
                        
                            char letraAleatoria = GenerarLetraAleatoria(random);

                        while (matricula == 4)
                        {

                            matriculasnumero1[contador1] = Convert.ToString(rambo1.Next());
                            matricula++;
                            contador1++;
                            Console.Write(matriculasnumero1[contador1]);
                        }
                        matricula = 0;
                        while(matricula == 3)
                        {

                            matriculasnumero1[contador1] = Convert.ToString(letraAleatoria + " ");
                            matricula++;
                            Console.Write(matriculasnumero1[contador1]);
                        }
                        
                    }
                    for (int i = 0;i < matriculasnumero1.Length; i++)
                    {
                        Console.WriteLine(matriculasnumero1[i]);
                    }

                    //a
                    Console.WriteLine("Apartado 'a'");

                    


                    break;

            }
            Console.ReadLine();
        }
    }
}
