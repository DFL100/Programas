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
    public partial class Calculadora_EJ8 : Form
    {
        public Calculadora_EJ8()
        {
            InitializeComponent();
        }

        /*Valores numéricos
        int cero = 0;
        int uno = 1;
        int dos = 2;
        int tres = 3;
        int cuatro = 4;
        int cinco = 5;
        int seis = 6;
        int siete = 7;
        int ocho = 8;
        int nueve = 9;*/
        //Calculos
        bool suma = false;
        bool resta = false;
        bool division = false;
        bool multiplicacion = false;
        //Valores
        double valorGuardado1 = 0;
        double valorGuardado2 = 0;
        //Verificar
        bool verificacionsuma = false;

        //Le metemos los valores númericos

        private void btn7_Click(object sender, EventArgs e)
        {
            //siete
            //Al pulsar este botón coge el texto del botón y lo pone en la memoria
            Button btn = sender as Button;

            //En la caja de texto une botones
            textBox1.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //ocho
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //nueve
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //cuatro
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //cinco
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //seis
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //uno
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //dos
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //tres
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //cero
            /*btn0.Text = cero.ToString();
            textBox1.Text = cero.ToString();*/
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //Verifica si hay texto en el TextBox

            if (textBox1.Text.Length > 0) 
            {
                //Método substring para eliminar el último número del textbox1 y actiualizarlo después
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); 
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //Borrar todo lo de la textbox1
            textBox1.Text = "";

            //Poner los dos valores a cero
            valorGuardado1 = 0;
            valorGuardado2 = 0;
        }

        private void btndecimales_Click(object sender, EventArgs e)
        {
            //Esto es para ver que no haya más de una coma en el textbox1 
            if (!textBox1.Text.Contains(","))
            {
                //Aquí se la pone si no hay ninguna otra
                textBox1.Text += ",";
            }
        }

        private void btnbinario_Click(object sender, EventArgs e)
        {
            //Primero veo si la textbox1 no está vacía
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //Luego intento convertir el texto a un número binario
                if (double.TryParse(textBox1.Text, out double numero))
                {
                    // Convierte el número a binario (con el dos del final)
                    string binario = Convert.ToString((int)numero, 2);
                    // Actualiza el contenido del TextBox1 a binario
                    textBox1.Text = binario;
                }
                else
                {
                    //Si no puede te lo dice en un mensaje con el show
                    MessageBox.Show("Por favor, pon un número valido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Si lo del principio no se cumple pues te enseña este error 
                MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            //Pasamos suma a true
            suma = true;
            //Ver que el textbox1 no esté vacio
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out double numero))
                {
                    //Almacenar el valor en valorguardado
                    valorGuardado1 = numero;
                    //Limpiar el contenido del TextBox1
                    textBox1.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (suma)
            {

                //Ver que el textbox1 no esté vacio
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (double.TryParse(textBox1.Text, out double numero))
                    {
                        //Almacenar el valor en valorguardado
                        valorGuardado2 = numero;
                        //Calcular la suma
                        double sumaa = valorGuardado1 + valorGuardado2;
                        textBox1.Text = sumaa.ToString();


                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El TextBox está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Pasamos todos los calculos a false
                suma = false;
                resta = false;
                multiplicacion = false;
                division = false;

            }//Corchete de la suma

            if (resta)
            {
                //Ver que el textbox1 no esté vacio
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (double.TryParse(textBox1.Text, out double numero))
                    {
                        //Almacenar el valor en valorguardado
                        valorGuardado2 = numero;
                        //Calcular la resta
                        double sumaa = valorGuardado1 - valorGuardado2;
                        textBox1.Text = sumaa.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Pasamos todos los calculos a false
                suma = false;
                resta = false;
                multiplicacion = false;
                division = false;

            }//Corchete resta

            if (division)
            {
                //Ver que el textbox1 no esté vacio
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (double.TryParse(textBox1.Text, out double numero))
                    {
                        //Almacenar el valor en valorguardado
                        valorGuardado2 = numero;
                        //Calcular la división
                        double sumaa = valorGuardado1 / valorGuardado2;
                        textBox1.Text = sumaa.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Pasamos todos los calculos a false
                suma = false;
                resta = false;
                multiplicacion = false;
                division = false;

            }//Corchete division

            if (multiplicacion)
            {
                //Ver que el textbox1 no esté vacio
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (double.TryParse(textBox1.Text, out double numero))
                    {
                        //Almacenar el valor en valorguardado
                        /*if(multiplicacion || suma || resta|| division)
                        {

                        }
                        else
                        {
                            valorGuardado2 = numero;
                        }*/
                        valorGuardado2 = numero;
                        //Calcular la multiplicación
                        double sumaa = valorGuardado1 * valorGuardado2;
                        textBox1.Text = sumaa.ToString();
                        valorGuardado1 = sumaa;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Pasamos todos los calculos a false
                suma = false;
                resta = false;
                multiplicacion = false;
                division = false;

            }//Corchete multiplicación

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //Pasar resta a true
            resta = true;
            //Ver que el textbox1 no esté vacio
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out double numero))
                {
                    //Almacenar el valor en valorguardado
                    valorGuardado1 = numero;
                    //Limpiar el contenido del TextBox1
                    textBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            //Pasamos división a true
            division = true;
            //Ver que el textbox1 no esté vacio
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out double numero))
                {
                    //Almacenar el valor en valorguardado
                    valorGuardado1 = numero;
                    //Limpiar el contenido del TextBox1
                    textBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            //Pasamos multiplicacion a true
            multiplicacion = true;
            //Ver que el textbox1 no esté vacio
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out double numero))
                {
                    //Almacenar el valor en valorguardado
                    /*if (multiplicacion || suma || resta || division)
                    {
                        verificacionsuma = true;
                        valorGuardado2 = numero;
                    }
                    else
                    {
                        valorGuardado1 = numero;
                    }*/
                    valorGuardado1 = numero;
                    //Limpiar el contenido del TextBox1
                    textBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("Por favor, escribe un número válido.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El TextBox está vacío.", "Error 404:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
