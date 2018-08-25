using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAuto
{
    class Clase_Sensor_Neutral:Clase_Sensor
    {
        internal override string Alarma()
        {
            return "Alarma estática";
        }

        internal override string Acelerar()
        {
            string Direccion_Aceleracion = null;

            if (Activar_Movimiento)
            {
                if (distancia_Ingresada < 30)
                {
                    Direccion_Aceleracion = "Modo estático";
                }
            }

            return Direccion_Aceleracion;
        }

        internal override string Frenar()
        {
            return "Llantas traseras y delanteras frenando";
        }
    }
}
