using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_2_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
              
            
            double SUELDO_TOTAL;

            Console.WriteLine("INGRESA EL TOTAL FACTURADO");
            SUELDO_TOTAL = double.Parse(Console.ReadLine());
            SUELDO_TOTAL = (SUELDO_TOTAL * 0.5) + 15000;

            Console.WriteLine("EL SUELDO TOTAL QUE LE CORRESPONDE ES DE: " + " $" + SUELDO_TOTAL);

            Console.ReadKey();






        }
    }
}
