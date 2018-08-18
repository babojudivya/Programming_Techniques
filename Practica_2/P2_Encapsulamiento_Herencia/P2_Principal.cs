using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Encapsulamiento_Herencia
{
    class P2_Principal
    {
        static void Main(string[] args)
        {
            string Nombre_Empresa_Rl;
            string Nombre_Rl;
            string Sexo_Rl;
            int Edad_Rl;

            //Creo una instancia de una Persona
            Clase_Persona CEO = new Clase_Persona();
            Console.WriteLine("Datos del CEO \nIngresa el nombre de la empresa:");
            Nombre_Empresa_Rl = Console.ReadLine();
            Console.WriteLine("\nIngresa el nombre:");
            Nombre_Rl = Console.ReadLine();
            Console.WriteLine("\nIngresa el sexo:");
            Sexo_Rl = Console.ReadLine();
            Console.WriteLine("\nIngresa la edad:");
            Edad_Rl = Convert.ToInt16(Console.ReadLine());

            CEO.SetNombre_Empresa(Nombre_Empresa_Rl);
            CEO.SetNombre(Nombre_Rl);
            CEO.SetSexo(Sexo_Rl);
            CEO.SetEdad(Edad_Rl);

            Console.WriteLine("\n======================================");
            Console.WriteLine("Nombre de la empresa: " + CEO.GetNombre_Empresa() + "\nNombre: " + CEO.GetNombre()+ "\nSexo: " +CEO.GetSexo()+ "\nEdad: " + CEO.GetEdad());

            Console.Read();

        }
    }
}
