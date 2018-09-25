using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
    internal class SubClaseWhatsApp : ClaseMensajes
    {
        public  SubClaseWhatsApp(string publicacion) : base(publicacion)
        {
            this.publicacion = publicacion;
        }
    }     
}
