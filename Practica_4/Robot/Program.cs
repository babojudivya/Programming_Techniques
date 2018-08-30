using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Padre_Robot Saludo = new Padre_Robot("one");

            Padre_Robot Nombre = new Padre_Robot("one");


            int Mensaje = Saludo - Nombre;

            Console.WriteLine(Mensaje);
            Console.Read();
        }
    }
}
