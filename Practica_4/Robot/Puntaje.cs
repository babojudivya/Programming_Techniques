using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
   class Puntaje
    {
        protected int a,b,c,d;
        public  int Numeros(int a, int b)
        {
            this.a = a;
            this.b = b;
            return a+b ;
        }

        public int Numeros(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            return a + b + c;
        }
        public int Numeros(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            return a + b + c + d;
        }
    }
}

