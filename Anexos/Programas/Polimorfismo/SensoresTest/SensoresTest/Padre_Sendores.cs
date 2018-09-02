using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoresTest
{
    abstract class Padre_Sendores
    {

        protected string UsuarioValidado = null;
        protected Boolean UValido = false;

        internal string UsuarioValidado1
        {
            get { return UsuarioValidado; }
            set { UsuarioValidado = value; }
        }


        internal Boolean ValidarUsuario()
        {
            if("Directivo" == UsuarioValidado1)
            {
                UValido = true;
            }

            return UValido;
        }

        internal abstract string Mensaje();

        internal  virtual string Alarma()
        {
            return "Alarma";
        }



    }
}
