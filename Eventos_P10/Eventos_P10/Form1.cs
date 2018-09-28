using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_P10
{
    public partial class Form1 : Form
    {
        int cont = 0;
        Boolean limit = false;
        Contador c = new Contador(4);

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = 0.ToString();
            c.ThresholdReached += c_ThresholdReached;

        }

        public void c_ThresholdReached(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.nop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont++;
            c.Add(cont);
            
            if (limit)
            {
                if (cont<5)
                {
                    textBox1.Text = cont.ToString();
                }
                else
                {
                    textBox1.Text = 5.ToString();
                    cont = 5;
                }
            }
            else
            {
                if (cont < 10)
                {
                    textBox1.Text = cont.ToString();
                }
                else
                {
                    textBox1.Text = 5.ToString();
                    cont = 10;
                }
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text =  trackBar1.Value.ToString();
            cont = trackBar1.Value;
            c.Add(cont);
            if (cont < 4 ){
            pictureBox1.Image = Properties.Resources.si;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            trackBar1.Value = cont;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            limit = checkBox1.Checked;
            int newValue;
            if (limit)
            {
                trackBar1.Maximum = 5;
                newValue = Convert.ToInt16(textBox1.Text);
                if (newValue >5)
                {
                    textBox1.Text = 5.ToString();
                }
            }
            else
            {
              trackBar1.Maximum = 10;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
