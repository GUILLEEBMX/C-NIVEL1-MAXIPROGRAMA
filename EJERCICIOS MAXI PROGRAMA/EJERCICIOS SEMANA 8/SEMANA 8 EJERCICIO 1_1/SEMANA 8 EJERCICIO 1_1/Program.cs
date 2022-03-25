using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_8_EJERCICIO_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double PRECIO = 20;
            int CANTIDAD = 0;

            PEDIRDATOS(ref PRECIO, ref CANTIDAD);


            Console.WriteLine("EL TOTAL POR LOS ARTICULOS COMPRADOS ES DE: " + "$ " +  TOTAL(ref PRECIO, ref CANTIDAD) );

            

            Console.ReadKey();

        }

        static void PEDIRDATOS(ref double PRECIO, ref int CANTIDAD)
        {
            Console.WriteLine("INGRESA EL PRECIO DE UN ARTICULO...");
            PRECIO = double.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA LA CANTIDAD VENDIDAD...");
            CANTIDAD = int.Parse(Console.ReadLine());

            
        }

        static double TOTAL( ref double PRECIO, ref int CANTIDAD)
        {


            double RESULTADO = PRECIO * CANTIDAD;

            return RESULTADO;

        }


    }
}
