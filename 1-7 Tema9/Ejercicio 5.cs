using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_7_Tema9
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        bool sumar = false;
        bool restar = false;
        bool multiplicar = false;
        bool dividir = false;

        int a1;
        int a2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a1 = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            a2 = int.Parse(textBox2.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            más.Visible = true;
            sumar = true;

        }

        private void Ejercicio_5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menoss.Visible = true;
            restar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            por.Visible = true;
            multiplicar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            entre.Visible = true;
            dividir = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            if (sumar)
            {
                textBox3.Text = (a1 + a2).ToString();
            }
            else if (dividir)
            {
                textBox3.Text = (a1 / a2).ToString();
            }
            else if (restar)
            {
                textBox3.Text = (a1 - a2).ToString();
            }
            else if (multiplicar)
            {
                textBox3.Text = (a1 * a2).ToString();
            }
            Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
