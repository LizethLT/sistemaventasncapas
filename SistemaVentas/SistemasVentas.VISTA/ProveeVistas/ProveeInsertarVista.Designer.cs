﻿namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 50);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 105);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "IDPROVEEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 160);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 215);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "PRECIO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(132, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 304);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 23);
            textBox4.TabIndex = 9;
            // 
            // ProveeInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 370);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProveeInsertarVista";
            Text = "ProveeInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}