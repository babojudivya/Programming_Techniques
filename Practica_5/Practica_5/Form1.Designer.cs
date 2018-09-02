namespace Practica_5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxProductName = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.ListBox();
            this.richCuenta = new System.Windows.Forms.RichTextBox();
            this.Producto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvailableCapital = new System.Windows.Forms.Label();
            this.txt_AvailableCapital = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Remaining_Capital = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_5.Properties.Resources.icons8_compras_64;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product name";
            // 
            // txtboxProductName
            // 
            this.txtboxProductName.Location = new System.Drawing.Point(143, 109);
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Size = new System.Drawing.Size(183, 20);
            this.txtboxProductName.TabIndex = 3;
            this.txtboxProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only);
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(144, 138);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(183, 20);
            this.txtboxCost.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddProduct);
            // 
            // Listado
            // 
            this.Listado.FormattingEnabled = true;
            this.Listado.Location = new System.Drawing.Point(96, 251);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(172, 69);
            this.Listado.TabIndex = 8;
            // 
            // richCuenta
            // 
            this.richCuenta.Location = new System.Drawing.Point(288, 267);
            this.richCuenta.Name = "richCuenta";
            this.richCuenta.Size = new System.Drawing.Size(100, 23);
            this.richCuenta.TabIndex = 10;
            this.richCuenta.Text = "";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(163, 232);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(44, 13);
            this.Producto.TabIndex = 11;
            this.Producto.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "The total";
            // 
            // AvailableCapital
            // 
            this.AvailableCapital.AutoSize = true;
            this.AvailableCapital.Location = new System.Drawing.Point(56, 77);
            this.AvailableCapital.Name = "AvailableCapital";
            this.AvailableCapital.Size = new System.Drawing.Size(84, 13);
            this.AvailableCapital.TabIndex = 14;
            this.AvailableCapital.Text = "Available capital";
            // 
            // txt_AvailableCapital
            // 
            this.txt_AvailableCapital.Location = new System.Drawing.Point(143, 77);
            this.txt_AvailableCapital.Name = "txt_AvailableCapital";
            this.txt_AvailableCapital.Size = new System.Drawing.Size(183, 20);
            this.txt_AvailableCapital.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Remaining capital";
            // 
            // txt_Remaining_Capital
            // 
            this.txt_Remaining_Capital.Location = new System.Drawing.Point(361, 42);
            this.txt_Remaining_Capital.Name = "txt_Remaining_Capital";
            this.txt_Remaining_Capital.Size = new System.Drawing.Size(58, 20);
            this.txt_Remaining_Capital.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LimpiarAcciones);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Remaining_Capital);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AvailableCapital);
            this.Controls.Add(this.AvailableCapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.richCuenta);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adios);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxProductName;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox Listado;
        private System.Windows.Forms.RichTextBox richCuenta;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AvailableCapital;
        private System.Windows.Forms.TextBox txt_AvailableCapital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Remaining_Capital;
        private System.Windows.Forms.Button button1;
    }
}

