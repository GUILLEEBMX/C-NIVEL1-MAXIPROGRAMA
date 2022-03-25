using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_8_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int NUM = 0;




            Console.WriteLine("EL NUMERO ES PAR: " + PAR(NUM));

            Console.WriteLine("LA CANTIDAD DE NUMEROS PARES SON: " + PARES(NUM) );

            Console.ReadLine();

        }

        static bool PAR(int NUM)
        {

            Console.WriteLine("INGRESA UN NUMERO");
            NUM = int.Parse(Console.ReadLine());

            if (NUM % 2 == 0)
                return true;
            else
                return false;
        }

        static int PARES (int NUM)

        {
            int CONTADOR = 0;

            Console.WriteLine("INGRESA 20 NUMEROS...");

            for (int i = 0; i < 20; i++)
            {
                NUM = int.Parse(Console.ReadLine());
                if (NUM % 2 == 0)
                    CONTADOR++;
            }
            return  CONTADOR;
        }

    }
}
