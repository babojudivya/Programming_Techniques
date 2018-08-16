using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    class Perro
    {
        
        public string Tamaño;
        public string Raza;
        public  string Sexo;
        public int Peso;
        public string Color;
        public enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA};


        public void Ladrar()
        {


        }

        public void Correr()
        {


        }
        
        public bool  Comer(int alimento)
        {


            if (alimento == (int)TIPOSDECOMIDA.AGUA)
            {
                return true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.BASURA)
            {
                return true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.CROQUETAS)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        public void Cagar()
        {


        }
    }
}
