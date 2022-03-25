using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;


            Console.WriteLine("INGRESA UN NUMERO");
            NUM = int.Parse(Console.ReadLine());


            if (NUM > 0)
                Console.WriteLine("EL NUMERO ES POSITIVO");
            else
                if (NUM < 0)
                Console.WriteLine("EL NUMERO ES NEGATIVO");
            else
                if (NUM == 0)
                Console.WriteLine("EL NUMERO ES IGUAL CERO");

            Console.ReadKey();


        }
    }
}
