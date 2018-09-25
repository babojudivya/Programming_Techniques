using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
    class SubClaseMessengerFacebook: ClaseMensajes, InterfaceProgramarPublicacion
    {
        public SubClaseMessengerFacebook(string publicacion):base(publicacion)
        {
            this.publicacion = publicacion;
        }


        public string GuardarMipublicacionPreprogramada(bool sino)
        {
           string estado = "";
            if (sino==true)
            {
                estado = " guardando tu acción";
            }
            else
            {
                estado = "borrando tu acción";
            }
            return estado;
        }
    }
}
