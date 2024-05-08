using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tema10_Para_Ramon_Fandiño
{
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }


        string nombre1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre1 = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Items.Add(nombre1);
            }
            if(radioButton2.Checked)
            {
                listBox1.Items.Add(nombre1);
            }

        }
        string ruta = Directory.GetCurrentDirectory() + "\\F.R.A.N.";

        private void button2_Click(object sender, EventArgs e)
        {
            string datos = textBox1.Text;
            StreamWriter FRAN = new StreamWriter(ruta, true);
            FRAN.WriteLine("- " + datos);
            FRAN.Close();
        }
    }
}
