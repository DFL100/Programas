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
    public partial class Ejercicio_7 : Form
    {
        public Ejercicio_7()
        {
            InitializeComponent();
        }

        double euros = 0;
        double dolares = 0;
        private void txteuro_TextChanged(object sender, EventArgs e)
        {
            euros = double.Parse(txteuro.Text);
        }

        private void txtdolar_TextChanged(object sender, EventArgs e)
        {
            dolares = double.Parse(txtdolar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 dolar = 0,92 euros
            txteuro.Text = (dolares * 0.92).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  0,92 euros = 1 dolar 
            txtdolar.Text = (euros * 1.09).ToString();
        }
    }
}
