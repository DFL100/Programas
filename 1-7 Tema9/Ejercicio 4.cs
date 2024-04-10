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

namespace _1_7_Tema9
{
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int numerohoras;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numerohoras = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Son " + numerohoras * 60 + " minutos";
            textBox3.Text = "Son " + numerohoras * 3600 + " segundos";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }
    }
}
