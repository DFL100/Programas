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
    public partial class Ejercicio_8 : Form
    {
        public Ejercicio_8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        Random random = new Random(); // Crear un único objeto Random
        private void button1_Click(object sender, EventArgs e)
        {
            /*  Random dado1 = new Random();
              Random dado2 = new Random();
              Random dado3 = new Random();
              Random dado4 = new Random();

              int Dado1 = 0;
              int Dado2 = 0;
              int Dado3 = 0;
              int Dado4 = 0;

              for (int i = 0; i < 4; i++)
              {
                  Dado1 = dado1.Next(1, 7);
                  Dado2 = dado2.Next(1, 7);
                  Dado3 = dado3.Next(1, 7);
                  Dado4 = dado4.Next(1, 7);
              }*/

            int Dado1 = 0;
            int Dado2 = 0;
            int Dado3 = 0;
            int Dado4 = 0;

            // Generar los valores de los dados
            Dado1 = random.Next(1, 7);
            Dado2 = random.Next(1, 7);
            Dado3 = random.Next(1, 7);
            Dado4 = random.Next(1, 7);


            // Dado1
            if (Dado1 == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (Dado1 == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (Dado1 == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (Dado1 == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (Dado1 == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            else if (Dado1 == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }

            // Dado2
            if (Dado2 == 1)
            {
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (Dado2 == 2)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (Dado2 == 3)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = true;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (Dado2 == 4)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (Dado2 == 5)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
            }
            else if (Dado2 == 6)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = true;
            }

            // Dado3
            if (Dado3 == 1)
            {
                pictureBox18.Visible = true;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
            }
            else if (Dado3 == 2)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = true;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
            }
            else if (Dado3 == 3)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = true;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
            }
            else if (Dado3 == 4)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = true;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
            }
            else if (Dado3 == 5)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = true;
                pictureBox13.Visible = false;
            }
            else if (Dado3 == 6)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = true;
            }

            // Dado4
            if (Dado4 == 1)
            {
                pictureBox24.Visible = true;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
            }
            else if (Dado4 == 2)
            {
                pictureBox24.Visible = false;
                pictureBox23.Visible = true;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
            }
            else if (Dado4 == 3)
            {
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = true;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
            }
            else if (Dado4 == 4)
            {
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = true;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
            }
            else if (Dado4 == 5)
            {
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = true;
                pictureBox19.Visible = false;
            }
            else if (Dado4 == 6)
            {
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = true;
            }

        }
    }
}
