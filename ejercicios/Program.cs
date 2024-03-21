using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elija un ejercicio entre el 31 y el 36");
            int ejercicio = int.Parse(Console.ReadLine());
            do
            {


                switch (ejercicio)
                {

                    case 1:


                        int n = 0;

                        do
                        {

                            Console.WriteLine("Ingresa el valor de n");
                            n = int.Parse(Console.ReadLine());

                        }
                        while (n > 10 || n < 0);

                        int[] kali = new int[n];

                        Random random = new Random();

                        for (int i = 0; i < n; i++)
                        {

                            kali[i] = random.Next(0, 2);
                            Console.Write(kali[i] + " , ");

                        }

                        Console.ReadLine();
                        break;

                        case 2:
                        break;


                }
            }
            while (ejercicio > 36 || ejercicio < 31);

        }   

    }
}

