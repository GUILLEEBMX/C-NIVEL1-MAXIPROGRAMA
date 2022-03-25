using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_5_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int EDAD;
            int ACUMULADOR = 0;
            int CONT = 0;
            int PROMEDIO = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("INGRESA LA EDAD");
                EDAD = int.Parse(Console.ReadLine());

                if (EDAD >= 18)
                {
                    ACUMULADOR = ACUMULADOR + EDAD;
                    CONT = CONT + 1;
                }

                













            }


            PROMEDIO = ACUMULADOR / CONT;

            Console.WriteLine("EL PROMEDIO DE PERSONAS MAYORES A 18 AÑOS ES DE: " +  PROMEDIO);

          


            Console.ReadKey();



        }
    }
}
