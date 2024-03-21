namespace _1_7_Tema9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpulsar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.LightSalmon;
            this.txtnombre.Location = new System.Drawing.Point(229, 49);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(155, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca su nómbre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.LightSalmon;
            this.txtcorreo.Location = new System.Drawing.Point(229, 86);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(155, 20);
            this.txtcorreo.TabIndex = 2;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección de  correo";
            // 
            // btnpulsar
            // 
            this.btnpulsar.Location = new System.Drawing.Point(136, 112);
            this.btnpulsar.Name = "btnpulsar";
            this.btnpulsar.Size = new System.Drawing.Size(518, 321);
            this.btnpulsar.TabIndex = 4;
            this.btnpulsar.Text = "Pulsame\r\n";
            this.btnpulsar.UseVisualStyleBackColor = true;
            this.btnpulsar.Click += new System.EventHandler(this.btnej1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnpulsar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpulsar;
    }
}

