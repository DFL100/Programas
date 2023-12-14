using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Htrabajo;
            Console.WriteLine("Cuantas horas trabaja?" );
            Htrabajo = double.Parse( Console.ReadLine() );

            double sueldo;
            Console.WriteLine("Cuanto cobra en bruto a la hora? ");
            sueldo = double.Parse( Console.ReadLine() );

            double Dame_Un_10;
            Dame_Un_10 = (Htrabajo * sueldo) * 30;
            Console.WriteLine("Usted cobra " + Dame_Un_10 + " euros al més en bruto.");
            Console.ReadLine();

            double irpf;
            Console.WriteLine("Digame cuanto le cobran de IRPF ");
            irpf = double.Parse( Console.ReadLine() );

            double neto;
            neto = sueldo / irpf * 100;
            Console.WriteLine("Su sueldo neto es de " + neto +);
            Console.ReadLine();

        }
    }
}
