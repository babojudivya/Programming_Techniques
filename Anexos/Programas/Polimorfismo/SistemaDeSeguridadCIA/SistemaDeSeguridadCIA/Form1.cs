using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeSeguridadCIA
{
    public partial class Form1 : Form
    {
        Sensores S1 = new Sensores();
        public Form1()
        {
            InitializeComponent();

            //richTextBox1.Text = tipoUsuario;
            richTextBox1.Text = "Acceso Denegado";
            richTextBox1.Text = "Acceso Permitido";

            
        }

        /*
          Este método es para identificar el tipo de usuario
             */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            S1.TipodeUsuario1 = comboBox1.SelectedItem.ToString();
        }

        /*
         * Este método es para identificar el tipo de sensor
         */
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            S1.TipodeSensor1 = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Iris")
            {
                S1.ID1 = textBox1.Text;
            }
            else if (comboBox2.SelectedItem.ToString() == "Dactilar")
            {
                S1.ID1 = textBox1.Text;
            }
            else if (comboBox2.SelectedItem.ToString() == "Voz")
            {
                S1.ID1 = textBox1.Text;
            }
            
            S1.IdentificarUsuario();
        }
    }
}
