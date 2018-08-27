using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAuto
{
    class Clase_Sensor_Trasero: Clase_Sensor
    {

        internal override string Alarma()
        {
            return "Back alarm activated" + Environment.NewLine;
        }

        internal override string Frenar()
        {
            return "Back wheels braking" + Environment.NewLine; 
        }

        internal override string GetMovimiento()
        {
            return "The car can move back" + Environment.NewLine; 
        }

    }
}
