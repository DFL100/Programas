using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema10
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Textbox Nombre Empleado
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Captura el nombre ingresado por el usuario
            string nombre = textBox1.Text;

            //Verifica qué elemento está seleccionado en la ComboBox
            if (comboBox1.SelectedIndex == 0)
            {
                //Agrega el nombre al primer ListBox si el primer elemento está seleccionado en la ComboBox
                listBox1.Items.Add(nombre);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //Agrega el nombre al segundo ListBox si el segundo elemento está seleccionado en la ComboBox
                listBox2.Items.Add(nombre);
            }
            else
            {
                //Maneja cualquier otro caso (puede ser útil si la ComboBox tiene más opciones en el futuro)
                MessageBox.Show("Por favor, selecciona una opción válida en la ComboBox.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica si hay un elemento seleccionado en listBox1
            if (listBox1.SelectedItem != null)
            {
                //Agrega el elemento seleccionado de listBox1 a listBox2
                listBox2.Items.Add(listBox1.SelectedItem);

                //Remueve el elemento seleccionado de listBox1
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre en la primera lista para mover.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verifica si hay un elemento seleccionado en listBox2
            if (listBox2.SelectedItem != null)
            {
                //Agrega el elemento seleccionado de listBox2 a listBox1
                listBox1.Items.Add(listBox2.SelectedItem);

                //Remueve el elemento seleccionado de listBox2
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre en la segunda lista para mover.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agrega todos los elementos de listBox1 a listBox2
            listBox2.Items.AddRange(listBox1.Items);

            //Limpia listBox1
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Agrega todos los elementos de listBox2 a listBox1
            listBox1.Items.AddRange(listBox2.Items);

            //Limpia listBox2
            listBox2.Items.Clear();
        }
    }
}
