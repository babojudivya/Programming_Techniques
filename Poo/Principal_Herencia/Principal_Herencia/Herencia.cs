using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal_Herencia
{
    class Herencia
    {
        static void Main(string[] args)
        {
            int Base_p = 0;
            int Altura_p = 0;
            Console.WriteLine( "Ingresa la base y altura: ");
            Base_p = Convert.ToInt16(Console.ReadLine());
            Altura_p = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("La base es: "+ Base_p + " La altura es: " + Altura_p);

            Rectangulo Objeto_rectangulo = new Rectangulo();
            Objeto_rectangulo.SetBase(Base_p);
            Objeto_rectangulo.SetAltura(Altura_p);
            Console.WriteLine("El área es {0}", Objeto_rectangulo.GetArea_());

            Console.ReadKey();


        }
    }
}
