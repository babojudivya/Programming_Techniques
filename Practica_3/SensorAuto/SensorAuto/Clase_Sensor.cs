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
        protected string Activar_Aceleracion = null;
        protected Boolean Accion_Frenar = false;
        protected string Sonando_Alarma = null;
        protected string Llantas_Stop = null;



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

        internal virtual string GetMovimiento()
        {
            return "Dirección Movimeinto" + Environment.NewLine;
        }

        internal virtual string Moviendose()
        {
            return "Moviendose" + Environment.NewLine;
        }
        internal virtual string Frenar()
        {
            return "Auto frenando" + Environment.NewLine;
        }



        internal abstract string Alarma();
        internal virtual string Acelerar()
        {
            if (Distancia_Ingresada >= 50)
            {
                Activar_Aceleracion = "Speeding up" + Environment.NewLine; //opción para moverse
            }
            else if (Distancia_Ingresada <= 2)
            {
                Activar_Aceleracion = "Slowing down" + Environment.NewLine; //ya no se tiene que mover
                Sonando_Alarma = Alarma();
                Llantas_Stop = Frenar();
            }
            else
            {
                Activar_Aceleracion = " ";
            }

            return Activar_Aceleracion + " " + Sonando_Alarma + Llantas_Stop;
        }

        internal Boolean Calcular_Distancia()
        {
            if (Distancia_Ingresada >= 2)
            {
                Activar_Movimiento = true; //opción para moverse
            }
            else if (Distancia_Ingresada <= 2)
            {
                Activar_Movimiento = false; //ya no se tiene que mover
            }
            return Activar_Movimiento;
        }
    }


}
