using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PreexamenT8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caso = 0;
            Console.WriteLine("Escribe caso anda");
            caso = int.Parse(Console.ReadLine());

            switch (caso)
            {
                case 1:

                    //Creamos lista
                    List<string> Lista1 = new List<string>();

                    //Añadimos valores a la lista
                    Lista1.Add("qwerty");
                    Lista1.Add("a");

                    //Creamos Directorio (keyValuePairs)
                    Dictionary<int, string> Diccionario1 = new Dictionary<int, string>();

                    //Añadimos un valor a la lista
                    Console.WriteLine("Escribe algo para l Lista");
                    string Valorlista1 = Console.ReadLine();

                    if (Valorlista1 != null)
                    {
                        Lista1.Add(Valorlista1);
                    }

                    //Mostramos la lista
                    Console.WriteLine("\n \nLos valores de la lista son:");
                    foreach (string Valor in Lista1)
                    {
                        if (Valor != null)
                        {
                            Console.WriteLine(Valor);
                        }

                    }
                    Console.ReadLine();

                    //Añadimos Key y Valor al Diccionario
                    Console.WriteLine("\nAhora escribe un valor");
                    string valor1 = Console.ReadLine();

                    Boolean comprobador; //Igual a true
                    int clave1 = 0;

                    do
                    {
                        try
                        {

                            Console.WriteLine("Ahora escribe la clave numérica para ese valor");
                            clave1 = int.Parse(Console.ReadLine());
                            comprobador = true;

                        }
                        catch (FormatException)

                        {

                            comprobador = false;

                        }
                    } while (comprobador == false);

                    string ValorDiccionario1 = clave1 + "*" + valor1;
                    Diccionario1.Add(clave1, valor1);

                    //Muestro los valores de key y de "valor" que tiene el Diccionario
                    foreach (KeyValuePair<int, string> i in Diccionario1)
                    {

                        Console.WriteLine(i.Key + "*" + i.Value);

                    }

                    //Buscar valor de lista
                    /*Console.WriteLine("Dime qué valor de la lista quieres buscar:");
                    string valorABuscar = Console.ReadLine();

                    int indice = Lista1.IndexOf(valorABuscar);

                    if (indice != -1)
                    {
                        Console.WriteLine($"El valor '{valorABuscar}' se encuentra en la posición: {indice}");
                    }
                    else
                    {
                        Console.WriteLine($"El valor '{valorABuscar}' no está en la lista.");
                    }

                    List<int> indices = new List<int>();

                    for (int i = 0; i < Lista1.Count; i++)
                    {
                        if (Lista1[i] == valorABuscar)
                        {
                            indices.Add(i);
                        }
                    }

                    if (indices.Count > 0)
                    {
                        Console.WriteLine($"El valor '{valorABuscar}' se encuentra en las siguientes posiciones:");
                        foreach (int i in indices)
                        {
                            Console.WriteLine($" - Índice: {i}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El valor '{valorABuscar}' no se encuentra en la lista.");
                    }*/

                    Console.WriteLine("Que variable quieres buscar en la lista?");
                    string buscar1 = Console.ReadLine();
                    int contador = -1;

                    foreach (string i in Lista1)
                    {
                        if (i == buscar1)
                        {
                            Console.WriteLine("La variable " + i + " está en la posición " + contador);
                        }
                        contador++;
                    }

                    Console.ReadLine();

                    break;

                case 2:

                    HashSet<string> set1 = new HashSet<string>();
                    string a = "Hola";
                    string b = "Adios";
                    string c = "Azul";
                    string d = "Carallo";
                    string e = "qwerty";

                    set1.Add(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);

                    foreach (string i in set1)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    break;

                case 3:

                    Dictionary<int,string> dic1 = new Dictionary<int,string>(99999999);
                    int key1 = 1234;
                    string val1 = "Primero";

                    dic1.Add(key1, val1);

                    foreach(KeyValuePair<int ,string> i in dic1)
                    {

                        Console.WriteLine(i.Key + "*" + i.Value);

                    }

                    string buscarclave = dic1[1234];
                    Console.WriteLine("La busqueda da " + buscarclave);

                    Console.WriteLine("\nAhora dime tu un valor a buscar desde la key");
                    int buscakey2 = int.Parse(Console.ReadLine());

                    if (dic1.ContainsKey(buscakey2))                    
                    {
                        Console.WriteLine("El valor es " + dic1[buscakey2]);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado el valor");
                    }

                    Console.WriteLine("La capacidad es de " + dic1.Count);
                    

                    Console.ReadLine();
                    break;

                case 4:

                    List<string> list = new List<string>();

                    string a1 = "qwerty";
                    string a2 = "ytrew";
                    string a3 = "qazxsw";
                    string a4 = "a1a2";
                    string a5 = "a3a2a1";
                    string a6 = "q1w2";

                    list.Add(a1);
                    list.Add(a2);
                    list.Add(a3);
                    list.Add(a4);
                    list.Add(a5);
                    list.Add(a6);

                    foreach(string i in list)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Ahora solo los de >5 carácteres");
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Length > 5)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    Console.ReadLine();

                    break;

                case 5:

                    List<string> lista5 = new List<string>();

                    string b1 = "qwerty";
                    string b2 = "ytrew";
                    string b3 = "qazxsw";
                    string b4 = "a1a2";
                    string b5 = "a3a2a1";
                    string b6 = "q1w2";

                    lista5.Add(b1);
                    lista5.Add(b2);
                    lista5.Add(b3);
                    lista5.Add(b4);
                    lista5.Add(b5);
                    lista5.Add(b6);

                    foreach(string i in lista5)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Digame un valor a eliminar");
                    string eliminar5 = Console.ReadLine();

                    for(int i = 0; i < lista5.Count; i++)
                    {
                        if (lista5[i] == eliminar5)
                        {
                            lista5.RemoveAt(i);

                            i--;
                        }
                    }


                    Console.WriteLine("La lista se quedo en: ");
                    foreach (string i in lista5)
                    {
                        Console.WriteLine(i);
                    }

                    Console.ReadLine();
                    break;

                case 6:

                    Dictionary<int, string> dic5 = new Dictionary<int, string>();

                    dic5.Add(1234, "hola");
                    dic5.Add(4321, "adios");
                    dic5.Add(2413, "hasta luego");
                    dic5.Add(1324, "Ramón");
                    dic5.Add(4231, "Sanchez");
                    dic5.Add(3142, "Real Madrid");

                    foreach (KeyValuePair<int, string> i in dic5)
                    {
                        Console.WriteLine(i.Key + ", " + i.Value);
                    }

                    Console.WriteLine("Busca uno de los datos desde su key");
                    int key5 = int.Parse(Console.ReadLine());

                   foreach(KeyValuePair<int,string>s in  dic5)
                    {
                        if(key5 == s.Key) 
                        { 
                            Console.WriteLine(s.Value); 
                        }
                    }

                    Console.WriteLine("Ahora busca pos su valor");
                    string valor5 = Console.ReadLine();

                    foreach(KeyValuePair <int,string>s in dic5)
                    {
                        if(valor5 == s.Value)
                        {
                            Console.WriteLine(s.Key);
                        }
                    }

                    Console.WriteLine("Ahora dime una key a eliminar");
                    int keydelete = int.Parse(Console.ReadLine());

                    if (dic5.ContainsKey(keydelete))
                    {
                        dic5.Remove(keydelete);
                        Console.WriteLine("Se ha eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la key");
                    }

                    foreach(KeyValuePair<int,string> s in dic5)
                    {
                        Console.WriteLine(s.Key + ", " + s.Value);
                    }
                    Console.ReadLine() ;


                    Console.WriteLine("Ahora dime un valor a eliminar");
                    string valoreliminar = Console.ReadLine();

                    if (dic5.ContainsValue(valoreliminar))
                    {
                        dic5.Remove(int.Parse(valoreliminar));
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("No se encntró el valor");
                    }

                    foreach (KeyValuePair<int, string> s in dic5)
                    {
                        Console.WriteLine(s.Key + ", " + s.Value);
                    }
                    Console.ReadLine();
                    
                    


                    break;
            }

            
        }
    }
}
