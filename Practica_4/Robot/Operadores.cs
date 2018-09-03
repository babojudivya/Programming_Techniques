using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Operadores
    {
        public int Suma { get; set; }
        public Operadores(int Suma)
        {
            this.Suma = Suma;
        }
        
        public static int operator +(Operadores a, Operadores b)
        {
            return a.Suma + b.Suma;
        }
    }
}
