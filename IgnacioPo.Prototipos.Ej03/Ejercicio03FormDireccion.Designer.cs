﻿namespace IgnacioPo.Prototipos.Ej03
{
    partial class Ejercicio03FormDireccion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button1 = new Button();
            Pais = new ListBox();
            Provincia = new ListBox();
            Localidad = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 126);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "País";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 126);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Provincia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 0;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 126);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Direccion-Calle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 126);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 0;
            label5.Text = "Direccion-Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 202);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 0;
            label6.Text = "Direccion-Depto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 202);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 0;
            label8.Text = "Direccion-Piso";
            // 
            // button1
            // 
            button1.Location = new Point(575, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Pais
            // 
            Pais.FormattingEnabled = true;
            Pais.ItemHeight = 15;
            Pais.Location = new Point(36, 179);
            Pais.Name = "Pais";
            Pais.Size = new Size(120, 94);
            Pais.TabIndex = 2;
            Pais.SelectedIndexChanged += this.Pais_SelectedIndexChanged;
            // 
            // Provincia
            // 
            Provincia.FormattingEnabled = true;
            Provincia.ItemHeight = 15;
            Provincia.Location = new Point(155, 179);
            Provincia.Name = "Provincia";
            Provincia.Size = new Size(120, 94);
            Provincia.TabIndex = 2;
            Provincia.SelectedIndexChanged += this.Pais_SelectedIndexChanged;
            // 
            // Localidad
            // 
            Localidad.FormattingEnabled = true;
            Localidad.ItemHeight = 15;
            Localidad.Location = new Point(276, 179);
            Localidad.Name = "Localidad";
            Localidad.Size = new Size(120, 94);
            Localidad.TabIndex = 2;
            Localidad.SelectedIndexChanged += this.Pais_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(533, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(406, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(533, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // Ejercicio03FormDireccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Localidad);
            Controls.Add(Provincia);
            Controls.Add(Pais);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio03FormDireccion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button1;
        private ListBox Pais;
        private ListBox Provincia;
        private ListBox Localidad;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
