using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_6_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM_PRIMO;
            int CONTADOR = 0;
            int CONTADOR_FINAL = 0;







            for (int i = 0; i < 10; i++)
            {
               

                Console.WriteLine("INGRESA UN NUMERO");
            NUM_PRIMO = int.Parse(Console.ReadLine());


 

                for (int x = 1; x <= NUM_PRIMO ; x++)

                {

                if (NUM_PRIMO % x == 0)
                        CONTADOR = CONTADOR + 1;

                    
                }



                


                if (CONTADOR == 2)
                {
                    CONTADOR_FINAL = CONTADOR_FINAL + 1;
                    Console.WriteLine("ES UN NUMERO PRIMO");
                }
                else
                {
                    Console.WriteLine("NO ES UN NUMERO PRIMO");
                }






                
                CONTADOR = 0;

            }

           

            

            Console.WriteLine("LA CANTIDAD DE NUMEROS PRIMOS SON : " +  CONTADOR_FINAL);

            Console.ReadLine();



        }
    }
}
