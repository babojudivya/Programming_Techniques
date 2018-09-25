namespace Practica_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMatrizResultante = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz2 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.btnCriarMatriz2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Columnas = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnDiminuir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operación";
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Location = new System.Drawing.Point(56, 102);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz.TabIndex = 7;
            this.btnCriarMatriz.Text = "Enviar";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Operaciones con matrices - práctica 7";
            // 
            // groupBoxMatrizResultante
            // 
            this.groupBoxMatrizResultante.Location = new System.Drawing.Point(353, 159);
            this.groupBoxMatrizResultante.Name = "groupBoxMatrizResultante";
            this.groupBoxMatrizResultante.Size = new System.Drawing.Size(143, 107);
            this.groupBoxMatrizResultante.TabIndex = 18;
            this.groupBoxMatrizResultante.TabStop = false;
            this.groupBoxMatrizResultante.Text = "Matriz 3";
            // 
            // groupBoxMatriz2
            // 
            this.groupBoxMatriz2.Location = new System.Drawing.Point(198, 159);
            this.groupBoxMatriz2.Name = "groupBoxMatriz2";
            this.groupBoxMatriz2.Size = new System.Drawing.Size(149, 107);
            this.groupBoxMatriz2.TabIndex = 17;
            this.groupBoxMatriz2.TabStop = false;
            this.groupBoxMatriz2.Text = "Matriz 2";
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Location = new System.Drawing.Point(49, 159);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.Size = new System.Drawing.Size(135, 107);
            this.groupBoxMatriz1.TabIndex = 16;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz 1";
            // 
            // btnCriarMatriz2
            // 
            this.btnCriarMatriz2.Location = new System.Drawing.Point(239, 101);
            this.btnCriarMatriz2.Name = "btnCriarMatriz2";
            this.btnCriarMatriz2.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMatriz2.TabIndex = 16;
            this.btnCriarMatriz2.Text = "Enviar";
            this.btnCriarMatriz2.UseVisualStyleBackColor = true;
            this.btnCriarMatriz2.Click += new System.EventHandler(this.btnCriarMatriz2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filas";
            // 
            // Columnas
            // 
            this.Columnas.AutoSize = true;
            this.Columnas.Location = new System.Drawing.Point(294, 53);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(53, 13);
            this.Columnas.TabIndex = 18;
            this.Columnas.Text = "Columnas";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(297, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 20;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(375, 71);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(32, 23);
            this.btnSomar.TabIndex = 21;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click_1);
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.Location = new System.Drawing.Point(418, 71);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(36, 23);
            this.btnDiminuir.TabIndex = 22;
            this.btnDiminuir.Text = "-";
            this.btnDiminuir.UseVisualStyleBackColor = true;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click_1);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(460, 71);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(34, 23);
            this.btnMultiplicar.TabIndex = 23;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Matriz 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Matriz 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 467);
            this.Controls.Add(this.groupBoxMatrizResultante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxMatriz2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxMatriz1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDiminuir);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Columnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCriarMatriz2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCriarMatriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Matrices (p7)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultante;
        private System.Windows.Forms.GroupBox groupBoxMatriz2;
        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.Button btnCriarMatriz2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Columnas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnDiminuir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

