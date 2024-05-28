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
    public partial class F_Moviles : Form
    {
        public F_Moviles()
        {
            InitializeComponent();
            //Diego Fandiño López
        }

        private void Visible()
        {
            lblTelefono1.Visible = true;
            lblTelefono2.Visible = true;
            lblTelefono3.Visible = true;
            lblPrecio1.Visible = true;
            lblPrecio2.Visible = true;
            lblPrecio3.Visible = true;
            lblDolorosa1.Visible = true;
            lblDolorosa2.Visible = true;
            lblDolorosa3.Visible = true;
            lblEuro1.Visible = true;
            lblEuro2.Visible = true;
            lblEuro3.Visible = true;
            Este1.Visible = false;
            Este2.Visible = false;
            Este3.Visible = false;
            flecha1.Visible = false;
            flecha2.Visible = false;
            flecha3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Xiaomi
            if (radioButton3.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;

                lblTelefono1.Text = "REDMI NOTE 13";
                lblTelefono2.Text = "Poco F6 Pro";
                lblTelefono3.Text = "Xiaomi 13 Pro";
                lblDolorosa1.Text = "185";
                lblDolorosa2.Text = "499";
                lblDolorosa3.Text = "871";
                Xiaomi1.Visible = true;
                Xiaomi2.Visible = true;
                Xiaomi3.Visible = true;
                OPPO1.Visible = false;
                OPPO2.Visible = false;
                OPPO3.Visible = false;
                Samsung1.Visible = false;
                Samsung2.Visible = false;
                Samsung3.Visible = false;
                Visible();
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //OPPO
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                lblTelefono1.Text = "OPPO A79 5G";
                lblTelefono2.Text = "OPPO Find X5";
                lblTelefono3.Text = "OPPO Find X2 PRO";
                lblDolorosa1.Text = "161";
                lblDolorosa2.Text = "369";
                lblDolorosa3.Text = "743";
                OPPO1.Visible = true;
                OPPO2.Visible = true;
                OPPO3.Visible = true;
                Xiaomi1.Visible = false;
                Xiaomi2.Visible = false;
                Xiaomi3.Visible = false;
                Samsung1.Visible = false;
                Samsung2.Visible = false;
                Samsung3.Visible = false;
                Visible();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Samsung
            if (radioButton1.Checked)
            {
                radioButton3.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;

                lblTelefono1.Text = "Galaxy A53";
                lblTelefono2.Text = "Galaxy S23";
                lblTelefono3.Text = "Galaxy S24 Ultra";
                lblDolorosa1.Text = "264";
                lblDolorosa2.Text = "599";
                lblDolorosa3.Text = "1385";
                Samsung1.Visible = true;
                Samsung2.Visible = true;
                Samsung3.Visible = true;
                OPPO1.Visible = false;
                OPPO2.Visible = false;
                OPPO3.Visible = false;
                Xiaomi1.Visible = false;
                Xiaomi2.Visible = false;
                Xiaomi3.Visible = false;
                Visible();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;

                MessageBox.Show("¡¡ERROR FATAL!! \nNo lo vuelva a intentar.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show("El programa no lo pudo soportar. \nTendremos que reiniciar de inmediato.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        int PrecioInicio = 0;
        int PrecioFin = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //+1000€
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

                PrecioInicio = 1000;
                PrecioFin = 2000;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //+700€
            if(checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

                PrecioInicio = 700;
                PrecioFin = 999;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //+400€
            if(checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;

                PrecioInicio = 400;
                PrecioFin = 699;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //-400€
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                PrecioInicio = 1;
                PrecioFin = 399;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            try
            {
                /*if(!checkBox1.Checked || !checkBox2.Checked || !checkBox3.Checked)
                {
                    PrecioInicio = 0;
                    PrecioFin = 0;
                }*/

                if (PrecioInicio == 0 || PrecioFin == 0)
                {
                    MessageBox.Show("Seleccione un precio para buscar.", "Estate atento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //Primer precio
                if (int.TryParse(lblDolorosa1.Text, out int lblPrecio1Value))
                {
                    if (lblPrecio1Value >= PrecioInicio && lblPrecio1Value <= PrecioFin)
                    {
                        //Precio dentro de rango
                        MessageBox.Show($"El precio {lblPrecio1Value} está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha1.Visible = true;
                        Este1.Visible = true;
                    }
                    else
                    {
                        //Precio fuera de rango
                        MessageBox.Show($"El precio {lblPrecio1Value} no está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha1.Visible = false;
                        Este1.Visible = false;
                    }
                }
                else
                {
                    //No se pudo convertir el texto del Label a un número entero
                    MessageBox.Show("El texto del Label 1 no se pudo convertir a un número válido.");
                }

                //Segundo precio
                if (int.TryParse(lblDolorosa2.Text, out int lblPrecio2Value))
                {
                    if (lblPrecio2Value >= PrecioInicio && lblPrecio2Value <= PrecioFin)
                    {
                        //Precio dentro de rango
                        MessageBox.Show($"El precio {lblPrecio2Value} está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha2.Visible = true;
                        Este2.Visible = true;
                    }
                    else
                    {
                        //Precio fuera de rango
                        MessageBox.Show($"El precio {lblPrecio2Value} no está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha2.Visible = false;
                        Este2.Visible = false;
                    }
                }
                else
                {
                    //No se pudo convertir el texto del Label a un número entero
                    MessageBox.Show("El texto del Label 2 no se pudo convertir a un número válido.");
                }

                //Tercer precio
                if (int.TryParse(lblDolorosa3.Text, out int lblPrecio3Value))
                {
                    if (lblPrecio3Value >= PrecioInicio && lblPrecio3Value <= PrecioFin)
                    {
                        //Precio dentro de rango
                        MessageBox.Show($"El precio {lblPrecio3Value} está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha3.Visible = true;
                        Este3.Visible = true;
                    }
                    else
                    {
                        //Precio fuera de rango
                        MessageBox.Show($"El precio {lblPrecio3Value} no está dentro del rango {PrecioInicio}-{PrecioFin}");
                        flecha3.Visible = false;
                        Este3.Visible = false;
                    }
                }
                else
                {
                    //No se pudo convertir el texto del Label a un número entero
                    MessageBox.Show("El texto del Label 3 no se pudo convertir a un número válido.");
                }
            }
            catch (Exception ex)
            {
                //Manejo de excepciones generales
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            PrecioInicio = 0;
            PrecioFin = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Componentes 1

            if (radioButton1.Checked)
            {
                MessageBox.Show("Procesador:Exynos 1280 \nRam: 6GB \nAlmacenamiento: 128GB \nCamara: Cuádruple, 64 MP + 12 MP + 5 MP + 5 MP", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Procesador: Dimensity 6020 \nRam: 8GB \nAlmacenamiento: 128GB \nCamara: 50 MP f/1.8 2 MP f/2.4", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Procesador: Qualcomm Snapdragon 685 \nRam: 8GB \nAlmacenamiento: 256 GB \nCamara: 108 megapíxeles, f/1.75", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Componentes 2

            if (radioButton1.Checked)
            {
                MessageBox.Show("Procesador: Snapdragon 8 Gen 2 for Samsung \nRam: 8GB \nAlmacenamiento: 512GB \nCamara: Principal de 50 Mpx f/1.8 OIS", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Procesador: Qualcomm Snapdragon 888 \nRam: 8GB \nAlmacenamiento: 256GB \nCamara: Principal: 50 megapíxeles f/1.8, IMX766", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Procesador: Snapdragon 8 Gen 2 \nRam: 12GB \nAlmacenamiento: 512GB \nCamara: Principal: 50MP,  f/1.6, OIS", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Componentes 3

            if (radioButton1.Checked)
            {
                MessageBox.Show("Procesador: Snapdragon 8 Gen 3 \nRam: 12GB \nAlmacenamiento: 1TB \nCamara: 200 MP, f/1.7, OIS", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Procesador: Qualcomm Snapdragon 865 \nRam: 12GB \nAlmacenamiento: 512GB \nCamara: Principal: 48MP", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Procesador: Snapdragon 8 Gen 2 \nRam: 12GB \nAlmacenamiento: 256GB \nCamara: 50 MP f/1.9", "Especificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
