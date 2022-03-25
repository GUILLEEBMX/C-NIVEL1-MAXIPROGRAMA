using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3, NUM4, MAYOR1 =0 ,MAYOR2 = 0 ,MAYOR3 = 0,MAYOR4 = 0;


            Console.WriteLine("INGRESA EL PRIMER VALOR:");
            NUM1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL SEGUNDO VALOR:");
            NUM2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL TERCER VALOR:");
            NUM3 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL CUARTO VALOR:");
            NUM4 = int.Parse(Console.ReadLine());


            if (NUM1 > 100)
            {
                MAYOR1 = NUM1;
                Console.WriteLine(MAYOR1 + " ES MAYOR A 100");
            }

            if (NUM2 > 100)
            {

                MAYOR2 = NUM2;
                Console.WriteLine(MAYOR2 + " ES MAYOR A 100");
            }


            if (NUM3 > 100)
            {
                MAYOR3 = NUM3;
                Console.WriteLine(MAYOR3 + " ES MAYOR A 100");
            }


            if (NUM4 > 100)
            {
                MAYOR4 = NUM4;
                Console.WriteLine(MAYOR4 + " ES MAYOR A 100");
            }





            Console.ReadKey();

        }
    }
}
