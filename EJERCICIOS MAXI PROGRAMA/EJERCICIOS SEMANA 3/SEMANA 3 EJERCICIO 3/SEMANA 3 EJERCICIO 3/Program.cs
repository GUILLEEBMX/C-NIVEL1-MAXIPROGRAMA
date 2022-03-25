using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float IMPORTE = 0;
            float DESCUENTO_10 = 0;
            float DESCUENTO_18 = 0;


            Console.WriteLine("INGRESA EL IMPORTE");

            IMPORTE = int.Parse(Console.ReadLine());

            if (IMPORTE < 1000)
            { Console.WriteLine("NO HAY DESCUENTO"); }
            else
            {
                if (IMPORTE >= 1000 && IMPORTE < 5000)
                {
                    DESCUENTO_10 = IMPORTE * 10 / 100;
                    IMPORTE = IMPORTE - DESCUENTO_10;
                    Console.WriteLine("CON EL DESCUENTO DEL 10% EL TOTAL SERA DE: " + "$"  + IMPORTE);

                }

                else
                {

                    if (IMPORTE >= 5000)

                    {
                        DESCUENTO_18 = IMPORTE * 18 / 100;
                        IMPORTE = IMPORTE - DESCUENTO_18;

                        Console.WriteLine("CON EL DESCUENTO DEL 18% EL TOTAL SERA DE: " + "$" + IMPORTE);

                    }

                   

                }
            }


            Console.ReadKey();
        }

        
    }
}
