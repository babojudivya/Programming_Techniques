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
            return "Front alarm activated" + Environment.NewLine; 
        
        }

  
        internal override string Frenar()
        {
            return "Front wheels Braking dry" + Environment.NewLine;
        }

        internal override string GetMovimiento()
        {
            return "The car can move forward" + Environment.NewLine;
        }



    }
}
