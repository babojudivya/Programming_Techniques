using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Padre_Robot
    {
        //Double numero;

        public Padre_Robot(string valor_Ingresado)
        {
            Frase = valor_Ingresado.Length;
        }


        public static int operator -(Padre_Robot x, Padre_Robot y)
        {
            return x.Frase + y.Frase;
        }

        public int Frase { get; set; }
    }
}
