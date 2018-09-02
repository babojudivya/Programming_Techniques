using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoresTest
{
    class Hijo_Dactilar:Padre_Sendores
    {
        internal override string Mensaje()
        {
            return "Validado Dactilar";
        }
    }
}
