using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    class OperacionesAlgebraicas_Divi
    {
        int[] matriz_1;
        int[] matriz_2;


        public OperacionesAlgebraicas_Divi(int[] matriz_1, int[] matriz_2)
        {
            this.matriz_1 = matriz_1;
            this.matriz_2 = matriz_2;
        }

        public void RestaVector()
        {
            Console.Write("Division\n");
            int tamano = matriz_1.Length;
            int[] SumaMAtriz = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                if (i==0)
                {
                    i++;
                }
                else
                {
                    SumaMAtriz[i] = matriz_1[i] / matriz_2[i];
                }
            }
            Console.WriteLine("La división de los vectores es: ");
            for (int i = 0; i < matriz_1.Length; i++)
            {
                Console.Write("[" + SumaMAtriz[i] + "] ");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
