namespace SensoresTest
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_Usuario = new System.Windows.Forms.ComboBox();
            this.cbo_Sensor = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.richtx_Estado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_Usuario
            // 
            this.cbo_Usuario.FormattingEnabled = true;
            this.cbo_Usuario.Items.AddRange(new object[] {
            "Directivo",
            "Académico",
            "Estudiante"});
            this.cbo_Usuario.Location = new System.Drawing.Point(80, 37);
            this.cbo_Usuario.Name = "cbo_Usuario";
            this.cbo_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cbo_Usuario.TabIndex = 0;
            // 
            // cbo_Sensor
            // 
            this.cbo_Sensor.FormattingEnabled = true;
            this.cbo_Sensor.Items.AddRange(new object[] {
            "Iris",
            "Dactilar",
            "Voz"});
            this.cbo_Sensor.Location = new System.Drawing.Point(80, 82);
            this.cbo_Sensor.Name = "cbo_Sensor";
            this.cbo_Sensor.Size = new System.Drawing.Size(121, 21);
            this.cbo_Sensor.TabIndex = 1;
            this.cbo_Sensor.SelectedIndexChanged += new System.EventHandler(this.RecuperarDatos);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(80, 128);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(121, 20);
            this.txt_ID.TabIndex = 2;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(105, 168);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.EnviarDatos);
            // 
            // richtx_Estado
            // 
            this.richtx_Estado.Location = new System.Drawing.Point(92, 219);
            this.richtx_Estado.Name = "richtx_Estado";
            this.richtx_Estado.Size = new System.Drawing.Size(100, 96);
            this.richtx_Estado.TabIndex = 4;
            this.richtx_Estado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtx_Estado);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.cbo_Sensor);
            this.Controls.Add(this.cbo_Usuario);
            this.Name = "Principal";
            this.Text = "Sensores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Usuario;
        private System.Windows.Forms.ComboBox cbo_Sensor;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.RichTextBox richtx_Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

