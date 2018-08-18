using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Creación de una clase base
El alumno definirá y programará una clase que cuente con al menos tres
atributos y los métodos necesarios para la lectura y/o escritura de los valores de
cada atributo.*/
namespace P2_Encapsulamiento_Herencia
{
    class Clase_Humano
    {
        //al menos tres atributos
        protected string Nombre = " ";
        protected Boolean Sexo = false;
        protected int Edad = 0;

        /*Clase_Humano(string Nombre, Boolean Sexo, int Edad)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Edad = Edad;
        }
        */

        /*y los métodos necesarios para la lectura y/o escritura de los valores de
            cada atributo.*/
        public void SetNombre(string Nombre) {
            this.Nombre = Nombre;
        }

        public void SetSexo(string Sexo_string)
        {
            if(Sexo_string == "Hombre" || Sexo_string == "hombre")
            {
                Sexo = true;
            }else if (Sexo_string == "Mujer" || Sexo_string == "mujer")
            {
                    Sexo = false;
            }
            
        }

        public void SetEdad(int Edad)
        {
            this.Edad = Edad;
        }

    }
}
