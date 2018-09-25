using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
    class Program
    {
        static void Main(string[] args)
        {
            string ubicacion;
            string emoji;
            string etiqueta;
            string hastag;
            string sinoPublicar;
            string respuesta;

            Console.WriteLine("Bienvenido a las redes sociales más influyentes\npublica de forma aleatoria\n");

            //Las instanciaciones de las -subclases-
            SubClaseInstagram instagram = new SubClaseInstagram("Tus acciones en ");
            etiqueta = instagram.Etiquetar();

            SubClaseMessengerFacebook fb = new SubClaseMessengerFacebook("Tus acciones en ");
            ubicacion = fb.Ubicacion();

            SubClaseWhatsApp wa = new SubClaseWhatsApp("Tus acciones en ");
            emoji = wa.Emoji();


            //Accediendo a la interface 
            hastag = instagram.IngresaHastag("#TecnicasProgram");

           

            Console.WriteLine(fb.Estado() + "Facebook" );
            Console.WriteLine("Estas agregando tu ubicacion: " + ubicacion);
            Console.WriteLine("¿Deseas guardar la acción?");
            respuesta = Console.ReadLine();
            if(respuesta == "si")
            {
                //Accediendo a la interface 
                sinoPublicar = fb.GuardarMipublicacionPreprogramada(true);
            }
            else
            {
                //Accediendo a la interface 
                sinoPublicar = fb.GuardarMipublicacionPreprogramada(false);
            }
            Console.WriteLine(fb.Estado() + "facebook han conclcuido" + sinoPublicar);

            Console.WriteLine(wa.Estado() + "WhatsApp");
            Console.WriteLine("Estas agregando un emoji: " + emoji);
            Console.WriteLine(instagram.Estado() + "Instagram");
            Console.WriteLine("Estas agregando una etiqueta " + etiqueta + " y un hastag aleatorio" + hastag);
            Console.ReadKey();

        }
    }
}
