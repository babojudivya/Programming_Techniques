using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    class Program
    {
        enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA }

        static void Main(string[] args)


        {
            bool alimentado = false;

             Perro Perro1 = new Perro();

            Perro1.Raza = "French Puddle";
            Perro1.Peso = 7;
            Perro1.Sexo = "Macho";
            Perro1.Tamaño = "Pequeña";

             alimentado =Perro1.Comer((int)TIPOSDECOMIDA.AGUA);

            if (alimentado)
                Console.WriteLine("El perro " + Perro1.Raza + "comio" + Convert.ToString(TIPOSDECOMIDA.AGUA));


            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
