using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio26__definitivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio26


            String ruta = Directory.GetCurrentDirectory();
            String rutaFichero = ruta + @"\registros.txt";
            //Recuperar datos del fichero
            String[] registros = new string[100];

            StreamReader lector;
            try
            {
                lector = new StreamReader(rutaFichero);
                int posicion = 0;
                String registro = "";
                while (registro != null)
                {
                    registro = lector.ReadLine();
                    registros[posicion] = registro;
                    posicion++;
                }
                lector.Close();

            } catch (IOException e)
            {
                //Console.WriteLine("El fichero no existe ");
                if (!File.Exists(rutaFichero))
                {
                    File.Create(rutaFichero);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            int opcion = 0;
            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Mostrar registros");
                Console.WriteLine("2. Insertar nuevo registro");
                Console.WriteLine("3. Consultar por DNI");
                Console.WriteLine("4. Mostrar registros con salario superior a 2500€");
                Console.WriteLine("5. Modificar registro por DNI");
                Console.WriteLine("6. Eliminar registro por DNI");
                Console.WriteLine("7. Salir");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion < 0 || opcion > 7);

                switch (opcion)
            {
                case 1:

                    //Mostrar registros por pantalla
                    Console.WriteLine("Registros:");
                    StreamReader lector26 = new StreamReader(rutaFichero);
                    string linea;
                    while ((linea = lector26.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                    lector26.Close();

                    Console.ReadLine();
                    break;

                case 2:

                    Console.WriteLine("dni: ");
                    String dni26 = Console.ReadLine();
                    Console.WriteLine("nombre y apellidos: ");
                    String NA26 = Console.ReadLine();
                    Console.WriteLine("edad: ");
                    String edad26 = Console.ReadLine();
                    Console.WriteLine("salario: ");
                    String salario26 = Console.ReadLine();

                    //Escribimos registro en el fichero
                    StreamWriter escritor = new StreamWriter(rutaFichero, true);
                    escritor.WriteLine(dni26 + "*" + NA26 + "?" + edad26 + "?" + salario26);

                    //Cerrar el StreamWriter
                    escritor.Close();

                    Console.WriteLine("Registro añadido exitosamente.");

                    Console.ReadLine();

                    break;

                case 3:

                    //Buscar Serie
                    Console.WriteLine("Que DNI desea buscar?");
                    String DNI = Console.ReadLine();

                    foreach (String s in registros)
                    {
                        //Estructura registro --> nombre serie*plataforma
                        //Obtenemos la cadena que hay antes del asterisco
                        if (s == null)
                        {
                            Console.WriteLine("Serie no encontrada.");
                            break;
                        }
                        String[] trozos = s.Split('*');
                        if (DNI.Equals(trozos[0], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Registro encontrada: ");
                            Console.WriteLine("Información: " + trozos[1]);
                            break;
                        }

                    }

                    Console.ReadLine();

                    break;

                case 4:

                    Console.WriteLine("Registros con salario superior a 2500€:");
                    foreach (String s in registros)
                    {
                        if (s != null)
                        {
                            //Dividir la línea en partes utilizando "*"
                            string[] campos = s.Split('?');

                            //ver si hay suficientes partes y si el salario es más que 2500
                            if (campos.Length >= 4 && Convert.ToInt32(campos[3]) > 2500)
                            {
                                Console.WriteLine("Registro encontrado:");
                                Console.WriteLine("DNI: " + campos[0]);
                                Console.WriteLine("Nombre y apellidos: " + campos[1]);
                                Console.WriteLine("Edad: " + campos[2]);
                                Console.WriteLine("Salario: " + campos[3]);
                            }
                        }
                    }
                    Console.ReadLine();

                    break;

                case 5:

                    Console.WriteLine();
                    Console.WriteLine("Introduce el DNI del registro que quieres modificar:");
                    string Modificardni = Console.ReadLine();

                    //Recorrer los registros
                    for (int i = 0; i < registros.Length; i++)
                    {
                        //Verificar si el registro actual es nulo
                        if (registros[i] == null)
                        {
                            // Mostrar mensaje de error si el DNI no se encuentra
                            Console.WriteLine("DNI no encontrado.");
                            break;
                        }

                        //Dividir el registro actual en partes
                        string[] trozos = registros[i].Split('*', '?', '?');

                        //Verificar si el DNI coincide
                        if (Modificardni.Equals(trozos[0], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Introduce el nuevo nombre y primer apellido:");
                            string nuevoNombre = Console.ReadLine();

                            Console.WriteLine("Introduce la nueva edad:");
                            byte nuevaEdad = byte.Parse(Console.ReadLine());

                            Console.WriteLine("Introduce el nuevo salario:");
                            double nuevoSalario = double.Parse(Console.ReadLine());

                            //Actualizar el registro
                            registros[i] = trozos[0] + "*" + nuevoNombre + "?" + nuevaEdad + "?" + nuevoSalario;
                            break;
                        }
                    }

                    //Actualizar el archivo
                    StreamWriter escritor266 = new StreamWriter(rutaFichero);
                    for (int i = 0; i < registros.Length; i++)
                    {
                        if (registros[i] != null)
                        {
                            escritor266.WriteLine(registros[i]);
                        }
                    }
                    escritor266.Close();

                    break;

                case 6:

                    Console.WriteLine();
                    Console.WriteLine("Introduce el DNI del registro que quieres eliminar:");
                    string dniEliminar = Console.ReadLine();

                    //Recorrer los registros
                    for (int i = 0; i < registros.Length; i++)
                    {
                        //Verificar si el registro actual no es nulo y si el DNI coincide
                        if (registros[i] != null && registros[i].Split('*')[0].Equals(dniEliminar, StringComparison.OrdinalIgnoreCase))
                        {
                            registros[i] = null;
                            break;
                        }
                    }

                    //Actualizar el archivo
                    StreamWriter writer = new StreamWriter(rutaFichero);
                    foreach (string registro in registros)
                    {
                        if (registro != null)
                        {
                            writer.WriteLine(registro);
                        }
                    }
                    writer.Close();

                    Console.WriteLine();

                    break;

            }



        }//no tocar
    }//no tocar
}//no tocar

