using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
    class ClaseMensajes
    {
        protected string  publicacion;
        private string estado;
        private string emoji;
        private string etiqueta;
        private string ubicacion;
       public ClaseMensajes(string publicacion) //Ingresa el estado
        {
            this.publicacion = publicacion;
        }

        public string Estado()
        {
            return publicacion;
        }

        public string Emoji()
        {
            Console.WriteLine("Agrega reacción: ");
            emoji = Console.ReadLine();
            return emoji;
        }

        public string Etiquetar()
        {
            Console.WriteLine("Etiqueta a alguien: ");
            etiqueta = Console.ReadLine();
            return etiqueta;
        }

        public string Ubicacion()
        {
            Console.WriteLine("Agrega tu  ubicación: ");
            ubicacion = Console.ReadLine();
            return ubicacion;
        }

    }
}
