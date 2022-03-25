using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_8_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;




            //Console.WriteLine("EL NUMERO ES PRIMO: " + PRIMO(NUM));

            Console.WriteLine("EL PROMEDIO DE NUMEROS PRIMOS ES: " + PRIMOS(NUM) + " %");

            Console.ReadKey();
           


        }




        static bool PRIMO (int NUM)

        {
            
           

           
            int CONTADOR = 0;

            Console.WriteLine("INGRESA UN NUMERO");
            NUM = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NUM; i++)
            {

                if (NUM % i == 0)
                    CONTADOR++;
            }

        

            if (CONTADOR == 2)
                return true;
            else
                return false;

        }

        static double PRIMOS (int NUM)

        {
            double PROMEDIO = 0;
            int CONTADOR_PRIMOS = 0;
            int ACUMULADOR = 0;


            Console.WriteLine("INGRESA NÚMEROS...");
            NUM = int.Parse(Console.ReadLine());


            while (NUM != 0)
            {



                int CONTADOR = 0;



                for (int i = 1; i <= NUM; i++)
                {
                    if (NUM % i == 0)
                        CONTADOR++;


                }

                if (CONTADOR == 2)
                {
                    CONTADOR_PRIMOS++;
                    ACUMULADOR = ACUMULADOR + NUM;
                }
          


                NUM = int.Parse(Console.ReadLine());


            }


            Console.WriteLine("CONTADOR:  " + (CONTADOR_PRIMOS ) );

            Console.WriteLine("ACUMULADOR:  " + (ACUMULADOR));



            PROMEDIO = ACUMULADOR / CONTADOR_PRIMOS;

            



            return  PROMEDIO;
        }







    }
}
