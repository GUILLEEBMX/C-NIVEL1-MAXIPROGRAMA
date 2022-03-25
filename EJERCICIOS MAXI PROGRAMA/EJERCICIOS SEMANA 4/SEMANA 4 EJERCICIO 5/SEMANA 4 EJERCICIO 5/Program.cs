using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3, NUM4;

            Console.WriteLine("INGRESA EL PRIMER VALOR");
            NUM1 = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA EL PRIMER VALOR");
            NUM2 = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA EL PRIMER VALOR");
            NUM3 = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA EL PRIMER VALOR");
            NUM4 = int.Parse(Console.ReadLine());


            if (NUM2 < NUM1 && NUM3 < NUM2 && NUM4 < NUM3)
                Console.WriteLine("LOS NUMEROS ESTAN EN FORMA DECRECIENTE");
            else Console.WriteLine("LOS NUMEROS NO ESTAN EN FORMA DECRECIENTE");

            Console.ReadKey();



        }
    }
}
