using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _1_7_Tema9
{
    public partial class Ejercicio_9 : Form
    {

        //Renglón derecho
        string Nombre = "";
        string Apellidos = "";
        string Edad = "";
        string Email = "";
        string DNI = "";
        string FDN = "";

        //Lista gusrdar usuarios
        /*string Usuario = double.Parse(Nombre + ", " + Apellidos)
        List<Usuario> listaUsuarios = new List<Usuario>();*/

        // Crear una lista de cadenas para almacenar usuarios
        List<string> listaUsuarios = new List<string>();

        //Para movernos con los botónes
        int indiceUsuarioActual = 0;



        public Ejercicio_9()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Nombre
            //Guardamos el valor del nombre
            Nombre = textBox1.Text.ToString();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Apellidos
            //guardamos el valor del apellido
            Apellidos = textBox2.Text.ToString();
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Edad
            //Guardamos el valor de la edad
            Edad = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Email
            //Guardamos el valor del Email
            Email = textBox4.Text.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //DNI
            //guardamos el valor del Email
            DNI = textBox5.Text.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Fecha de nacimiento
            //Guardar fecha de nacimiento
            FDN = textBox6.Text.ToString();
        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            //Guardar Usuario

            //Verificar si todos los campos están completos
            if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Apellidos) &&
                !string.IsNullOrEmpty(Edad) && !string.IsNullOrEmpty(Email) &&
                !string.IsNullOrEmpty(DNI) && !string.IsNullOrEmpty(FDN))
            {
                //Todos los campos están completos, proceder a guardar el usuario


                //Verificar si el DNI está en la lista 
                if (listaUsuarios.Any(usuario => usuario.Contains("DNI: " + DNI)))
                {

                }
                else
                {
                    //Mostrar un mensaje de error indicando que el DNI ya está repetido
                    MessageBox.Show("El DNI ya está en la lista", "Campo repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //Crear una cadena con los datos para el usuario
                string nuevoUsuario = "Nombre: " + Nombre + ", Apellidos: " + Apellidos + ", Edad: " + Edad + ", Email: " + Email + ", DNI: " + DNI + ", FDN: " + FDN;

                //Agregamos lo de arriba a mi lista (los datos que añade el usuario)
                listaUsuarios.Add(nuevoUsuario);
            }
            else
            {
                //Mostrar un mensaje de error indicando que falta algún campo
                MessageBox.Show("Por favor, completa todos los campos antes de guardar el usuario.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }


        //Variable para guardar el índice del usuario buscado (para encontrarlo)
        int indiceUsuario = -1;
        private void button5_Click(object sender, EventArgs e)
        {
            //Buscar DNI

            

            //Recorrer la lista de usuarios
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                //Conseguir el usuario actual 
                string usuarioActual = listaUsuarios[i];

                //Ver si el usuario actual tiene el DNI buscado
                if (usuarioActual.Contains("DNI: " + DNI))
                {
                    //Guardar el índice del usuario que buscamos
                    indiceUsuario = i;
                    break; //Salir del bucle cuando encuentra el usuario
                }
            }

            //Ver si se encontró el usuario
            if (indiceUsuario != -1)
            {
                //Conseguir los datos del usuario encontrado
                string datosUsuarioEncontrado = listaUsuarios[indiceUsuario];

                //Aquí enseñamos el indice en la textbox
                textBox12.Text = listaUsuarios[indiceUsuario];

                //Lo mostramos también en el recuadro de Eliminar para dar la opción de quitarlo de la lista
                textBox13.Text = listaUsuarios[indiceUsuario];
            }
            else
            {
                //Si el usuario no está en la lista, mostrar un mensaje
                MessageBox.Show("El DNI no está en la lista de usuarios.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            //Eliminar el usuario de la lista
            listaUsuarios.RemoveAt(indiceUsuario);

            //Mostrar un mensaje indicando que el usuario fue eliminado
            MessageBox.Show("El usuario con el DNI " + DNI + " ha sido eliminado de la lista.", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Vaciar los textbox
            textBox12.Clear();
            textBox13.Clear();
        }


        public void MostrarUsuarioActual(List<string> listaUsuarios)
        {
            // Verificar si la lista de usuarios no está vacía
            if (listaUsuarios.Count > 0)
            {
                // Obtener el usuario actual en la lista
                string usuarioActual = listaUsuarios[indiceUsuarioActual];

                // Dividir la cadena del usuario actual en sus campos individuales
                string[] camposUsuario = usuarioActual.Split(',');

                //Poner cada campo a sus TextBox 
                textBoxNombre.Text = camposUsuario[0].Substring(camposUsuario[0].IndexOf(":") + 1).Trim();
                textBoxApellidos.Text = camposUsuario[1].Substring(camposUsuario[1].IndexOf(":") + 1).Trim();
                textBoxEdad.Text = camposUsuario[2].Substring(camposUsuario[2].IndexOf(":") + 1).Trim();
                textBoxEmail.Text = camposUsuario[3].Substring(camposUsuario[3].IndexOf(":") + 1).Trim();
                textBoxDNI.Text = camposUsuario[4].Substring(camposUsuario[4].IndexOf(":") + 1).Trim();
                //textBoxFDN.Text = camposUsuario[5].Substring(camposUsuario[5].IndexOf(":") + 1).Trim();
            }
            else
            {
                //Si la lista está vacía, limpiar todas las TextBox
                textBoxNombre.Clear();
                textBoxApellidos.Clear();
                textBoxEdad.Clear();
                textBoxEmail.Clear();
                textBoxDNI.Clear();
                //textBoxFDN.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón para ir hacia atras

            //Restamos el índice del usuario actual para ir hacia atras en la lista
            indiceUsuarioActual--;

            //Ver si llegamos al final de la lista
            if (indiceUsuarioActual < 0)
            {
                indiceUsuarioActual = listaUsuarios.Count - 1; // Ir al final de la lista
            }

            //Mostrar el usuario actual en las TextBox
            MostrarUsuarioActual(listaUsuarios);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botón ir para alante

            //Sumamos el índice del usuario para ir hacia alante en la lista
            indiceUsuarioActual++;

            //Ver si hemos llegamos al final de la lista
            if (indiceUsuarioActual >= listaUsuarios.Count)
            {
                indiceUsuarioActual = 0; //Volver al principio de la lista
            }

            //Enseñar el usuario actual en las TextBox
            MostrarUsuarioActual(listaUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Primer usuario de la lista

            //Ver si la lista tiene al menos un usuario
            if (listaUsuarios.Count > 0)
            {
                //Establecemos el índice del usuario al principio de la lista
                indiceUsuarioActual = 0;

                //Conseguimos el primer usuario en la lista
                string primerUsuario = listaUsuarios[0];

                //Actualizamos las TextBox con la información del primer usuario
                MostrarUsuarioActual(listaUsuarios);
            }
            else
            {
                //PONGO un mensaje diciendo que la lista está vacía
                MessageBox.Show("La lista de usuarios está vacía.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Último usuario de la lista

            //Ver si la lista tiene al menos un usuario
            if (listaUsuarios.Count > 0)
            {
                //Conseguimos el índice del último usuario en la lista
                int ultimoIndice = listaUsuarios.Count - 1;

                //Ponemos el último usuario en la lista
                string ultimoUsuario = listaUsuarios[ultimoIndice];

                //Actualizar las TextBox con la información del último usuario
                MostrarUsuarioActual(listaUsuarios);
            }
            else
            {
                //Enseñamos un mensaje indicando que la lista está vacía
                MessageBox.Show("La lista de usuarios está vacía.");
            }
        }
    }
}//TODOS LOS EJERCICIOS HECHOS POR DIEGO FANDIÑO LÓPEZ
//Github: DFL100

