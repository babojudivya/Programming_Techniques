namespace Security_System_México
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
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboSensor = new System.Windows.Forms.ComboBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtboID = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pboMinimize = new System.Windows.Forms.PictureBox();
            this.pboClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUsuario
            // 
            this.cboUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Items.AddRange(new object[] {
            "Directivo",
            "Académico",
            "Estudiante"});
            this.cboUsuario.Location = new System.Drawing.Point(187, 134);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(167, 21);
            this.cboUsuario.TabIndex = 1;
            this.cboUsuario.Text = "Usuario";
            // 
            // cboSensor
            // 
            this.cboSensor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSensor.FormattingEnabled = true;
            this.cboSensor.Items.AddRange(new object[] {
            "Dactilar",
            "Voz",
            "Iris"});
            this.cboSensor.Location = new System.Drawing.Point(187, 187);
            this.cboSensor.Name = "cboSensor";
            this.cboSensor.Size = new System.Drawing.Size(167, 21);
            this.cboSensor.TabIndex = 2;
            this.cboSensor.Text = "Sensor";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(236, 298);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // txtboID
            // 
            this.txtboID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboID.Location = new System.Drawing.Point(204, 232);
            this.txtboID.Name = "txtboID";
            this.txtboID.Size = new System.Drawing.Size(150, 13);
            this.txtboID.TabIndex = 4;
            this.txtboID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboID.UseSystemPasswordChar = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Location = new System.Drawing.Point(226, 340);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(96, 30);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(187, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "ID";
            // 
            // pboMinimize
            // 
            this.pboMinimize.BackColor = System.Drawing.Color.Black;
            this.pboMinimize.Image = global::Security_System_México.Properties.Resources.icons8_comprimir_50;
            this.pboMinimize.Location = new System.Drawing.Point(378, 30);
            this.pboMinimize.Name = "pboMinimize";
            this.pboMinimize.Size = new System.Drawing.Size(22, 21);
            this.pboMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboMinimize.TabIndex = 8;
            this.pboMinimize.TabStop = false;
            this.pboMinimize.Click += new System.EventHandler(this.pboMinimize_Click);
            // 
            // pboClose
            // 
            this.pboClose.BackColor = System.Drawing.Color.Black;
            this.pboClose.Image = global::Security_System_México.Properties.Resources.close;
            this.pboClose.Location = new System.Drawing.Point(415, 56);
            this.pboClose.Name = "pboClose";
            this.pboClose.Size = new System.Drawing.Size(10, 11);
            this.pboClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboClose.TabIndex = 7;
            this.pboClose.TabStop = false;
            this.pboClose.Click += new System.EventHandler(this.pboClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.pictureBox1.Image = global::Security_System_México.Properties.Resources.Candado11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(355, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 37);
            this.panel1.TabIndex = 9;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(545, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pboMinimize);
            this.Controls.Add(this.pboClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtboID);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.cboSensor);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboSensor;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtboID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pboClose;
        private System.Windows.Forms.PictureBox pboMinimize;
        private System.Windows.Forms.Panel panel1;
    }
}

