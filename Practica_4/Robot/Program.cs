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
            int total_numeros, suma_1, resta_1;
            int[] array3;
            array3 = new int[4];
            Puntaje point = new Puntaje();
            PuntajeNegativo point_n = new PuntajeNegativo();
            int PruebaOperadoresBinarios, PruebaOperadoresBinariosResta;


            Console.WriteLine("Cuántos números quieres sumar y restar  al mismo tiempo [2],[3],[4]");
            total_numeros = Convert.ToInt16(Console.ReadLine());

            for (int i=1; i< total_numeros+1; i++)
            {
                Console.WriteLine("[{0}]:",i );
                array3[i-1] = Convert.ToInt16(Console.ReadLine());
            }

            if(total_numeros == 2)
            {
            suma_1 = point.Numeros(array3[0], array3[1]);
                resta_1 = point_n.Numeros2(array3[0], array3[1]);

                //operaciones entre los objetos generados 
                Operadores op = new Operadores(array3[0]);
                Operadores op_2 = new Operadores(array3[1]);

                PruebaOperadoresBinarios = op + op_2;

                Console.WriteLine("La suma es {0}", suma_1);
                Console.WriteLine("La suma de operadores binarios es {0}", PruebaOperadoresBinarios);

                OperadoresNegativos opN = new OperadoresNegativos(array3[0]);
                OperadoresNegativos opN_2 = new OperadoresNegativos(array3[1]);

                PruebaOperadoresBinariosResta = opN - opN_2;
                Console.WriteLine("La resta es {0}", resta_1);
                Console.WriteLine("La resta de operadores binarios es {0}", PruebaOperadoresBinariosResta);

            }
            else if(total_numeros == 3)
            {
                suma_1 =point.Numeros(array3[0], array3[1], array3[2]);
            }
            else 
            {
                suma_1 = point.Numeros(array3[0], array3[1], array3[2],array3[3]);
            }


            RestaOperadoresSobrecargada v1 = new RestaOperadoresSobrecargada();
            Console.WriteLine("Carga el primer número");
            v1.Cargar();
            RestaOperadoresSobrecargada v2 = new RestaOperadoresSobrecargada();
            Console.WriteLine("Carga el segundo número");
            v2.Cargar();
            Console.WriteLine("Primer número");
            v1.Imprimir();
            Console.WriteLine("Segundo número");
            v2.Imprimir();
            RestaOperadoresSobrecargada vt;
            vt = v1 - v2;
            Console.WriteLine("Resta Resultante");
            vt.Imprimir();
            Console.ReadKey();
        }
    }
}

