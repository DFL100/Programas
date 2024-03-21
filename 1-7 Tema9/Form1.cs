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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        string nombre1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre1 = txtnombre.Text;
            
        }

        private void btnej1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre es " + nombre1 + " y el correo es " + correo);
        }


        string correo;
        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            correo = txtcorreo.Text;
        }
    }
}
