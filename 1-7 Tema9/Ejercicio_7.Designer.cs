namespace _1_7_Tema9
{
    partial class Ejercicio_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txteuro = new System.Windows.Forms.TextBox();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor :";
            // 
            // txteuro
            // 
            this.txteuro.Location = new System.Drawing.Point(45, 67);
            this.txteuro.Name = "txteuro";
            this.txteuro.Size = new System.Drawing.Size(100, 20);
            this.txteuro.TabIndex = 1;
            this.txteuro.TextChanged += new System.EventHandler(this.txteuro_TextChanged);
            // 
            // txtdolar
            // 
            this.txtdolar.Location = new System.Drawing.Point(45, 116);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(100, 20);
            this.txtdolar.TabIndex = 2;
            this.txtdolar.TextChanged += new System.EventHandler(this.txtdolar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convertir a Euros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Convertir a Dolares";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ejercicio_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.txteuro);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_7";
            this.Text = "Ejercicio_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteuro;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}