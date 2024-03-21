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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        int valorcuadrado;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valorcuadrado = Convert.ToInt32(textBox1.Text);
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El área del cuadrado es " + valorcuadrado * 2);
        }

        int ladomayor;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ladomayor = int.Parse(textBox2.Text);
        }

        int ladomenor;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ladomenor = int.Parse(textBox3.Text);
        }

        private void Rectángulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El área del réctangulo es  " + ladomenor * ladomayor);
        }

        int valorbaset;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            valorbaset = int.Parse(textBox4.Text);
        }

        int valoralturat;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            valoralturat = int.Parse(textBox5.Text);
        }

        private void Triangulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La base del triangulo es " + (valoralturat * valorbaset) / 2);
        }
    }
}
