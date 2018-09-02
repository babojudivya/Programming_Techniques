using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensoresTest
{
    public partial class Principal : Form
    {

        Boolean Iris = false;
        Boolean Dactilar = false;
        Boolean Voz = false;
        Hijo_Voz hVoz = new Hijo_Voz();
        Hijo_Dactilar hDactilar = new Hijo_Dactilar();
        Hijo_Iris hIris = new Hijo_Iris();

        public Principal()
        {
            InitializeComponent();
        }

        private void RecuperarDatos(object sender, EventArgs e)
        {
            if ("Iris" == this.cbo_Sensor.SelectedItem.ToString())
            {
                hIris.UsuarioValidado1 = this.cbo_Usuario.SelectedItem.ToString();
                Iris = true;

            }
            else if ("Dactilar" == this.cbo_Sensor.SelectedItem.ToString())
            {
                Dactilar = true;
            }
            else
            {
                Voz = true;
            }
        }

        private void EnviarDatos(object sender, EventArgs e)
        {

            if(Iris)
            {
                
            }
            this.richtx_Estado.Text = hIris.Mensaje();
        }


    }
}
