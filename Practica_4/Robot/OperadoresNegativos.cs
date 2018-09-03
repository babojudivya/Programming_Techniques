using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
     class OperadoresNegativos
    {
        public int Resta { get; set; }
        public OperadoresNegativos(int Resta)
        {
            this.Resta  = Resta;
        }

        public static int operator -(OperadoresNegativos a, OperadoresNegativos b)
        {
            return a.Resta - b.Resta ;
        }

     

    }
}
