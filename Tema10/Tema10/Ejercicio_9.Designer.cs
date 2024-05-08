namespace Tema10
{
    partial class Ejercicio_9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrema = new System.Windows.Forms.RadioButton();
            this.btnEnsalada = new System.Windows.Forms.RadioButton();
            this.btnEmpanada = new System.Windows.Forms.RadioButton();
            this.btnCarne = new System.Windows.Forms.RadioButton();
            this.btnPescado = new System.Windows.Forms.RadioButton();
            this.btnPasta = new System.Windows.Forms.RadioButton();
            this.btnAgua = new System.Windows.Forms.RadioButton();
            this.btnRefresco = new System.Windows.Forms.RadioButton();
            this.btnVino = new System.Windows.Forms.RadioButton();
            this.btnPostre = new System.Windows.Forms.RadioButton();
            this.btnCafe = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnCalcularCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1plato = new System.Windows.Forms.Label();
            this.lbl2plato = new System.Windows.Forms.Label();
            this.lblbebida = new System.Windows.Forms.Label();
            this.Precio_Bebidas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pagar_Multa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrema
            // 
            this.btnCrema.AutoSize = true;
            this.btnCrema.Location = new System.Drawing.Point(111, 52);
            this.btnCrema.Name = "btnCrema";
            this.btnCrema.Size = new System.Drawing.Size(55, 17);
            this.btnCrema.TabIndex = 0;
            this.btnCrema.TabStop = true;
            this.btnCrema.Text = "Crema";
            this.btnCrema.UseVisualStyleBackColor = true;
            this.btnCrema.CheckedChanged += new System.EventHandler(this.btnCrema_CheckedChanged);
            // 
            // btnEnsalada
            // 
            this.btnEnsalada.AutoSize = true;
            this.btnEnsalada.Location = new System.Drawing.Point(111, 75);
            this.btnEnsalada.Name = "btnEnsalada";
            this.btnEnsalada.Size = new System.Drawing.Size(69, 17);
            this.btnEnsalada.TabIndex = 1;
            this.btnEnsalada.TabStop = true;
            this.btnEnsalada.Text = "Ensalada";
            this.btnEnsalada.UseVisualStyleBackColor = true;
            this.btnEnsalada.CheckedChanged += new System.EventHandler(this.btnEnsalada_CheckedChanged);
            // 
            // btnEmpanada
            // 
            this.btnEmpanada.AutoSize = true;
            this.btnEmpanada.Location = new System.Drawing.Point(111, 98);
            this.btnEmpanada.Name = "btnEmpanada";
            this.btnEmpanada.Size = new System.Drawing.Size(76, 17);
            this.btnEmpanada.TabIndex = 2;
            this.btnEmpanada.TabStop = true;
            this.btnEmpanada.Text = "Empanada";
            this.btnEmpanada.UseVisualStyleBackColor = true;
            this.btnEmpanada.CheckedChanged += new System.EventHandler(this.btnEmpanada_CheckedChanged);
            // 
            // btnCarne
            // 
            this.btnCarne.AutoSize = true;
            this.btnCarne.Location = new System.Drawing.Point(338, 52);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(53, 17);
            this.btnCarne.TabIndex = 3;
            this.btnCarne.TabStop = true;
            this.btnCarne.Text = "Carne";
            this.btnCarne.UseVisualStyleBackColor = true;
            this.btnCarne.CheckedChanged += new System.EventHandler(this.btnCarne_CheckedChanged);
            // 
            // btnPescado
            // 
            this.btnPescado.AutoSize = true;
            this.btnPescado.Location = new System.Drawing.Point(338, 75);
            this.btnPescado.Name = "btnPescado";
            this.btnPescado.Size = new System.Drawing.Size(67, 17);
            this.btnPescado.TabIndex = 4;
            this.btnPescado.TabStop = true;
            this.btnPescado.Text = "Pescado";
            this.btnPescado.UseVisualStyleBackColor = true;
            this.btnPescado.CheckedChanged += new System.EventHandler(this.btnPescado_CheckedChanged);
            // 
            // btnPasta
            // 
            this.btnPasta.AutoSize = true;
            this.btnPasta.Location = new System.Drawing.Point(338, 98);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(52, 17);
            this.btnPasta.TabIndex = 5;
            this.btnPasta.TabStop = true;
            this.btnPasta.Text = "Pasta";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.CheckedChanged += new System.EventHandler(this.btnPasta_CheckedChanged);
            // 
            // btnAgua
            // 
            this.btnAgua.AutoSize = true;
            this.btnAgua.Location = new System.Drawing.Point(581, 52);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(50, 17);
            this.btnAgua.TabIndex = 6;
            this.btnAgua.TabStop = true;
            this.btnAgua.Text = "Agua";
            this.btnAgua.UseVisualStyleBackColor = true;
            this.btnAgua.CheckedChanged += new System.EventHandler(this.btnAgua_CheckedChanged);
            // 
            // btnRefresco
            // 
            this.btnRefresco.AutoSize = true;
            this.btnRefresco.Location = new System.Drawing.Point(581, 75);
            this.btnRefresco.Name = "btnRefresco";
            this.btnRefresco.Size = new System.Drawing.Size(68, 17);
            this.btnRefresco.TabIndex = 7;
            this.btnRefresco.TabStop = true;
            this.btnRefresco.Text = "Refresco";
            this.btnRefresco.UseVisualStyleBackColor = true;
            this.btnRefresco.CheckedChanged += new System.EventHandler(this.btnRefresco_CheckedChanged);
            // 
            // btnVino
            // 
            this.btnVino.AutoSize = true;
            this.btnVino.Location = new System.Drawing.Point(581, 98);
            this.btnVino.Name = "btnVino";
            this.btnVino.Size = new System.Drawing.Size(46, 17);
            this.btnVino.TabIndex = 8;
            this.btnVino.TabStop = true;
            this.btnVino.Text = "Vino";
            this.btnVino.UseVisualStyleBackColor = true;
            this.btnVino.CheckedChanged += new System.EventHandler(this.btnVino_CheckedChanged);
            // 
            // btnPostre
            // 
            this.btnPostre.AutoSize = true;
            this.btnPostre.Location = new System.Drawing.Point(580, 236);
            this.btnPostre.Name = "btnPostre";
            this.btnPostre.Size = new System.Drawing.Size(55, 17);
            this.btnPostre.TabIndex = 9;
            this.btnPostre.TabStop = true;
            this.btnPostre.Text = "Postre";
            this.btnPostre.UseVisualStyleBackColor = true;
            this.btnPostre.CheckedChanged += new System.EventHandler(this.btnPostre_CheckedChanged);
            // 
            // btnCafe
            // 
            this.btnCafe.AutoSize = true;
            this.btnCafe.Location = new System.Drawing.Point(580, 321);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(47, 17);
            this.btnCafe.TabIndex = 10;
            this.btnCafe.TabStop = true;
            this.btnCafe.Text = "Café";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.CheckedChanged += new System.EventHandler(this.btnCafe_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(332, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(580, 259);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(188, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(580, 344);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(188, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // btnCalcularCuenta
            // 
            this.btnCalcularCuenta.Location = new System.Drawing.Point(63, 257);
            this.btnCalcularCuenta.Name = "btnCalcularCuenta";
            this.btnCalcularCuenta.Size = new System.Drawing.Size(232, 145);
            this.btnCalcularCuenta.TabIndex = 15;
            this.btnCalcularCuenta.Text = "Calcular Cuenta";
            this.btnCalcularCuenta.UseVisualStyleBackColor = true;
            this.btnCalcularCuenta.Click += new System.EventHandler(this.btnCalcularCuenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio primer plato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio segundo plato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio bebida:";
            // 
            // lbl1plato
            // 
            this.lbl1plato.AutoSize = true;
            this.lbl1plato.Location = new System.Drawing.Point(214, 189);
            this.lbl1plato.Name = "lbl1plato";
            this.lbl1plato.Size = new System.Drawing.Size(0, 13);
            this.lbl1plato.TabIndex = 19;
            // 
            // lbl2plato
            // 
            this.lbl2plato.AutoSize = true;
            this.lbl2plato.Location = new System.Drawing.Point(451, 189);
            this.lbl2plato.Name = "lbl2plato";
            this.lbl2plato.Size = new System.Drawing.Size(0, 13);
            this.lbl2plato.TabIndex = 20;
            // 
            // lblbebida
            // 
            this.lblbebida.AutoSize = true;
            this.lblbebida.Location = new System.Drawing.Point(659, 129);
            this.lblbebida.Name = "lblbebida";
            this.lblbebida.Size = new System.Drawing.Size(0, 13);
            this.lblbebida.TabIndex = 21;
            // 
            // Precio_Bebidas
            // 
            this.Precio_Bebidas.FormattingEnabled = true;
            this.Precio_Bebidas.Location = new System.Drawing.Point(688, 75);
            this.Precio_Bebidas.Name = "Precio_Bebidas";
            this.Precio_Bebidas.Size = new System.Drawing.Size(135, 17);
            this.Precio_Bebidas.TabIndex = 22;
            this.Precio_Bebidas.SelectedIndexChanged += new System.EventHandler(this.Precio_Bebidas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio Postre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Precio Café:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Pagar la dolorosa:";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Visible = false;
            // 
            // Pagar_Multa
            // 
            this.Pagar_Multa.Location = new System.Drawing.Point(341, 309);
            this.Pagar_Multa.Name = "Pagar_Multa";
            this.Pagar_Multa.Size = new System.Drawing.Size(75, 23);
            this.Pagar_Multa.TabIndex = 29;
            this.Pagar_Multa.Text = "Pagar";
            this.Pagar_Multa.UseVisualStyleBackColor = true;
            this.Pagar_Multa.Visible = false;
            this.Pagar_Multa.Click += new System.EventHandler(this.Pagar_Multa_Click);
            // 
            // Ejercicio_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 484);
            this.Controls.Add(this.Pagar_Multa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Precio_Bebidas);
            this.Controls.Add(this.lblbebida);
            this.Controls.Add(this.lbl2plato);
            this.Controls.Add(this.lbl1plato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularCuenta);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCafe);
            this.Controls.Add(this.btnPostre);
            this.Controls.Add(this.btnVino);
            this.Controls.Add(this.btnRefresco);
            this.Controls.Add(this.btnAgua);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnPescado);
            this.Controls.Add(this.btnCarne);
            this.Controls.Add(this.btnEmpanada);
            this.Controls.Add(this.btnEnsalada);
            this.Controls.Add(this.btnCrema);
            this.Name = "Ejercicio_9";
            this.Text = "Ejercicio_9";
            this.Load += new System.EventHandler(this.Ejercicio_9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnCrema;
        private System.Windows.Forms.RadioButton btnEnsalada;
        private System.Windows.Forms.RadioButton btnEmpanada;
        private System.Windows.Forms.RadioButton btnCarne;
        private System.Windows.Forms.RadioButton btnPescado;
        private System.Windows.Forms.RadioButton btnPasta;
        private System.Windows.Forms.RadioButton btnAgua;
        private System.Windows.Forms.RadioButton btnRefresco;
        private System.Windows.Forms.RadioButton btnVino;
        private System.Windows.Forms.RadioButton btnPostre;
        private System.Windows.Forms.RadioButton btnCafe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnCalcularCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1plato;
        private System.Windows.Forms.Label lbl2plato;
        private System.Windows.Forms.Label lblbebida;
        private System.Windows.Forms.ListBox Precio_Bebidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pagar_Multa;
    }
}