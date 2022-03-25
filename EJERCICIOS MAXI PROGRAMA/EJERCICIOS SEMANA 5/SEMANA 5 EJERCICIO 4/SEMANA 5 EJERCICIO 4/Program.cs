using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_5_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;
            int DIVISION_1 = 0;
            int DIVISION_2 = 0;
            int PARES = 0;
            int NUM_PRIMO = 0;

        
            do
            {
                Console.WriteLine("INGRESA UN NUMERO COMPRENDIDO ENTRE CERO Y 1000");
                NUM = int.Parse(Console.ReadLine());

            } while (NUM < 0 || NUM > 1000);

            Console.WriteLine("ESTAS EN 2DO WHILE INGRESA UN NUMERO COMPRENDIDO ENTRE CERO Y 1000");
            NUM_PRIMO = int.Parse(Console.ReadLine());


            while (NUM_PRIMO > 0 && NUM_PRIMO < 1000)
            {



                DIVISION_1 = (NUM_PRIMO / NUM_PRIMO);
                DIVISION_2 = (NUM_PRIMO / 1);
                PARES = NUM_PRIMO % 2;


                if (DIVISION_1 == 1 && DIVISION_2 == NUM_PRIMO && PARES != 0 || NUM_PRIMO == 2)



                { Console.WriteLine("ES UN NUMERO PRIMO"); }
                else
                { Console.WriteLine("NO ES UN NUMERO PRIMO"); }

                Console.WriteLine("INGRESA UN NUMERO COMPRENDIDO ENTRE CERO Y 1000");
                NUM_PRIMO = int.Parse(Console.ReadLine());


            }




            Console.WriteLine("INGRESASTE UN NUMERO MENOR QUE CERO O MAYOR A 1000, GAME OVER!!!!");

            Console.ReadKey();



        }
    }
}
