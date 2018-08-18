using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Creación de una clase derivada
El alumno definirá una clase derivada a partir de la clase base que definió
previamente y deberá realizar un programa que demuestre que efectivamente
fueron heredados todos los atributos y métodos de la clase base, sin necesidad
de verificar ni de modificar el código fuente original.*/


/*Una vez comprobado lo anterior, deberá añadirse al menos un atributo nuevo a
la clase derivada, así como los métodos de lectura/escritura de valores que sean
necesarios*/
namespace P2_Encapsulamiento_Herencia
{
    class Clase_Persona:Clase_Humano
    {
        protected string Nombre_Empresa = " ";

        public void SetNombre_Empresa(string Nombre_Empresa)
        {
            this.Nombre_Empresa = Nombre_Empresa;
        }

        public string GetNombre_Empresa()
        {
            return Nombre_Empresa;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public string GetSexo()
        {
            if(Sexo == true)
            {
                return "hombre";
            }
            else
            {
                return "mujer";
            }
        }

        public int GetEdad()
        {
            return Edad;
        }
    }
}
