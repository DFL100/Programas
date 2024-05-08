using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema10
{
    public partial class Ejercicio2 : Form
    {



        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GMI1_CheckedChanged(object sender, EventArgs e)
        {

            {

                if (GMI1.Checked)
                {
                    GMI2.Checked = false; //Deseleccionar GMI2 si GMI1 está seleccionado
                    GMI1.Checked = true; //Asegurarse de que GMI1 esté seleccionado
                }

                if (GMI1.Checked)
                {

                    listBox1.Items.Clear();
                    listBox1.Items.Add("Redes");
                    listBox1.Items.Add("Programación");
                    listBox1.Items.Add("Ofimática");
                    listBox1.Items.Add("Montaje");
                    listBox1.Items.Add("SOM");
                    listBox1.Items.Add("FOL");

                    /*Obtener la asignatura
                    string asignatura = listBox1.SelectedItem.ToString();


                    switch (asignatura)
                    {
                        case "Redes":
                            MessageBox.Show("Fran");
                            break;
                        case "Programación":
                            MessageBox.Show("Ramón");
                            break;
                        case "Ofimática":
                            MessageBox.Show("Martín");
                            break;
                        case "Montaje":
                            MessageBox.Show("Alverto");
                            break;
                        case "SOM":
                            MessageBox.Show("El mismisimo Enrique Prieto Magán");
                            break;
                        case "FOL":
                            MessageBox.Show("Dani");
                            break;

                    }*/
                }

            }

        }

        private void GMI2_CheckedChanged(object sender, EventArgs e)
        {
            if (GMI2.Checked)
            {
                GMI1.Checked = false; //Deseleccionar GMI1 si GMI2 está seleccionado
                GMI2.Checked = true; //Asegurarse de que GMI2 esté seleccionado
            }

            if (GMI2.Checked)
            {

                listBox1.Items.Clear();
                listBox1.Items.Add("Redes2");
                listBox1.Items.Add("Programación2");
                listBox1.Items.Add("Ofimática2");
                listBox1.Items.Add("Montaje2");
                listBox1.Items.Add("SOM2");
                listBox1.Items.Add("FOL2");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox
            listBox1.Focus();

            if (listBox1.SelectedItem != null)
            {
                string asignatura = listBox1.SelectedItem.ToString();

                switch (asignatura)
                {
                    case "Redes":
                        MessageBox.Show("Fran");
                        break;
                    case "Programación":
                        MessageBox.Show("Ramón");
                        break;
                    case "Ofimática":
                        MessageBox.Show("Martín");
                        break;
                    case "Montaje":
                        MessageBox.Show("Alverto");
                        break;
                    case "SOM":
                        MessageBox.Show("El mismisimo Enrique Prieto Magán");
                        break;
                    case "FOL":
                        MessageBox.Show("Dani");
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio_5 Ejercicio5 = new Ejercicio_5();
            Ejercicio5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio_6 Ejercicio6 = new Ejercicio_6();
            Ejercicio6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio_7 Ejercicio7 = new Ejercicio_7();
            Ejercicio7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio_8 Ejercicio8 = new Ejercicio_8();
            Ejercicio8.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio_9 Ejercicio9 = new Ejercicio_9();
            Ejercicio9.ShowDialog();
        }
    }
}
