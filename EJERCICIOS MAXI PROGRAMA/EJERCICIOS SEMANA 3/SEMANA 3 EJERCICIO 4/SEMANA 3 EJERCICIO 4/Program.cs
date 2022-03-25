using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1 = 0, NUM2 = 0, NUM3 = 0, NUM4 = 0;

            int MENOR = 0;






            Console.WriteLine("INGRESA EL PRIMER NUMERO");
            NUM1 = int.Parse(Console.ReadLine());

            MENOR = NUM1;

            Console.WriteLine("INGRESA EL SEGUNDO NUMERO");
            NUM2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL TERCER NUMERO");
            NUM3 = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA EL CUARTO NUMERO");
            NUM4 = int.Parse(Console.ReadLine());



            if (NUM2 <= MENOR)
             MENOR = NUM2; 

            if (NUM3 <= MENOR)
                  MENOR = NUM3; 
               
            if (NUM4 <= MENOR)
                    MENOR = NUM4; 

            Console.WriteLine("EL MENOR ES:" + MENOR );

            Console.ReadKey();

        }
    }
}
