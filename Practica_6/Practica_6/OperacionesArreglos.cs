using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class OperacionesArreglos
    {
        int[] numeros; // Declaración del array sin numeros     
        int num = 0;

        /*Método Insercion*/
        public void Insercion()
        {
                Console.Write("INSERCIÓN DE ELEMENTOS ");
                Console.Write("¿Cuántos números vas a introducir? ");
                num = Convert.ToInt16(Console.ReadLine());

                numeros = new int[num + 1]; // Instanciación del array 

                for (int i = 1; i <= num; i++)
                {
                    Console.Write("Ingresa el elemento {0}: ", i);
                    numeros[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Hay {0} número(s) introducido(s) ", num);
                //Console.WriteLine("Pulsa INTRO para listarlos");
                //string enter = Console.ReadLine();
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Elemento {0}: {1}", i, numeros[i]);
                }

        }
        /*Método Búsqueda*/
        public void Busqueda()
        {
            try
            {
                int Respuesta_Busqueda_Numero = 0;

                Console.WriteLine("¿Qué número deseas buscar?");
                Respuesta_Busqueda_Numero = Convert.ToInt16(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                    if (numeros[i] == Respuesta_Busqueda_Numero)
                        Console.WriteLine("El número {0} se ha encontrado en la posición {1} ", Respuesta_Busqueda_Numero, i);
                throw new System.ArgumentException("El elemento no existe");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("El número a buscar no existe");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        /*Método Eliminar*/

        public void Eliminar()
        {
            try
            {
                int Respuesta_Numero_Eliminar = 0;
                Console.WriteLine("Array actual: ");
                for (int ii = 0; ii < num; ii++)
                    Console.Write("{0} ", numeros[ii + 1]);
                Console.WriteLine();
                Console.WriteLine("¿Qué número deseas eliminar?");
                Respuesta_Numero_Eliminar = Convert.ToInt16(Console.ReadLine());

                int numToRemove = Respuesta_Numero_Eliminar;
                int numIdx = Array.IndexOf(numeros, numToRemove);
                List<int> tmp = new List<int>(numeros);
                tmp.RemoveAt(numIdx);
                numeros = tmp.ToArray();
                // Y volvemos a mostrar el array
                num = num - 1;
                Console.WriteLine("Array nuevo: ");
                for (int ii = 0; ii < num; ii++)
                    Console.Write("{0} ", numeros[ii + 1]);
                Console.WriteLine();
               
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("El número a eliminar no existe");
            }
            finally
            {
                Console.ReadKey();
            }
        }
        public void Listar()
        {
            Console.WriteLine("Hay {0} número(s) introducido(s) ", num);
            //Console.WriteLine("Pulsa INTRO para listarlos");
            //string enter = Console.ReadLine();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, numeros[i]);
            }

        }

        public int[] Contar()
        {
            Console.WriteLine("Hay {0} número(s) introducido(s) ", num);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, numeros[i]);
            }

            return numeros;
        }

        /*    public virtual void InsercionEspecifica()
            {


            }*/
    }

}
