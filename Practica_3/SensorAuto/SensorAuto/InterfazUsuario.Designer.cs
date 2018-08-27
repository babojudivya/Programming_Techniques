namespace SensorAuto
{
    partial class ProgramaPrincipal
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
            this.cboDNR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MostarEstado = new System.Windows.Forms.RichTextBox();
            this.txb_InMetros = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDNR
            // 
            this.cboDNR.FormattingEnabled = true;
            this.cboDNR.Items.AddRange(new object[] {
            "Drive",
            "Neutral",
            "Reverse"});
            this.cboDNR.Location = new System.Drawing.Point(88, 113);
            this.cboDNR.Name = "cboDNR";
            this.cboDNR.Size = new System.Drawing.Size(121, 21);
            this.cboDNR.TabIndex = 1;
            this.cboDNR.SelectedIndexChanged += new System.EventHandler(this.SeleccionarDNR);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "D N R";
            // 
            // MostarEstado
            // 
            this.MostarEstado.Location = new System.Drawing.Point(61, 198);
            this.MostarEstado.Name = "MostarEstado";
            this.MostarEstado.Size = new System.Drawing.Size(185, 92);
            this.MostarEstado.TabIndex = 4;
            this.MostarEstado.Text = "";
            // 
            // txb_InMetros
            // 
            this.txb_InMetros.Location = new System.Drawing.Point(88, 60);
            this.txb_InMetros.Name = "txb_InMetros";
            this.txb_InMetros.Size = new System.Drawing.Size(121, 20);
            this.txb_InMetros.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnviarDatos);
            // 
            // ProgramaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_InMetros);
            this.Controls.Add(this.MostarEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDNR);
            this.Name = "ProgramaPrincipal";
            this.Text = "Auto Sensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDNR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MostarEstado;
        private System.Windows.Forms.TextBox txb_InMetros;
        private System.Windows.Forms.Button button1;
    }
}

