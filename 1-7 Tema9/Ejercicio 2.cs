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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        string dia;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        int mes;
        string mesS;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            

        }
            

        string año;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            año = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            dia = textBox1.Text;
            mes = int.Parse(textBox2.Text);

            if (mes == 1)
            {
                mesS = "Enero";
            }
            else if (mes == 2)
            {
                mesS = "Febrero";
            }
            else if (mes == 3)
            {
                mesS = "Marzo";
            }
            else if (mes == 4)
            {
                mesS = "Abril";
            }
            else if (mes == 5)
            {
                mesS = "Mayo";
            }
            else if (mes == 6)
            {
                mesS = "Junio";
            }
            else if (mes == 7)
            {
                mesS = "Julio";
            }
            else if (mes == 8)
            {
                mesS = "Agosto";
            }
            else if (mes == 9)
            {
                mesS = "Septiembre";
            }
            else if (mes == 10)
            {
                mesS = "Octubre";
            }
            else if (mes == 11)
            {
                mesS = "Noviembre";
            }
            else if (mes == 12)
            {
                mesS = "Diciembre";
            }


            textBox4.Visible = true;
            textBox4.Text = dia + " de " + mesS + " de " + año;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = " ";
            textBox2.ResetText();
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //bool a = false;
            //do
            //{
                Escoge_ejercicio Ejercicio2 = new Escoge_ejercicio();
                Ejercicio2.ShowDialog();
            //}
            //while (a = true);
            //Quitar comentarios para bromita
            
        }

        private void Ejercicio_2_Load(object sender, EventArgs e)
        {

        }
    }
}
