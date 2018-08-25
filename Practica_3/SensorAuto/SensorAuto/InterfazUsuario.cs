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
        Boolean EstadoDrive = false;
        Boolean EstadoNeutral = false;
        Boolean EstadoReverse = false;

        //Boolean Delantero = false;




        private void SeleccionarDNR(object sender, EventArgs e)
        {
            if ("Drive" == this.cboDNR.SelectedItem.ToString())
            {
                S_Delantero.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
                EstadoDrive  = S_Delantero.Calcular_Distancia();
                 

            }
            else if ("Reverse" == this.cboDNR.SelectedItem.ToString())
            {
                S_Trasero.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
                Estado_Direccion = S_Trasero.Acelerar();
                EstadoReverse = true;

            }
            else //this.cboDNR.SelectedItem.ToString()
            {
                //S_+.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
                //Estado_Direccion = S_Delantero.Acelerar();
            }
        }

        private void EnviarDatos(object sender, EventArgs e)
        {
            if (EstadoDrive) {
                //Estado_Direccion = S_Delantero.Acelerar();
                Estado_Direccion = "Si se puede mover hacia adelante";
            }
            else if(EstadoReverse)
            {
                Estado_Direccion = "Si se puede mover hacia atrás";
            }
            
            this.MostarEstado.Text = Estado_Direccion;

            EstadoDrive = false;
            EstadoNeutral = false;
            EstadoReverse = false;
        }
    }
}
 