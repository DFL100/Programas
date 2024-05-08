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
    public partial class Ejercicio_1 : Form
    {

        //var

        double LaMulta = 0;

        decimal d100 = 0;
        decimal d500 = 0;
        decimal d200 = 0;
        decimal d80 = 0;
        decimal d300 = 0;
        decimal d150 = 0;

        bool b100 = false;
        bool b500 = false;
        bool b200 = false;
        bool b80 = false;
        bool b300 = false;
        bool b150 = false;

        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void btn_100_CheckedChanged(object sender, EventArgs e)
        {
            //100$

            if (btn_100.Checked)
            {
                b100 = true;
            }
            if (!btn_100.Checked)
            {
                b100 = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //500$

            if (checkBox1.Checked)
            {
                b500 = true;
            }
            if (!checkBox1.Checked)
            {
                b500 = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //200$

            if (checkBox2.Checked)
            {
                b200 = true;
            }
            if (!checkBox2.Checked)
            {
                b200 = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //80$

            if (checkBox3.Checked)
            {
                b80 = true;
            }
            if (!checkBox3.Checked)
            {
                b80 = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //300$

            if (checkBox4.Checked)
            {
                b300 = true;
            }
            if (!checkBox4.Checked)
            {
                b300 = false;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //150$

            if (checkBox5.Checked)
            {
                b150 = true;
            }
            if (!checkBox5.Checked)
            {
                b150 = false;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //100$ mas menos
            if(b100 = true)
            {
                d100 = numericUpDown1.Value;
            }
            if(b100 = false)
            {
                d100 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(d100 * 100);

            //Volver a pasar todo a 0
            d100 = 0;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //500$ mas menos
            if(b500 = true)
            {
                d500 = numericUpDown2.Value;
            }
            if (b500 = false)
            {
                d500 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(d500 * 500);

            //Volver a pasar todo a 0
            d500 = 0;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //200$ mas menos
            if(b200 = true)
            {
                d200 = numericUpDown3.Value;
            }
            if (b200 = false)
            {
                d200 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(d200 * 200);

            //Volver a pasar todo a 0
            d200 = 0;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //80$ mas menos
            if(b80 = true)
            {
                d80 = numericUpDown4.Value;
            }
            if (b80 = false)
            {
                d80 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(d80 * 80);

            //Volver a pasar todo a 0
            d80 = 0;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            //300$ mas menos
            if(b300 = true)
            {
                d300 = numericUpDown5.Value;
            }
            if (b300 = false)
            {
                d300 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(numericUpDown5.Value * 300);

            //Volver a pasar todo a 0
            d300 = 0;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            //150$ mas menos
            if(b150 = true)
            {
                d150 = numericUpDown6.Value;
            }
            if(b150 = false)
            {
                d150 = 0;
            }
            //Recoger si tiene algún valor para la multa jeje
            LaMulta += Convert.ToDouble(d150 * 150);

            //Volver a pasar todo a 0
            d150 = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(LaMulta);

            LaMulta = 0;
        }
    }
}
