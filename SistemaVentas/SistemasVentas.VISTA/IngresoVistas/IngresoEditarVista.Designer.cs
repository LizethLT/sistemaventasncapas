namespace SistemasVentas.VISTA.IngresoVistas
{
    partial class IngresoEditarVista
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
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(181, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(291, 247);
            button2.Name = "button2";
            button2.Size = new Size(79, 32);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(94, 247);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(181, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 26);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(181, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 26);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(122, 193);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 11;
            label3.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(33, 148);
            label2.Name = "label2";
            label2.Size = new Size(138, 16);
            label2.TabIndex = 10;
            label2.Text = "FECHA DE INGRESO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(64, 94);
            label1.Name = "label1";
            label1.Size = new Size(109, 16);
            label1.TabIndex = 9;
            label1.Text = "ID PROVEEDOR";
            // 
            // IngresoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 325);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresoEditarVista";
            Text = "IngresoEditarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}