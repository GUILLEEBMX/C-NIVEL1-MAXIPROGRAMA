using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_5_EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {


            int MAX_PAR = 0;
            int MINIMO_IMPAR = 0;
            int NUM = 0;
            int DIVISION = 0;
            int CONT_MAX = 0;
            int CONT_MIN = 0;



            for (int i = 0; i <= 19; i++)
            {

                Console.WriteLine("INGRESA UN NUMERO");
                NUM = int.Parse(Console.ReadLine());
                DIVISION = NUM % 2;

                if (DIVISION == 0)
                    CONT_MAX = CONT_MAX + 1;


                else
                    if (DIVISION != 0)
                    CONT_MIN = CONT_MIN + 1;

                if (CONT_MAX == 1)
                    MAX_PAR = NUM;
                else if (CONT_MIN == 1)
                    MINIMO_IMPAR = NUM;
                if (NUM > MAX_PAR && DIVISION == 0)
                    MAX_PAR = NUM;
                else if (NUM < MINIMO_IMPAR && DIVISION != 0)
                    MINIMO_IMPAR = NUM;



            }






            Console.WriteLine("EL NUMERO MAXIMO PAR ES:" + MAX_PAR);
            Console.WriteLine("EL NUMERO MINIMO IMPAR ES:" + MINIMO_IMPAR);

            Console.ReadLine();





        }
    }
}
