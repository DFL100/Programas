using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramoncín2___5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Pedir precio del producto
            double precio;
            Console.WriteLine("Introduzca el precio del producto: ");
            precio = double.Parse(Console.ReadLine());

        //Pedir cantidad de productos
            short cantidad;
            Console.WriteLine("Introduzca la cantidad de productos: ");
            cantidad = short.Parse(Console.ReadLine());

        //Calcular el importe del producto
            double dolorosa;
            dolorosa = precio * cantidad;
            Console.WriteLine("“El precio del producto es " + precio + " euros y la cantidad que compra es " + cantidad + " por lo tanto debe pagar " + dolorosa + " euros. Vuelva pronto.”");
            Console.ReadLine();
                

        }
    }
}
