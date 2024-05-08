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
    public partial class Ejercicio_9 : Form
    {
        public Ejercicio_9()
        {
            InitializeComponent();
        }

        double Plato1 = 0;
        private void btnCrema_CheckedChanged(object sender, EventArgs e)
        {
            //Primer plato
            //Crema
            if (btnCrema.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Champiñones (4.0 €)");
                comboBox1.Items.Add("Puerros (5.0 €)");
                comboBox1.Items.Add("Zanahoria (4.75 €)");
            }
            
            //Champiñones
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Champiñones (4.0 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 4.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Puerros
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Puerros (5.0 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 5.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Zanahoria
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Zanahoria (4.75 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 4.75;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }
        }

        private void btnEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            //Primer plato
            //Ensalada
            if (btnEnsalada.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Primavera(3 €)");
                comboBox1.Items.Add("Romana (4 €)");
                comboBox1.Items.Add("Cesar (4,5 €)");
            }

            //Primavera
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Primavera(3 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 3.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Romana
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Romana (4 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 4.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Cesar
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Cesar (4,5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 4.5;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

        }

        private void btnEmpanada_CheckedChanged(object sender, EventArgs e)
        {
            //Primer plato
            //Empanada
            if (btnEmpanada.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Pulpo (6 €)");
                comboBox1.Items.Add("Zamburiñas (7 €)");
                comboBox1.Items.Add("Carne (3 €)");
                comboBox1.Items.Add("Choco (3.5 €)");
            }

            //Pulpo
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Pulpo (6 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 6.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Zamburiñas
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Zamburiñas (7 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 7.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Carne (3 €)
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Carne (3 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 3.0;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

            //Choco 
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Choco (3.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato1 = 3.5;
                //Limpiamos el label
                lbl1plato.Text = "";
                //Metemos el valor en el label
                lbl1plato.Text = Plato1.ToString() + " €";
            }

        }

        double Plato2 = 0;
        private void btnCarne_CheckedChanged(object sender, EventArgs e)
        {
            //Segundo plato
            //Carne
            if (btnCarne.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Milanesa (4.5 €)");
                comboBox2.Items.Add("Chuleta (7.5 €)");
                comboBox2.Items.Add("San Jacobos (4.5 €)");
                comboBox2.Items.Add("Solomillo (8.5 €)");
            }

            //Milanesa 
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Milanesa (4.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 4.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Chuleta
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Chuleta (7.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 7.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //San Jacobos
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "San Jacobos (4.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 4.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Solomillo
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Solomillo (8.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 8.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

        }

        private void btnPescado_CheckedChanged(object sender, EventArgs e)
        {
            //Segundo plato
            //Pescado
            if (btnPescado.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Merluza a la plancha (4.5 €)");
                comboBox2.Items.Add("Lenguado (4.5 €)");
                comboBox2.Items.Add("Besugo (6 €)");
                comboBox2.Items.Add("Bacalao al horno (6 €)");
            }

            //Merluza a la plancha 
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Merluza a la plancha (4.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 4.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Lenguado
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Lenguado (4.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 4.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Besugo
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Besugo (6 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 6.0;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Bacalao al horno
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Bacalao al horno (6 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 6.0;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

        }

        private void btnPasta_CheckedChanged(object sender, EventArgs e)
        {
            //Segundo plato
            //Pasta
            if (btnPasta.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Spaguetti Bolognesa (9,0€)");
                comboBox2.Items.Add("Macarrones carbonara (9.5€)");
                comboBox2.Items.Add("Trofie al pesto (10.5 €)");
            }

            //Spaguetti Bolognesa 
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Spaguetti Bolognesa (9,0€)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 9.0;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Macarrones carbonara
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Macarrones carbonara (9.5€)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 9.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }

            //Trofie al pesto
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Trofie al pesto (10.5 €)")
            {
                //Asignar un valor a la variable Plato1
                Plato2 = 10.5;
                //Limpiamos el label
                lbl2plato.Text = "";
                //Metemos el valor en el label
                lbl2plato.Text = Plato2.ToString() + " €";
            }
        }

        double bebidas1 = 0;
        private void btnAgua_CheckedChanged(object sender, EventArgs e)
        {
            //Bebidas
            //Agua
            if (btnAgua.Checked)
            {
                Precio_Bebidas.Items.Clear();
                Precio_Bebidas.Items.Add("Agua (1.0 €)");
            }

            //Agua
            if (Precio_Bebidas.SelectedItem != null && Precio_Bebidas.SelectedItem.ToString() == "Agua (1.0 €)")
            {
                //Asignar un valor a la variable Plato1
                bebidas1 = 1.0;
                //Limpiamos el label
                lblbebida.Text = "";
                //Metemos el valor en el label
                lblbebida.Text = bebidas1.ToString() + " €";
            }
        }

        private void Precio_Bebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox Bebidas Precio
        }

        private void btnRefresco_CheckedChanged(object sender, EventArgs e)
        {

            //Bebidas
            //Refresco
            if (btnRefresco.Checked)
            {
                Precio_Bebidas.Items.Clear();
                Precio_Bebidas.Items.Add("Refresco (3.0 €)");
            }

            //Refresco
            if (Precio_Bebidas.SelectedItem != null && Precio_Bebidas.SelectedItem.ToString() == "Refresco (3.0 €)")
            {
                //Asignar un valor a la variable Plato1
                bebidas1 = 3.0;
                //Limpiamos el label
                lblbebida.Text = "";
                //Metemos el valor en el label
                lblbebida.Text = bebidas1.ToString() + " €";
            }
        }

        private void Ejercicio_9_Load(object sender, EventArgs e)
        {

        }

        private void btnVino_CheckedChanged(object sender, EventArgs e)
        {
            //Bebidas
            //Vino
            if (btnVino.Checked)
            {
                Precio_Bebidas.Items.Clear();
                Precio_Bebidas.Items.Add("Vino (5.0 €)");
            }

            //Vino
            if (Precio_Bebidas.SelectedItem != null && Precio_Bebidas.SelectedItem.ToString() == "Vino (5.0 €)")
            {
                //Asignar un valor a la variable Plato1
                bebidas1 = 5.0;
                //Limpiamos el label
                lblbebida.Text = "";
                //Metemos el valor en el label
                lblbebida.Text = bebidas1.ToString() + " €";
            }
        }

        double postre = 0;
        private void btnPostre_CheckedChanged(object sender, EventArgs e)
        {
            //Postre
            if (btnPostre.Checked)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Fruta /Yogurt (1.5 €)");
                comboBox3.Items.Add("Brownie Chocolate con helado (3.5 €)");
                comboBox3.Items.Add("Tarta de Santiago (3.5 €)");
                comboBox3.Items.Add("Tarta semifria de chocolate y queso (3.5 €)");
            }

            //Fruta /Yogurt
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem.ToString() == "Fruta /Yogurt (1.5 €)")
            {
                //Asignar un valor a la variable Plato1
                postre = 1.5;
                //Limpiamos el label
                label4.Text = "";
                //Metemos el valor en el label
                label4.Text = postre.ToString() + " €";
            }

            //Brownie Chocolate con helado
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem.ToString() == "Brownie Chocolate con helado (3.5 €)")
            {
                //Asignar un valor a la variable Plato1
                postre = 3.5;
                //Limpiamos el label
                label4.Text = "";
                //Metemos el valor en el label
                label4.Text = postre.ToString() + " €";
            }

            //Tarta de Santiago
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem.ToString() == "Tarta de Santiago (3.5 €)")
            {
                //Asignar un valor a la variable Plato1
                postre = 3.5;
                //Limpiamos el label
                label4.Text = "";
                //Metemos el valor en el label
                label4.Text = postre.ToString() + " €";
            }

            //Tarta semifria de chocolate y queso
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem.ToString() == "Tarta semifria de chocolate y queso (3.5 €)")
            {
                //Asignar un valor a la variable Plato1
                postre = 3.5;
                //Limpiamos el label
                label4.Text = "";
                //Metemos el valor en el label
                label4.Text = postre.ToString() + " €";
            }
        }

        double Cafe = 0;
        private void btnCafe_CheckedChanged(object sender, EventArgs e)
        {
            //Café
            if (btnCafe.Checked)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Con leche (1 €)");
                comboBox4.Items.Add("Cortado (1 €)");
                comboBox4.Items.Add("Solo (1 €)");
                comboBox4.Items.Add("Descafeinado (1 €)");
            }

            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "Con leche (1 €)")
            {
                //Asignar un valor a la variable Cafe
                Cafe = 1.0;
                //Limpiamos el label
                label6.Text = "";
                //Metemos el valor en el label
                label6.Text = Cafe.ToString() + " €";
            }

            //Cortado
            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "Cortado (1 €)")
            {
                //Asignar un valor a la variable Cafe
                Cafe = 1.0;
                //Limpiamos el label
                label6.Text = "";
                //Metemos el valor en el label
                label6.Text = Cafe.ToString() + " €";
            }

            //Solo
            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "Solo (1 €)")
            {
                //Asignar un valor a la variable Cafe
                Cafe = 1.0;
                //Limpiamos el label
                label6.Text = "";
                //Metemos el valor en el label
                label6.Text = Cafe.ToString() + " €";
            }

            //Descafeinado
            if (comboBox4.SelectedItem != null && comboBox4.SelectedItem.ToString() == "Descafeinado (1 €)")
            {
                //Asignar un valor a la variable Cafe
                Cafe = 1.0;
                //Limpiamos el label
                label6.Text = "";
                //Metemos el valor en el label
                label6.Text = Cafe.ToString() + " €";
            }
        }

        double La_Dolorosa = 0;
        double IVA = 0;
        double La_Multa = 0;
        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            //La Dolorosa

            La_Dolorosa = Plato1 + Plato2 + bebidas1 + postre + Cafe;

            IVA = La_Dolorosa * 0.11;
            La_Multa = La_Dolorosa + IVA;

            MessageBox.Show("La multa es de " + La_Dolorosa + " €. El impuesto es de " + IVA + " €. Lo cual sería " + La_Multa);
            MessageBox.Show("La multa sin IVA es de " + La_Dolorosa ); 

            Pagar_Multa.Visible = true;
            textBox1.Visible = true;
            label8.Visible = true;
        }

        private void Pagar_Multa_Click(object sender, EventArgs e)
        {

            //Intenta pasar el texto a un número decimal.
            //Guarda el resultado en la variable "Robo".
            if (decimal.TryParse(textBox1.Text, out decimal Robo))
            {
                // Calcula la vuelta
                decimal vuelta = Robo - (decimal)La_Multa;

                // Muestra la vuelta
                MessageBox.Show("Su vuelta es de " + vuelta + " €"); 
            }
            else
            {
                MessageBox.Show("Por favor, mete un número válido.");
            }


            /*double Robo = textBox1.Text.Length;
            double vuelta = Robo - La_Multa;

            if (textBox1.Text != null && textBox1.Text != "")
            {
                MessageBox.Show("Su vuelta es de " + vuelta);
            }*/
        }
    }
}
