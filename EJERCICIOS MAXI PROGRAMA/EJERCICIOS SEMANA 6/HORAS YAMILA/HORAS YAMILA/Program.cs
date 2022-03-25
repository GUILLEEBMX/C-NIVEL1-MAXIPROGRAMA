using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HORAS_YAMILA
{
    class Program
    {
        static void Main(string[] args)
        {

            float HORAS;
            int CONTADOR = 0;
            float ACUMULADOR = 0;


            for (int i = 0; i < 24; i++)
            {

                Console.WriteLine("INGRESA LAS HORAS");
                HORAS = float.Parse(Console.ReadLine());
                ACUMULADOR = ACUMULADOR + HORAS;
                CONTADOR++;

            }


            Console.WriteLine("LA CANTIDAD DE HORAS TRABAJADAS SON: " + ACUMULADOR + " HS ");
            Console.WriteLine("LA CANTIDAD DE DIAS TRABAJADOS SON: " +  CONTADOR + " DIAS" );
            Console.WriteLine("LA CANTIDAD DE DIAS NO TRABAJADOS SON " + (31 - CONTADOR) + " DIAS"  );



            Console.ReadLine();

            //Console.WriteLine("INGRESA LAS HORAS");
            //HORAS = float.Parse(Console.ReadLine());
        }
    }
}
