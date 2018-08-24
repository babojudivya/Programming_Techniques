using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_System_México
{
    class Clase_Voz: Clase_Sensores
    {
        public override string GetID()
        {
            return "Devolviendo ID de Voz";
        }
        public override string ActivarAlarma()
        {
            return "Alarma de Voz activada";
        }
    }
}
