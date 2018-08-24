using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAuto
{
    abstract class Clase_Sensor
    {

        protected float distancia_Calculada = 0.0f;
        protected float distancia_Ingresada = 0.0f;
        protected Boolean Activar_Movimiento = true;

        protected Boolean Accion_Frenar = false;

        internal float Distancia_Calculada
        {
            get
            {
                return distancia_Calculada;
            }

            set
            {
                distancia_Calculada = value;
            }
        }
        
        internal float Distancia_Ingresada
        {
            get
            {
                return distancia_Ingresada;
            }

            set
            {
                distancia_Ingresada = value;
            }
        }

        internal virtual string Frenar()
        {
            return "Auto frenando";
        }

        internal virtual string Acelerar()
        {
            return "Auto acelerando";
        }

        internal abstract string Alarma();

        internal Boolean Calcular_Distancia()
        {
            if (Distancia_Ingresada>=10)
            {
                Activar_Movimiento = true;
            }else if (Distancia_Ingresada <=10)
            {
                Activar_Movimiento = false;
            }
            return Activar_Movimiento;
        
        }
    }

 
}
