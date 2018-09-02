using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Operacion_M : Exception
    {
        protected Double Item_1;
        protected Double Total_M;
        protected Double DineroRest;

        public Double Suma_M( Double Item_1)
        {
            this.Item_1 = Item_1;
            Total_M += Item_1;
            return Total_M;
        }

        public Double DienroRestante(Double DineroRest)
        {
            this.DineroRest = DineroRest;
            DineroRest = DineroRest - Total_M;

            if (DineroRest <= -1)
                throw new Operacion_M();
            return DineroRest;
        }



    }
}
