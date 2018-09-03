using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RestaOperadoresSobrecargada
    {
        private int[] resta_b;

        public RestaOperadoresSobrecargada()
        {
            resta_b = new int[2];
        }

        public void Cargar()
        {
            for (int f = 0; f < resta_b.Length; f++)
            {
                Console.Write("Ingrese componente:");
                resta_b[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < resta_b.Length; f++)
            {
                Console.Write(resta_b[f] + " ");
            }
            Console.WriteLine();
        }

        public static RestaOperadoresSobrecargada operator -(RestaOperadoresSobrecargada v1, RestaOperadoresSobrecargada v2)
        {
            RestaOperadoresSobrecargada res = new RestaOperadoresSobrecargada();
            for (int f = 0; f < res.resta_b.Length; f++)
            {
                res.resta_b[f] = v1.resta_b[f] - v2.resta_b[f];
            }
            return res;
        }
    }
}