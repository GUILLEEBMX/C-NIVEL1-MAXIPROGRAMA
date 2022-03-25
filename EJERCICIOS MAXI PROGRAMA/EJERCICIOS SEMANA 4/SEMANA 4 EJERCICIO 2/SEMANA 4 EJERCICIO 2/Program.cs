using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float IMPORTE_TOTAL, TOTAL_LITROS,DTO_10,DTO_15,DTO_25;


            Console.WriteLine("INGRESE EL IMPORTE TOTAL VENDIDO:");
            IMPORTE_TOTAL = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL TOTAL DE LITROS");
            TOTAL_LITROS = float.Parse(Console.ReadLine());

            if (TOTAL_LITROS <= 100)
            { Console.WriteLine("NO HAY DESCUENTO"); }

            else if (TOTAL_LITROS > 100 && TOTAL_LITROS <= 300)
            {
                DTO_10 = IMPORTE_TOTAL * 10 / 100;

                IMPORTE_TOTAL = IMPORTE_TOTAL - DTO_10;

                Console.WriteLine("CON EL DESCUENTO DEL 10% EL IMPORTE TOTAL SERA DE: " + IMPORTE_TOTAL);

            }

            else if (TOTAL_LITROS > 300 && TOTAL_LITROS <= 500)
            {
                DTO_15 = IMPORTE_TOTAL * 15 / 100;

                IMPORTE_TOTAL = IMPORTE_TOTAL - DTO_15;

                Console.WriteLine("CON EL DESCUENTO DEL 15% EL IMPORTE TOTAL SERA DE: " +  IMPORTE_TOTAL);


            }

            else if (TOTAL_LITROS > 500)

            {
                DTO_25 = IMPORTE_TOTAL * 25 / 100;

                IMPORTE_TOTAL = IMPORTE_TOTAL - DTO_25;

                Console.WriteLine("CON EL DESCUENTO DEL 25% EL IMPORTE TOTAL SERA DE: " + IMPORTE_TOTAL);

            }


            Console.ReadKey();

        }
    }
}
