using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_7_Tema9
{
    public partial class Ejercicio_6 : Form
    {
        public Ejercicio_6()
        {
            InitializeComponent();
        }
        int gradosº = 0;
        int gradosF = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Convertimos el texto a entero
                gradosº = int.Parse(textBox1.Text); 
            }
            catch (FormatException)
            {
                //Por si hay una excepción
                gradosº = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Convertimos el texto a entero
                gradosF = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                //Por si hay una excepción
                gradosF = 0;
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            //(32 °F − 32) × 5 / 9 = 0 °C
            double cvgf = (gradosF - 32) * 5 / 9;
            textBox1.Text = cvgf.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(0 °C × 9 / 5) + 32 = 32 °F
            double cvgº = (gradosº *9 /5) + 32;
            textBox2.Text = cvgº.ToString();
        }
    }
}
