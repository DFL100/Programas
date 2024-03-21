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
    public partial class Escoge_ejercicio : Form
    {
        public Escoge_ejercicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Ejercicio1 = new Form1();
            Ejercicio1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio_2 Ejercicio2 = new Ejercicio_2();
            Ejercicio2.ShowDialog();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ejercicio3 = new Ejercicio3();
            Ejercicio3.ShowDialog();
        }

        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio_4 Ejercicio4 = new Ejercicio_4();
            Ejercicio4.ShowDialog();
        }
    }
}
