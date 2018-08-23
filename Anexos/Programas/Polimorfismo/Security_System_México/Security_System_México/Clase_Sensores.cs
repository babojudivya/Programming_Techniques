using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_System_México
{
    class Clase_Sensores
    {
        private string ID;
        private string TipoUsuario;
        private string TipoSensor;
        //internal string usuario;
        internal bool Status;

        internal string ID_Atributo
        {
            get { return ID; }
            set { ID = value; }
        }

        internal string TipoUsuario_Atributo
        {
            get { return TipoUsuario; }
            set { TipoUsuario = value; }
        }

        internal string TipoSensor_Atributo
        {
            get { return TipoSensor; }
            set { TipoSensor = value; }
        }

        public void AbrirPuerta()
        {

        }

        public void CerrarPuerta()
        {

        }

        public void IdentificarUsuario()
        {
            if ((TipoUsuario == "Directivo") && (TipoSensor == "Iris") && (ID=="Directivo"))
            {
                Status = true;
            }
            else if ((TipoUsuario == "Académico") && ((TipoSensor == "Voz") || ((TipoSensor == "Dactilar"))) && (ID == "Académico"))
            {
                Status = true;
            }
            else if ((TipoUsuario == "Estudiante") && (TipoSensor == "Dactilar") && (ID == "Estudiante"))
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
        }

        public void DenegarAcceso()
        {

        }

        public void ActivarAlarma()
        {

        }

        public void Bloquear()
        {

        }
    }
}
