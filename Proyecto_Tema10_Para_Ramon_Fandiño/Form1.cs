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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio_1 Ejercicio_1 = new Ejercicio_1();
            Ejercicio_1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio_4 Ejercicio_4 = new Ejercicio_4();
            Ejercicio_4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio_3 Ejercicio_3 = new Ejercicio_3();
            Ejercicio_3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ejercicio_10 Ejercicio_10 = new Ejercicio_10();
            Ejercicio_10.ShowDialog();
        }
    }
}
