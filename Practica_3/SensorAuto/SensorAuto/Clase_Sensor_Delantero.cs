using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAuto
{
    class Clase_Sensor_Delantero: Clase_Sensor
    {

        internal override string Alarma()
        {
            return "Alarma delantera sonando";
        }

        internal override string Acelerar()
        {
            string Direccion_Aceleracion = null;

            if (Activar_Movimiento)
            {
                if (distancia_Ingresada > 120)
                {
                    Direccion_Aceleracion = "Acelerando Adelante";
                }
            }

            return Direccion_Aceleracion;
        }

        internal override string Frenar()
        {
            return "Llantas delanteras frenando";
        }
    }
}
