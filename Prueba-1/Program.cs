using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mandar por consola un mensaje.
            Console.WriteLine("Amai er BIXO");

            /*Vamos a ver otros métodos
             * y propiedades de la clase console 
            */

            //Cambiar el coor del texto.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wikirafa");

            Console.Title = "Mi primer programa";

            //Hacer que suene un ruido al ejecutarlo.
            Console.Beep(17000, 1000);

            //Evitar que se cierre la consola hasta que el usuario pulse enter.
            Console.ReadLine();
        } //Cierra el metodo main.
    } //Cierra la clase.
} //Cierra el namespace.
