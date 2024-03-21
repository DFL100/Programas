namespace _1_7_Tema9
{
    partial class Ejercicio_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.lblDía = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(258, 45);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(258, 86);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(258, 128);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDía
            // 
            this.lblDía.AutoSize = true;
            this.lblDía.Location = new System.Drawing.Point(45, 56);
            this.lblDía.Name = "lblDía";
            this.lblDía.Size = new System.Drawing.Size(25, 13);
            this.lblDía.TabIndex = 6;
            this.lblDía.Text = "Día";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(43, 96);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            this.lblMes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(43, 138);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(137, 183);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "La fecha es:";
            this.lblFecha.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(391, 246);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDía);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Ejercicio_2";
            this.Text = "Ejercicio_2";
            this.Load += new System.EventHandler(this.Ejercicio_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label lblDía;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox4;
    }
}