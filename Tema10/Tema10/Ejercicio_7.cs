using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema10
{
    public partial class Ejercicio_7 : Form
    {

        int contador = 100;
        public Ejercicio_7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador--;
            textBox1 .Text = contador.ToString();
            if(contador == 0)
            {
                //Parar timer
                timer1 .Stop();
            } 

            //Mover el PictureBox horizontalmente
            pictureBox1.Left += 5; //Ajusta el valor según la velocidad de movimiento

        }

        private void Ejercicio_7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Detener
            timer1.Stop(); //Detener el Timer
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reiniciar
            timer1.Start(); //Reiniciar el Timer
        }
    }
}
