using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;


            Console.WriteLine("INGRESA UN NUMERO");
            NUM = int.Parse(Console.ReadLine());


            if (NUM > 10)
                Console.WriteLine("EL NUMERO ES MAYOR A 10");
            else
                Console.WriteLine("EL NUMERO NO ES MAYOR A 10");

            Console.ReadKey();

        }
    }
}
