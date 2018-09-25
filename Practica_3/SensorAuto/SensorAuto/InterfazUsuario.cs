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
        Clase_Sensor_Neutral S_Neutral = new Clase_Sensor_Neutral();

        //float Distancia;
        string Estado_Direccion = null;
        string Opcion_Acelerar = null;
        Boolean EstadoDrive = false;
        Boolean EstadoNeutral = false;
        Boolean EstadoReverse = false;


        //Boolean Delantero = false;




        private void SeleccionarDNR(object sender, EventArgs e)
        {
                if ("Drive" == this.cboDNR.SelectedItem.ToString())
                {
                    S_Delantero.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
                    EstadoDrive = S_Delantero.Calcular_Distancia(); //devuelve un true
                    Opcion_Acelerar = S_Delantero.Acelerar();


            }
                else if ("Reverse" == this.cboDNR.SelectedItem.ToString() )
                {
                    S_Trasero.Distancia_Ingresada = float.Parse(txb_InMetros.Text);
                    EstadoReverse = S_Trasero.Calcular_Distancia(); //devuelve un true
                    Opcion_Acelerar = S_Trasero.Acelerar();
                    


            }
             else //estado neutro, solo depende de los frenos --> aplicamos delante y atrás
             //|| "Neutral" == this.cboDNR.SelectedItem.ToString()
             {

                EstadoNeutral = false;

            }
        }

        private void EnviarDatos(object sender, EventArgs e)
        {
            if (EstadoDrive)
            {/*&& !EstadoReverse && !EstadoNeutral*/

                Estado_Direccion = S_Delantero.GetMovimiento();
            }
            else if(EstadoReverse != EstadoDrive)
            {
                Estado_Direccion = S_Trasero.GetMovimiento();
            }
            else if(EstadoNeutral)
            {
                Estado_Direccion = "In neutral state";
            }
            else if ((EstadoDrive = false) || (EstadoReverse = false) || (EstadoNeutral = false))
            {
                Estado_Direccion = S_Neutral.GetMovimiento("a");
            }

            
                this.MostarEstado.Text = Estado_Direccion + Opcion_Acelerar;
                //this.MostarEstado.Text = Estado_Direccion;
           
            

            EstadoDrive = false;
            EstadoNeutral = false;
            EstadoReverse = false;
            Opcion_Acelerar = null;
            //Estado_Direccion = null;




        }
    }
}
 