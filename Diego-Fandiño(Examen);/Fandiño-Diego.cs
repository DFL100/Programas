using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Fandiño_Examen__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Diego Fandiño López
            //Ejercicio 2
            //Horas totales trabajadas en un mes (4 semanas)
            //Salario bruto que cobraria el trabajador
            //Salario neto que resultaria al quitarle al salario bruto el IRPF
            //Mostrar por pantalla los resultados

            double precioHora;
            Console.WriteLine("Cuanto le pagan por hora? ");
            precioHora = double.Parse(Console.ReadLine());

            double horasSemana;
            Console.WriteLine("Cuatas horas trabaja a la semana? ");
            horasSemana = double.Parse(Console.ReadLine());

            double irpfAplicado;
            Console.WriteLine("Cuanto % de IRPF le aplican en la empresa? ");
            irpfAplicado = double.Parse(Console.ReadLine());

            double horasMes;
            horasMes = horasSemana * 4;
            Console.WriteLine("Usted trabaja " + horasMes + " horas al mes.");
            Console.ReadLine();

            double salarioBruto;
            salarioBruto = precioHora * horasMes;
            Console.WriteLine("Usted cobra " + salarioBruto + " euros de salario bruto.");
            Console.ReadLine();

            double restaIrpf;
            restaIrpf = salarioBruto / irpfAplicado;
            Console.WriteLine("A usted le quitan " + restaIrpf + " euros por el IRPF ");
            Console.ReadLine() ;

            double salarioNeto;
            salarioNeto = salarioBruto - restaIrpf;
            Console.WriteLine("Su sueldo neto es de " + salarioNeto + " euros al mes");
            Console.ReadLine();

            //Diego Fandiño López
            //Ejercicio 3
            int numero;
            Console.WriteLine("Dime un número: ");
            numero = int.Parse(Console.ReadLine());

            //int no puede almacenar decimales, por eso lo puse con double
            double raíz;
            raíz = Math.Sqrt(numero);
            double numerov;
            numerov = Math.Round(raíz, 2);
            Console.WriteLine("La raíz de " + numero + " es " + numerov);
            Console.ReadLine();

            int numeroElevado;
            numeroElevado = (int)Math.Pow(numero, 6);
            Console.WriteLine(numero + " elevado a 6 es " + numeroElevado);
            Console.ReadLine();

            short numeroAlmacenado;
            numeroAlmacenado = (short)numero;
            Console.WriteLine("Tu número almacenado en short es " + numeroAlmacenado);
            Console.ReadLine();

            float numero20porciento, numero20porciento2;
            numero20porciento = 20 * numero / 100;
            numero20porciento2 = numero - numero20porciento;
            Console.WriteLine(numero + " menos el 20 porciento es " + numero20porciento2);
            Console.ReadLine();

            int valor35porciento, valor35porciento2;
            valor35porciento = 35 * numero / 100;
            valor35porciento2 = numero + valor35porciento;
            Console.WriteLine("El 35 porciento de " + numero + " es " + valor35porciento);
            Console.ReadLine();

            int suma35porciento;
            suma35porciento = numero + valor35porciento;
            Console.WriteLine("Si le sumas " + valor35porciento + " a " + numero + " te va a dar " + suma35porciento);
            Console.ReadLine();

            //Diego Fandiño López

        }
    }
}
