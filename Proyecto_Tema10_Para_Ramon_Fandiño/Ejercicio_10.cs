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
    public partial class Ejercicio_10 : Form
    {
        public Ejercicio_10()
        {
            InitializeComponent();
        }


        //Jugadores
        bool jugadorX = false;
        bool jugadorO = false;
        //Cambiar jugador
        bool cambio = true;
           //True --> JugadorX
           //False --> JugadorO
        private void Ejercicio_10_Load(object sender, EventArgs e)
        {
            if (button1.Text == "X" && button2.Text =="X" && button3.Text =="X")
            {
                MessageBox.Show("Gana X");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Botón X

            jugadorX = true;
            jugadorO = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Botón O
            
                jugadorX = false;
                jugadorO = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón1

            //Forma manual

            if (jugadorX == true)
            {
                button1.Text = "X";
                return;
            }
            if(jugadorO == true)
            {
                button1.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if(cambio == true)
            {
                button1.Text = "X";
            }
            if(cambio == false)
            {
                button1.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón 2

            //Forma manual

            if (jugadorX == true)
            {
                button2.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button2.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button2.Text = "X";
            }
            if (cambio == false)
            {
                button2.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Botón automático

            jugadorX = false;
            jugadorO = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botón 3

            //Forma manual

            if (jugadorX == true)
            {
                button3.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button3.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button3.Text = "X";
            }
            if (cambio == false)
            {
                button3.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botón 4

            //Forma manual

            if (jugadorX == true)
            {
                button4.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button4.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button4.Text = "X";
            }
            if (cambio == false)
            {
                button4.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botón 5

            //Forma manual

            if (jugadorX == true)
            {
                button5.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button5.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button5.Text = "X";
            }
            if (cambio == false)
            {
                button5.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Botón 6

            //Forma manual

            if (jugadorX == true)
            {
                button6.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button6.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button6.Text = "X";
            }
            if (cambio == false)
            {
                button6.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Botón 7

            //Forma manual

            if (jugadorX == true)
            {
                button7.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button7.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button7.Text = "X";
            }
            if (cambio == false)
            {
                button7.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Botón 8

            //Forma manual

            if (jugadorX == true)
            {
                button8.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button8.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button8.Text = "X";
            }
            if (cambio == false)
            {
                button8.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Botón 9

            //Forma manual

            if (jugadorX == true)
            {
                button9.Text = "X";
                return;
            }
            if (jugadorO == true)
            {
                button9.Text = "O";
                return;
            }

            //_________________________________________

            //Forma automática

            if (cambio == true)
            {
                button9.Text = "X";
            }
            if (cambio == false)
            {
                button9.Text = "O";
            }

            //Cambio de jugador
            if (cambio == true)
            {
                cambio = false;
                return;
            }
            if (cambio == false)
            {
                cambio = true;
                return;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }
    }
}
