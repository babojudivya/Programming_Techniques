using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Principal_Mascota
{
    class Mascotas
    {
        static void Main(string[] args)
        {
            string Pregunto_Tipo_alimento;
            string Pregunto_Nombre_Perro;
            string Tipo_alimento;
            int Ladra_alegra;
            string respuesta_orinar;
            int respuesta_anhos_orinar;
            string respuesta_muerde;
            string respuesta_muerde_poder;
            string respuesta_correr;
            float respuesta_correr_km;
            int dias;
            string respuesta_apagar;
            Boolean apagar;
            Double altura;
            int peso;

            //Creo interacción entre el usuario y el programa
            Console.WriteLine("Los secretos de tu mascota\n¿Cómo se llama tu perro?");
            Pregunto_Nombre_Perro = Console.ReadLine();
            //Creo una instancia, es decir, un objeto de mi clase perro
            Perro Boxer = new Perro(Pregunto_Nombre_Perro);

            Console.WriteLine("¿Cuánto mediría el clon de " + Boxer.Nombre + " en [cm] ?");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿Cuánto pesaría el clon de " + Boxer.Nombre + " en [kg] ?");
            peso = Convert.ToInt16(Console.ReadLine());

            Perro Boxer_2 = new Perro(altura, peso);

            //Accedo al atributo nombre y lo modifico
            Boxer.Nombre = Pregunto_Nombre_Perro;
            //Accedo al método tipo de comida (nutritivo o dañino)
            Console.WriteLine("2 - ¿Qué come " +Boxer.Nombre + "?");
            Pregunto_Tipo_alimento = Console.ReadLine();
            Tipo_alimento = Boxer.Come(Pregunto_Tipo_alimento);
            Console.WriteLine(Boxer.Nombre + Tipo_alimento);
            

            //Acceso al método ladrar
            Console.WriteLine("3 - ¿Alguna vez ha ladrado " + Boxer.Nombre + " cuando llegas a casa?" + " (si = 1 / no = 0) ");
            Ladra_alegra = Convert.ToInt16(Console.ReadLine());
            if (Boxer.Ladra(Ladra_alegra))
            {
                Console.WriteLine(Boxer.Nombre + " te ama");
            }
            else if(Boxer.Ladra(Ladra_alegra) != true)
            {
                Console.WriteLine(Boxer.Nombre + " te usa");
            }

            //Acceso al método Orina
            Console.WriteLine("4 - ¿Has visto orinar a " + Boxer.Nombre + "?" + " si/no");
            respuesta_orinar = Console.ReadLine();
            respuesta_anhos_orinar = Boxer.Orina(respuesta_orinar);
            Console.WriteLine("Vivirás " + respuesta_anhos_orinar + " años viendo eso");

            //Acceso al método Muerde
            Console.WriteLine("5 - ¿Te ha mordido " + Boxer.Nombre + "?" + " si/no");
            respuesta_muerde = Console.ReadLine();
            respuesta_muerde_poder = Boxer.Muerde(respuesta_muerde);
            Console.WriteLine(respuesta_muerde_poder);

            //Acceso al método correr
            Console.WriteLine("6 - ¿Tegustaría correr con " + Boxer.Nombre + "?" + " si/no");
            respuesta_correr = Console.ReadLine();
            respuesta_correr_km = Boxer.Corre(respuesta_correr);
            Random rndd = new Random();
            dias = rndd.Next(1, 8);
            Console.WriteLine("En "+ dias + " días correrás " + respuesta_correr_km + " km con " + Boxer.Nombre);

            //Acceso al método se hace el muerto
            Console.WriteLine("7 - ¿cress que " + Boxer.Nombre + " se haga el muerto?" + " si/no");
            respuesta_apagar = Console.ReadLine();
            apagar = Boxer.se_hace_el_muerto(respuesta_apagar);
            if (apagar)
            {
                Console.WriteLine(Boxer.Nombre + "se hará el muerto en" + "\n3"+ "\n2" +"\n1");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine(Boxer.Nombre + "se durmió");
            }

            Console.WriteLine("Algún día " + Boxer.Nombre + " tendrá un clon con un tamaño de " + Boxer_2.Tamanho + " cm y su masa será de " + Boxer_2.Peso + " kg ");
            Console.ReadKey();
        }
    }
}
