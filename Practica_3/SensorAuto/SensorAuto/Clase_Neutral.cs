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
            return "Without alarm" + Environment.NewLine; 
        }

        internal override string Frenar()
        {
            return "Wheels without brakes" + Environment.NewLine; 
        }

        internal override string GetMovimiento()
        {
            return "In a neutral state" + Environment.NewLine; 
        }

        internal string GetMovimiento(string a)
        {
            return "Braking in the dry" + Environment.NewLine;
        }

    }
}
