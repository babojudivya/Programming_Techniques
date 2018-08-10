using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=5;
            int b=10;
            int a;
            bool condition = true;
            


            /*int num = 2;
            double num_2 = 30.33;
            Boolean status = true;
            Boolean status_2 = false;
            String message = "Hello";
            
            */

            /* Console.WriteLine("Hello, World");
             Console.Write(num);
             Console.Write("\n" + num_2);
             Console.Write("\n"+status);
             Console.Write("\n"+"Boolean\n" + status_2);
             Console.Write("\n" + message);
             Console.Read();

             */

            if (condition)
            {
                a = Convert.ToInt32(Console.ReadLine());
                a = a+1;
                //Console.WriteLine("The variable is set to true.");
                Console.WriteLine("a vale " + a);
                Console.ReadLine();

            }
            else
            {
                a = Convert.ToInt32(Console.ReadLine());
                a = b + 1;
                //Console.WriteLine("The variable is set to false.");
                Console.WriteLine("a vale " + a+5);
                Console.ReadLine();

            }

        }
    }

}




