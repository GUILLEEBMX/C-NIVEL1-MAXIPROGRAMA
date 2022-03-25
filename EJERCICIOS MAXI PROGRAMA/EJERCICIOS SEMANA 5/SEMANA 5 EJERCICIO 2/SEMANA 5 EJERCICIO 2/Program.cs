using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_5_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM;
            int MAYOR = 0;
            int CONTADOR = 0;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("INGRESA UN NUMERO");
                NUM = int.Parse(Console.ReadLine());
      
               CONTADOR = CONTADOR + 1;


                if (CONTADOR == 1)
                    MAYOR = NUM;

                if (NUM > MAYOR)
                    MAYOR = NUM;





                    








            }


            Console.WriteLine("EL NUMERO MAYOR ES:" + MAYOR);

            Console.ReadKey();

        }
    }
}
