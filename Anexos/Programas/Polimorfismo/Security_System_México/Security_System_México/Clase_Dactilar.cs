using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_System_México
{
    class Clase_Dactilar: Clase_Sensores
    {
        public override string ActivarAlarma()
        {
            return "Alarma Dactilar activada";

        }

        public override string GetID()
        {
            return "Devolviendo ID Dactilar";
        }
    }
}
