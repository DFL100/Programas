using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalDefinitivo_Diego.Fandiño.López
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Timer_____________________________________________________
            timer1.Interval = 25; //Tiempo del timer en milisegundos
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            //_________________________________________________________^

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //Imagen que se mueve___________________________________________________________

        int imageSpeed = 5; //Velocidad de movimiento de la imagen
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Imagen que se mueve1
            //Mover la imagen a la derecha
            pictureBox3.Left += imageSpeed;
            pictureBox4.Left += imageSpeed;

            //Verificar si la imagen ha alcanzado el borde derecho del formulario
            if (pictureBox3.Right >= this.ClientSize.Width)
            {
                //Volver la imagen al inicio a la izquierda
                pictureBox3.Left = 0 - pictureBox1.Width;
            }
            if (pictureBox4.Right >= this.ClientSize.Width)
            {
                //Volver la imagen al inicio a la izquierda
                pictureBox4.Left = 0 - pictureBox1.Width;
            }
            //_____________________________________________________________________________^


        }

        private void btnOrdenadores_Click(object sender, EventArgs e)
        {
            F_Ordenadores Apartado1 = new F_Ordenadores();
            Apartado1.ShowDialog();
        }

        private void btnMoviles_Click(object sender, EventArgs e)
        {
            F_Moviles Apartado2 = new F_Moviles();
            Apartado2.ShowDialog();
        }
    }
}
