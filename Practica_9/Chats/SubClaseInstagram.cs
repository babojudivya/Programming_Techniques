using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
  class SubClaseInstagram :ClaseMensajes, InterfaceHastag
    {
        public SubClaseInstagram(string publicacion) : base(publicacion)
        {
            this.publicacion = publicacion;
        }

        public string IngresaHastag(string hastag)
        {
            return ": " + hastag;
        }
    }
}
