using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diego_Fandiño_López__BoletínUD7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;

            do
            {
                Console.WriteLine("A que ejercicio quiere ir?");
                ejercicio = int.Parse(Console.ReadLine());
            }
            while (ejercicio < 0 || ejercicio > 26);

            switch (ejercicio)
            {

                case 1:

                    string[] matriculas = new string[50];
                    matriculas[0] = "1234-AAA";
                    matriculas[1] = "3610-BGS";
                    matriculas[2] = "1036-BSP";
                    matriculas[3] = "4920-261";
                    matriculas[4] = "3534-EPA";
                    matriculas[5] = "2374-AZZ";
                    matriculas[6] = "2750-CPZ";

                    Console.WriteLine("Acabadas en z");

                    if (matriculas == null)
                    {
                        Console.WriteLine("El array 'matriculas' es nulo.");
                    }
                    else
                    {
                        for (int i = 0; i < matriculas.Length; i++)
                        {
                            if (matriculas[i] != null && matriculas[i].EndsWith("Z"))
                            {
                                Console.WriteLine(matriculas[i]);
                            }
                        }
                    }

                    Console.WriteLine("Que contieen el número 34");

                    for (int i = 0; i <= matriculas.Length; i++)
                    {
                        if (matriculas is null)
                        {
                            break;
                        }

                        if (matriculas != null && matriculas[i].Contains("34"))
                        {

                            Console.WriteLine(matriculas[i]);

                        }

                    }

                    Console.WriteLine("Mostrar solo la parte numérica");

                    for (int i = 0; i <= matriculas.Length; i++)
                    {
                        if (matriculas is null)
                        {
                            break;
                        }

                        // ver si el array actual tiene al menos 4 letras
                        if (matriculas[i].Length >= 4)
                        {
                            // enseñar las primeros 4 letras del array
                            Console.WriteLine(matriculas[i].Substring(0, 4));

                        }

                    }
                    Console.WriteLine("Ahora enseñamos solo las letras");

                    for (int j = 0; j < matriculas.Length; j++)
                    {
                        if (matriculas == null)
                        {
                            break;
                        }

                        if (matriculas != null)
                        {

                            string letrasMatricula = matriculas[j].Substring(matriculas.Length - 3);
                            Console.WriteLine(letrasMatricula);

                        }
                    }




                    break;

                case 2:

                    Console.WriteLine("*****EJERCICIO2*****");
                    Console.WriteLine("Algoritmo que obtiene el número de veces que aparece un determinado char en un  string.");
                    Console.ReadLine();

                    Console.WriteLine("Escribe una pequeña frase");
                    string frase2 = Console.ReadLine();
                    Console.WriteLine("Dime una letra para buscar las veces que aparece en la frase que te pregunté anteriormente");
                    char letra2 = char.Parse(Console.ReadLine());

                    int contador = 0;
                    for (int i = 0; i <= frase2.Length - 1; i++)
                    {

                        if (letra2 == frase2[i])
                        {
                            contador++;
                        }

                    }
                    Console.WriteLine("Hay " + contador + " " + letra2 + " en la frase");


                    break;

                case 3:

                    Console.WriteLine("*****Ejercicio3*****");
                    Console.WriteLine("Usando los métodos necesarios de la clase Char , crear un programa que sirva para\r\nprocesar la introducción de un DNI por teclado . Para ello debe comprobar que el valor\r\nintroducido consta de 8 dígitos y una letra. Debe avisar en caso de que\r\nhayamos introducido menos dígitos o más , o no hayamos introducido letra o hayamos\r\nintroducido una letra en los primeros 8 dígitos etc… Una vez validado el formato, debemos comprobar que la letra es la adecuada.");
                    Console.ReadLine();

                    char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                    Console.WriteLine("Dígame su DNI");
                    string DNI3 = Console.ReadLine();
                    //int DNI31 = int.Parse(DNI3);



                    if (DNI3.Length != 9)
                    {

                        Console.WriteLine("Tiene el formato incorrecto");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("Tiene el formato correcto");


                    }


                    Console.WriteLine(DNI3);
                    break;

                case 4:
                    int contador29 = 0;
                    Console.WriteLine("*****Ejercicio4*****");
                    Console.WriteLine("Palabras que empiezan por b");

                    Console.WriteLine("Dime una frase");
                    string frase4 = Console.ReadLine();

                    string[] palabras = frase4.Split(' ');

                    Console.WriteLine("Palabras que empiezan por b:");
                    foreach (string palabra in palabras)
                    {
                        if (palabra.StartsWith("b"))
                        {
                            contador29++;
                            Console.WriteLine(palabra);

                        }
                    }
                    Console.WriteLine("contiene " + contador29 + " palabras que mepiezan por b");

                    break;

                case 5:

                    Console.WriteLine("*****Ejercicio5*****");

                    bool contiene = false;

                    Console.WriteLine("Escribeme una frase:");
                    string frase5 = Console.ReadLine();

                    if (frase5.Contains('@')) { contiene = true; }


                    if (contiene == true)
                    {
                        Console.WriteLine("La frase contiene @");
                    }
                    else
                    {
                        Console.WriteLine("La frase no contiene @");
                    }


                    break;

                case 6:

                    string texto = "abacaba abajo abacate abadía";
                    string Buscar = "aba";

                    //Partir el texto en palabras
                    string[] palabras6 = texto.Split(' ');

                    int contar = 0;

                    //Contar el número de palabras
                    foreach (string palabra in palabras6)
                    {
                        if (palabra.Contains(Buscar))
                        {
                            contar++;
                        }

                    }
                    Console.WriteLine("Hay " + contar + " palabras que contienen '" + Buscar + "'");
                    Console.ReadLine();

                    break;

                case 7:

                    string email = "realramonrs@gmail.com";

                    string[] partes = email.Split('@');

                    //0 es antes del @ y 1 es después
                    string dominio = partes[1];

                    //Enseñar el dominio
                    Console.WriteLine("El dominio del correo electrónico es: " + dominio);
                    Console.ReadLine();

                    break;

                case 8:

                    Console.WriteLine("Escribe un texto en formato AA99:");
                    string texto8 = Console.ReadLine();

                    bool formatoCorrecto = true;

                    if (texto8.Length != 4)
                    {
                        Console.WriteLine("Error: Es muy largo");
                        formatoCorrecto = false;
                    }

                    //Ver si los primeros dos caracteres son letras
                    if (!Char.IsLetter(texto8[0]) || !Char.IsLetter(texto8[1]))
                    {
                        Console.WriteLine("Error: No empezaste por una letra");
                        formatoCorrecto = false;
                    }

                    //Ver si los dos últimos son números
                    if (Char.IsLetter(texto8[2]) || Char.IsLetter(texto8[3]))
                    {
                        Console.WriteLine("Error: Los dos últimos tienen que ser números");
                        formatoCorrecto = false;
                    }

                    //Si todo está bien sale esto
                    if (formatoCorrecto == true)
                    {
                        Console.WriteLine("Lo escribiste bien chaval");
                    }

                    Console.ReadLine();

                    break;

                case 9:

                    Console.WriteLine("Escribe una frase");
                    string cadena = Console.ReadLine();

                    //Remplazar los espacios
                    string cadenaModificada = cadena.Replace(' ', '*');

                    //Enseñar la frase cambiada
                    Console.WriteLine("Cadena modificada: " + cadenaModificada);

                    Console.ReadLine();

                    break;

                case 10:

                    string Pedro = "Pedro Jimenez*14Julio1990?2500";
                    string Maria = "Maria Benitez*9070!06Agosto1998";

                    string salarioPedro1 = Pedro.Substring(Pedro.IndexOf('?') + 1);
                    int salarioPedro2 = int.Parse(salarioPedro1);


                    //Ver si el salario de Pedro es mayor a 1000
                    if (salarioPedro2 > 1000)
                    {
                        Console.WriteLine("El salario de Pedro es: " + salarioPedro2);
                    }
                    else
                    {
                        Console.WriteLine("El salario de Pedro no es mayor a 1000.");
                    }

                    string salarioMaria1 = Maria.Substring(Maria.IndexOf('o') + 1);
                    int salarioMaria2;

                    //convertir a un número
                    if (int.TryParse(salarioMaria1, out salarioMaria2))
                    {
                        //Ver si el salario de Maria es más que 1000
                        if (salarioMaria2 > 1000)
                        {
                            Console.WriteLine("El salario de Maria es: " + salarioMaria2);
                        }
                        else
                        {
                            Console.WriteLine("El salario de Maria no es mayor a 1000.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo obtener el salario de Maria.");
                    }

                    Console.ReadLine();

                    break;

                case 11:

                    Console.WriteLine("*****EJERCICIO11*****");
                    Console.WriteLine("Ahorcado");

                    int vidas = 5;
                    Console.WriteLine("Constas de " + vidas + " vidas actualmente, cada error te descontará una...");
                    Console.WriteLine("Hasta que pierdas entre terrible sufrimiento...");

                    string palabradefinitiva;
                    char espacio = ' ';
                    int contadordefinivivo = 0;

                    do
                    {
                        contadordefinivivo = 0;

                        Console.WriteLine("Escribe la palabra");
                        //Como el teléfono-rojo
                        palabradefinitiva = Console.ReadLine();

                        foreach (char c in palabradefinitiva)
                        {
                            if (c == espacio)
                            {
                                contadordefinivivo++;
                            }

                        }
                        if (contadordefinivivo == 1)
                        {
                            Console.WriteLine("La palabra tiene " + contadordefinivivo + " espacio y no es válido");
                        }
                        if (contadordefinivivo > 0)
                        {
                            Console.WriteLine("La palabra tiene " + contadordefinivivo + " espacios y no es válido");
                        }

                    }
                    while (contadordefinivivo > 0 || string.IsNullOrEmpty(palabradefinitiva));
                    //string.IsNullOrEmpty(palabradefinitiva) -> Sirve para ver si el string es nulo o está vacio

                    Random Letradefinitiva = new Random();
                    int Letraepicarda1;
                    int Letraepicarda2;
                    int Letraepicarda3 = -1;

                    /*for(int i = 0; i < palabradefinitiva.Length; i++)
                    {

                        Letraepicarda1 = Letradefinitiva.Next(palabradefinitiva.Length);

                        Letraepicarda2 = Letradefinitiva.Next(palabradefinitiva.Length);

                        if(palabradefinitiva.Length > 6)
                        {
                            Letraepicarda3 = Letradefinitiva.Next(palabradefinitiva.Length);
                        }

                    }*/

                    Letraepicarda1 = Letradefinitiva.Next(palabradefinitiva.Length);

                    Letraepicarda2 = Letradefinitiva.Next(palabradefinitiva.Length);

                    if (palabradefinitiva.Length > 6)
                    {
                        Letraepicarda3 = Letradefinitiva.Next(palabradefinitiva.Length);

                        Console.WriteLine("Las letras " + (Letraepicarda1 + 1) + " " + (Letraepicarda2 + 1) + " " + (Letraepicarda3 + 1) + " son " + palabradefinitiva[Letraepicarda1] + " " + palabradefinitiva[Letraepicarda2] + " " + palabradefinitiva[Letraepicarda3] + " y tiene " + palabradefinitiva.Length + " letras");
                    }
                    else
                    {
                        Console.WriteLine("Las letras " + (Letraepicarda1 + 1) + " " + (Letraepicarda2 + 1) + " son " + palabradefinitiva[Letraepicarda1] + " " + palabradefinitiva[Letraepicarda2] + " y tiene " + palabradefinitiva.Length + " letras");
                    }


                    Console.ReadLine();

                    Console.WriteLine("Dime que palabra crees que es?");
                    string palabrarespondida = Console.ReadLine();

                    if (palabrarespondida == palabradefinitiva)
                    {

                        Console.WriteLine("Acertaste!!!");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("NO ES ESA >:(");
                        vidas--;
                        Console.WriteLine("Perdiste una vida, te quedan " + vidas);

                    }

                    Console.WriteLine("Dime que palabra crees que es?");
                    string palabrarespondida2 = Console.ReadLine();

                    if (palabrarespondida2 == palabradefinitiva)
                    {

                        Console.WriteLine("Acertaste!!!");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("NO ES ESA >:(");
                        vidas--;
                        Console.WriteLine("Perdiste una vida, te quedan " + vidas);

                    }

                    Console.WriteLine("Dime que palabra crees que es?");
                    string palabrarespondida3 = Console.ReadLine();

                    if (palabrarespondida3 == palabradefinitiva)
                    {

                        Console.WriteLine("Acertaste!!!");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("NO ES ESA >:(");
                        vidas--;
                        Console.WriteLine("Perdiste una vida, te quedan " + vidas);

                    }


                    Console.WriteLine("Dime que palabra crees que es?");
                    string palabrarespondida4 = Console.ReadLine();

                    if (palabrarespondida4 == palabradefinitiva)
                    {

                        Console.WriteLine("Acertaste!!!");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("NO ES ESA >:(");
                        vidas--;
                        Console.WriteLine("Perdiste una vida, te quedan " + vidas);

                    }

                    Console.WriteLine("Dime que palabra crees que es?");
                    string palabrarespondida5 = Console.ReadLine();

                    if (palabrarespondida5 == palabradefinitiva)
                    {

                        Console.WriteLine("Acertaste!!!");
                        break;

                    }
                    else
                    {

                        Console.WriteLine("NO ES ESA >:(");
                        vidas--;
                        Console.WriteLine("Perdiste la partida... "); //Por malo
                        break;

                    }


                    break;

                case 26:

                    Console.WriteLine("****Ejercicio26****");

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

                    }
                    catch (IOException e)
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
                                //Vemos si existe el DNI que buscamos
                                //Obtenemos la cadena que hay antes del asterisco
                                if (s == null)
                                {
                                    Console.WriteLine("DNI no encontrada.");
                                    break;
                                }
                                String[] trozos = s.Split('*');
                                if (DNI.Equals(trozos[0], StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("Registro encontrado: ");
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
                    Console.ReadLine();
                    break;
            }
        }
    }
}
