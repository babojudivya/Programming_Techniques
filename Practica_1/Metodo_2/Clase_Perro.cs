using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perro
{
    class Clase_Perro
    {
        public string tamanho;
        public string raza;
        public int peso;
        public string color;
        public string sexo;
        public int resultado;

       public Clase_Perro(string tamanho, string raza, int peso, string color, string sexo)
        {
        this.tamanho=tamanho;
        this.raza = raza;
        this.peso = peso;

            //extra
       this.color = color;
       this.sexo = sexo;

    }

        enum TIPOS_COMIDA { croquetas, pescado, manzanas };

        public void Ladrar(){
            Console.WriteLine("ladrar");
            Console.ReadKey();
        }

        public int Comer(string alimento)
        {
          

           if (alimento==Convert.ToString(TIPOS_COMIDA.croquetas))
            {
               resultado = 1;
            }else if(alimento == Convert.ToString(TIPOS_COMIDA.pescado)){
                resultado = 2;
            }
            else if(alimento == Convert.ToString(TIPOS_COMIDA.manzanas)){
                resultado = 3;
            }
           else
            {
                resultado = 0;
            }
            return resultado;
            
            
        }

        public void Correr()
        {
            Console.WriteLine("corriendo");
            Console.ReadKey();

        }

        public  void Cagar()
        {
            Console.WriteLine("Defecando");
            Console.ReadKey();

        }




    }
}
