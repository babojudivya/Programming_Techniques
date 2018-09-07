using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class OperacionesAlgebraicas_Multiplicacion
    {
        int[] matriz_1;
        int[] matriz_2;


        public OperacionesAlgebraicas_Multiplicacion(int[] matriz_1, int[] matriz_2)
        {
            this.matriz_1 = matriz_1;
            this.matriz_2 = matriz_2;
        }

        public void RestaVector()
        {
            Console.Write("Multiplicacion \n");
            int tamano = matriz_1.Length;
            int[] SumaMAtriz = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                SumaMAtriz[i] = matriz_1[i] * matriz_2[i];
            }
            Console.WriteLine("La multiplicacion de los vectores es: ");
            for (int i = 0; i < matriz_1.Length; i++)
            {
                Console.Write("[" + SumaMAtriz[i] + "] ");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
