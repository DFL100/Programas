using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_miercoles_urgente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            {
                //Ejercicio3

                List<string> listaDNIs = new List<string>();
                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Guardar DNI");
                    Console.WriteLine("2. Eliminar DNI");
                    Console.WriteLine("3. Mostrar DNIs");
                    Console.WriteLine("4. Buscar DNI");
                    Console.WriteLine("5. Contar DNIs");
                    Console.WriteLine("6. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            Console.WriteLine("Ingrese el DNI a guardar:");
                            string dniGuardar = Console.ReadLine();
                            if (!listaDNIs.Contains(dniGuardar))
                            {
                                listaDNIs.Add(dniGuardar);
                                Console.WriteLine("DNI guardado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El DNI ya está almacenado.");
                            }

                            break;

                        case 2:

                            Console.WriteLine("Ingrese el DNI a eliminar:");
                            string dniEliminar = Console.ReadLine();
                            if (listaDNIs.Contains(dniEliminar))
                            {
                                listaDNIs.Remove(dniEliminar);
                                Console.WriteLine("DNI eliminado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El DNI no está almacenado.");
                            }

                            break;

                        case 3:

                            Console.WriteLine("Lista de DNIs almacenados:");
                            foreach (string dni in listaDNIs)
                            {
                                Console.WriteLine(dni);
                            }

                            break;

                        case 4:

                            Console.WriteLine("Ingrese el DNI a buscar:");
                            string dniBuscar = Console.ReadLine();
                            if (listaDNIs.Contains(dniBuscar))
                            {
                                Console.WriteLine("El DNI " + dniBuscar + " está almacenado.");
                            }
                            else
                            {
                                Console.WriteLine($"El DNI " + dniBuscar + " no está almacenado.");
                            }

                            break;

                        case 5:

                            int cantidadDNIs = listaDNIs.Count;
                            Console.WriteLine($"Cantidad de DNIs almacenados: " + cantidadDNIs);

                            break;
                        case 6:

                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no valida. Por favor, pulsa en una de las que te indico :)");
                            break;
                    }//Final sel switch
                }//Final del while

                //Ejercicio4

                List<string> estados = new List<string>();
                List<string> capitales = new List<string>();

                bool continuar2 = true;

                while (continuar)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Ver todos los estados junto con su capital");
                    Console.WriteLine("2. Buscar la capital de un estado");
                    Console.WriteLine("3. Mostrar el estado al que pertenece una capital");
                    Console.WriteLine("4. Introducir un nuevo estado con su capital");
                    Console.WriteLine("5. Mostrar los estados ordenados alfabéticamente");
                    Console.WriteLine("6. Eliminar un estado junto con su capital");
                    Console.WriteLine("7. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            Console.WriteLine("Estados y sus capitales:");
                            for (int i = 0; i < estados.Count; i++)
                            {
                                Console.WriteLine($"{estados[i]} - {capitales[i]}");
                            }

                            break;

                        case 2:

                            Console.WriteLine("Ingrese el nombre del estado:");
                            string estado = Console.ReadLine();
                            int index = estados.IndexOf(estado);
                            if (index != -1)
                            {
                                Console.WriteLine("La capital de " + estado + " es " + capitales[index]);
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró el estado " + estado);
                            }

                            break;

                        case 3:

                            Console.WriteLine("Ingrese el nombre de la capital:");
                            string capital = Console.ReadLine();
                            int buscar = capitales.IndexOf(capital);
                            if (buscar != -1)
                            {
                                Console.WriteLine("La capital " + capital + " pertenece al estado de " +estados[buscar]);
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el estado para la capital " +capital);
                            }

                            break;

                        case 4:

                            Console.WriteLine("Ingrese el nombre del estado:");
                            string estado21 = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre de la capital:");
                            string capital21 = Console.ReadLine();

                            if (!estados.Contains(estado21))
                            {
                                estados.Add(estado21);
                                capitales.Add(capital21);
                                Console.WriteLine("Estado "+ estado21 + " y su capital " +capital21 +  " agregados correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El estado ya está en la lista.");
                            }

                            break;

                        case 5:

                            Console.WriteLine("Estados ordenados alfabéticamente:");
                            SortedSet<string> estadosOrdenados = new SortedSet<string>(estados);
                            foreach (var estadoCapital in estadosOrdenados)
                            {
                                string[] partes = estadoCapital.Split('-');
                                Console.WriteLine(partes[0] + " - " + partes[1]);
                            }

                            break;

                        case 6:

                            Console.WriteLine("Ingrese el nombre del estado para eliminarlo:");
                            string estado3 = Console.ReadLine();
                            int index2 = estados.IndexOf(estado3);
                            if (index2 != -1)
                            {
                                estados.RemoveAt(index2);
                                capitales.RemoveAt(index2);
                                Console.WriteLine($"Estado " + estado3 + "  y su capital eliminados correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El estado no está presente en la lista.");
                            }

                            break;

                        case 7:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }//Switch

                }//While

                //Ejercicio5

                Dictionary<int, string> clientes = new Dictionary<int, string>();

                bool continuar4 = true;

                while (continuar4)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Guardar cliente");
                    Console.WriteLine("2. Mostrar clientes");
                    Console.WriteLine("3. Buscar cliente por clave");
                    Console.WriteLine("4. Eliminar cliente por clave");
                    Console.WriteLine("5. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            Console.WriteLine("Ingrese la clave del cliente:");
                            int clave = int.Parse(Console.ReadLine());
                            if (clientes.ContainsKey(clave))
                            {
                                Console.WriteLine("La clave ya está en uso.");
                                return;
                            }

                            Console.WriteLine("Ingrese el DNI del cliente:");
                            string dni = Console.ReadLine();

                            Console.WriteLine("Ingrese el nombre del cliente:");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese la edad del cliente:");
                            int edad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el correo electrónico del cliente:");
                            string correo = Console.ReadLine();

                            string datosCliente = ("DNI: " + dni + "  Nombre: " + nombre +  " Edad: " + edad + " Correo: " + correo);
                            clientes.Add(clave, datosCliente);
                            Console.WriteLine("Cliente guardado correctamente.");

                            break;
                        case 2:

                            if (clientes.Count == 0)
                            {
                                Console.WriteLine("No hay clientes guardados.");
                                return;
                            }

                            Console.WriteLine("Clientes:");
                            foreach (var cliente in clientes)
                            {
                                Console.WriteLine("Clave: " + cliente.Key +" Datos: " + cliente.Value);
                            }

                            break;
                        case 3:

                            Console.WriteLine("Ingrese la clave del cliente:");
                            int clave2 = int.Parse(Console.ReadLine());

                            if (clientes.ContainsKey(clave2))
                            {
                                Console.WriteLine("Datos del cliente con clave " +clave2 + " son: " + clientes[clave2]);
                            }

                            else
                            {
                                Console.WriteLine("No se encontró cliente con esa clave.");
                            }

                            break;
                        case 4:

                            Console.WriteLine("Ingrese la clave del cliente a eliminar:");
                            int clave3 = int.Parse(Console.ReadLine());

                            if (clientes.ContainsKey(clave3))
                            {
                                clientes.Remove(clave3);
                                Console.WriteLine($"Cliente con clave {clave3} eliminado correctamente.");
                            }

                            else
                            {
                                Console.WriteLine("No se encontró cliente con esa clave.");
                            }

                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }



            }

        }
    }
}
