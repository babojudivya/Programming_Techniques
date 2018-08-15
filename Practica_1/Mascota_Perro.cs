using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perro{
    class Mascota_Perro{
        static void Main(string[] args){
            Clase_Perro Objeto_Perro_1 = new Clase_Perro("mediano", "pook", 15, "amarillo", "masculino");
            Clase_Perro Objeto_Perro_2 = new Clase_Perro("mediano", "pook", 15, "amarillo", "masculino");
            Clase_Perro Objeto_Perro_3 = new Clase_Perro("mediano", "pook", 15, "amarillo", "masculino");
            /* Objeto_Perro_1.raza = "Chihuahua";
             Objeto_Perro_1.peso = 4;
             Objeto_Perro_1.sexo = "masculino";
             Objeto_Perro_1.tamanho = "Pequeño";
             */

            Console.WriteLine("El perro 3 pesa:"+Objeto_Perro_3.peso +"es de raza:"+ Objeto_Perro_3.raza + "tiene sexo:"+ Objeto_Perro_3.sexo +"y su tamaño es:"+ Objeto_Perro_3.tamanho);

            int respuesta= Objeto_Perro_1.Comer("manzanas");

            switch (respuesta){
                case 1:
                    Console.WriteLine("Hola soy un perro (1) y como croquetas");
                    break;
                case 2:
                    Console.WriteLine("Hola soy un perro (1) y como pescado");
                    break;
                case 3:
                    Console.WriteLine("Hola soy un perro (1) y como manzanas");
                    break;
                case 0:
                    Console.WriteLine("Hola soy un perro (1) y como nada");
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }
            Console.ReadKey();
        }
        
    }
}
