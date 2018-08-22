using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeSeguridadCIA
{
    class Sensores
    {
        private string ID;
        private string TipodeUsuario;
        private string TipodeSensor;
        private string usuario;
        protected bool Status;

        public string TipodeUsuario1 { get => TipodeUsuario; set => TipodeUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string TipodeSensor1 { get => TipodeSensor; set => TipodeSensor = value; }

        public void AbrirPuerta()
        {

        }

        public void CerrarPuerta()
        {

        }

        public void IdentificarUsuario()
        {
            if (TipodeUsuario == "Directivo")
            {
                Status = true;
            }
            else if ((TipodeUsuario == "Académico") && ((TipodeSensor == "Dactilar")||((TipodeSensor == "Voz"))))
            {
                Status = true;
            }
            else if ((TipodeUsuario == "Estudiante") && (TipodeSensor == "Voz")) 
            {
                Status = true;
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
