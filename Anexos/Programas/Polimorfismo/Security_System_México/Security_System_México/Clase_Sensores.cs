using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_System_México
{
    /*Nuestra clase debe de ser abstracta*/
    abstract class Clase_Sensores
    {

        /*Los atributos deben de ser protected*/
        protected string ID;
        protected string TipoUsuario;
        protected string TipoSensor;
        //internal string usuario;
        protected bool Status_Validacion = false;

        //Único atributo que va a retorno valor por medio de una función abstracta 
        public string ID_Atributo
        {
            set { this.ID = value; }
        }

        public void SetTipoUsuario_Atributo(string user)
        {
            TipoUsuario = user;
        }

        public void SetTipoSensor_Atributo(string sensor)
        {
            TipoSensor = sensor;
        }

     
        //Metodo abstracto que va a retornar un valor
        public abstract string GetID();

        public virtual string ActivarAlarma()
        {
            return "Alarma activada";
        }

       
        internal Boolean IdentificarUsuario()
        {
            
            if ((TipoUsuario == "Directivo"))
            {
                Status_Validacion = true;
            }
            else if ((TipoUsuario == "Académico") && (TipoSensor != "Iris"))
            {
                Status_Validacion = true;
            }
            else if ((TipoUsuario == "Estudiante") && (TipoSensor == "Dactilar"))
            {
                Status_Validacion = true;
            }
            else
            {
                Status_Validacion = false;
            }

            return Status_Validacion;
        }


        /*public void AbrirPuerta()
        {

        }

        public void CerrarPuerta()
        {

        }

        public void DenegarAcceso()
        {

        }



        public void Bloquear()
        {

        }
        */
    }
}
