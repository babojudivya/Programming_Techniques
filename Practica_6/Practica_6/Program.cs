using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserción de elementos

            //int Respuesta_Busqueda_SiNo = 0;

          
        
           
            int Respuesta_Opciones = 0;

            OperacionesArreglos matriz_1 = new OperacionesArreglos();
            OperacionesArreglos matriz_2 = new OperacionesArreglos();
           

            do
            {
                Console.Clear();
                Console.Write("Matriz 1: \n");
                Console.Write("[1] - Inserción \n");
                Console.Write("[2] - Búsqueda \n");
                Console.Write("[3] - Eliminación \n");
                //Console.Write("[4] - Inserción específica \n");
                Console.Write("[4] - Listado \n");
                Console.Write("[0] - Salir \n");


                Console.Write("Matriz 2: \n");
                Console.Write("[11] - Inserción \n");
                Console.Write("[22] - Búsqueda \n");
                Console.Write("[33] - Eliminación \n");
                //Console.Write("[4] - Inserción específica \n");
                Console.Write("[44] - Listado \n");

                Console.Write("Operaciones entre elementos: \n");
                Console.Write("[77] - Suma \n");
                Console.Write("[88] - Resta \n");
                Console.Write("[99] - Multiplicaion \n");
                //Console.Write("[1010] - División \n");

                Respuesta_Opciones = Convert.ToInt16(Console.ReadLine());
                switch (Respuesta_Opciones)
                {
                    case 1:
                        Console.Write("Inicialización \n");
                        matriz_1.Insercion();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Búsqueda  \n");
                        matriz_1.Busqueda();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Eliminación  \n");
                        matriz_1.Eliminar();
                         Console.ReadKey();
                        break;
                    /*case 4:
                        Console.Write("Inserción especifica  \n");
                        operacionVarias.InsercionEspecifica();
                        Console.ReadKey();
                        break;*/
                    case 4:
                        Console.Write("Listado  \n");
                        matriz_1.Listar();
                        Console.ReadKey();
                        break;


                    case 11:
                        Console.Write("Inicialización \n");
                        matriz_2.Insercion();
                        Console.ReadKey();
                        break;

                    case 22:
                        Console.Write("Búsqueda  \n");
                        matriz_2.Busqueda();
                        Console.ReadKey();
                        break;

                    case 33:
                        Console.Write("Eliminación  \n");
                        matriz_2.Eliminar();
                        Console.ReadKey();
                        break;
                    /*case 4:
                        Console.Write("Inserción especifica  \n");
                        operacionVarias.InsercionEspecifica();
                        Console.ReadKey();
                        break;*/
                    case 44:
                        Console.Write("Listado  \n");
                        matriz_2.Listar();
                        Console.ReadKey();
                        break;
                    case 77:
                        Console.Write("Suma \n");
                        OperacionesAlgebraicas suma_1 = new OperacionesAlgebraicas(matriz_1.Contar(), matriz_2.Contar());
                        suma_1.SumaVector();
                        Console.ReadKey();
                        break;

                    case 88:
                        Console.Write("Resta  \n");

                        OperacionesAlgebraicas_Resta resta_1 = new OperacionesAlgebraicas_Resta(matriz_1.Contar(), matriz_2.Contar());
                        resta_1.RestaVector();
                        Console.ReadKey();
                        break;
                    case 99:
                        Console.Write("Multiplicación  \n");
                        OperacionesAlgebraicas_Multiplicacion multi_1 = new OperacionesAlgebraicas_Multiplicacion(matriz_1.Contar(), matriz_2.Contar());
                        multi_1.RestaVector();
                        Console.ReadKey();
                        break;
                    /*     case 1010:
                             Console.Write("División  \n");
                             OperacionesAlgebraicas_Divi Divi_1 = new OperacionesAlgebraicas_Divi(matriz_1.Contar(), matriz_2.Contar());
                             Divi_1.RestaVector();
                             Console.ReadKey();
                             break;*/
                    default:
                        Console.Write("Saliendo de la aplicación  \n");
                        Console.ReadKey();
                        break;


                }
            } while (Respuesta_Opciones !=0);
            
        }
    }
}
