using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAMA_8_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int estado = 0;

            Console.WriteLine("INGRESA UN NUMERO...");
            numero = int.Parse(Console.ReadLine());



           PositivoNegativoCero(numero,ref estado);


            Console.WriteLine(numero + " " + estado );

            Console.ReadKey();
        }

        static void PositivoNegativoCero(int numero,ref int x)
        {
            if (numero > 0)
                x = 1;
            else
               if (numero < 0)
                Console.WriteLine(x = -1);
            else
               if (numero == 0)
                Console.WriteLine(x = 0);
        }


    }
}
