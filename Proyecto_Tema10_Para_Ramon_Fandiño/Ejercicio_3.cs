using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tema10_Para_Ramon_Fandiño
{
    public partial class Ejercicio_3 : Form
    {
        double dato = 0;

        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Milimetros
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Centimetros
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Decimetros
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Kilometros
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TXTDato

            //Manejar posibles excepciones al intentar convertir el texto a double
            if (double.TryParse(textBox1.Text, out dato))
            {
                //Actualizar el valor de dato solo si la conversión fue exitosa
                dato = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                //Mostrar un mensaje de error al usuario si el valor no es válido
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TXTResultado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BTNconvertir
            if (radioButton1.Checked)
            {
                dato = dato * 1000;
            }
            if (radioButton2.Checked)
            {
                dato = dato * 100;
            }
            if (radioButton3.Checked)
            {
                dato = dato * 10;
            }
            if (radioButton4.Checked)
            {
                dato = dato / 1000;
            }

            //Enseñarlo en la textbox2
            textBox2.Text = dato.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BTNnuevo calculo
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BTNsalir
            this.Close();
        }
    }
}
