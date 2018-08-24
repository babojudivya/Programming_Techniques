using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorAuto
{
    public partial class ProgramaPrincipal : Form
    {
        public ProgramaPrincipal()
        {
            InitializeComponent();
        }

        Clase_Sensor_Delantero S_Delantero = new Clase_Sensor_Delantero();
        Clase_Sensor_Trasero S_Trasero = new Clase_Sensor_Trasero();
        //float Distancia;
        string Estado_Direccion = null;

        private void metodo_Metros(object sender, EventArgs e)
        {
            S_Delantero.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
            Estado_Direccion = S_Delantero.Acelerar();
        }
        private void EnviarDatos(object sender, EventArgs e)
        {
            Estado_Direccion = S_Delantero.Acelerar();
            this.MostarEstado.Text = Estado_Direccion;
        }
        
    }
}
