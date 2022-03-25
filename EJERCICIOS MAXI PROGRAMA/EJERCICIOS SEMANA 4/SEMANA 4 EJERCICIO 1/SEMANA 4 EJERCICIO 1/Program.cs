using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2,RESTA,SUMA,PRODUCTO;

            Console.WriteLine("INGRESA EL PRIMER VALOR");
            NUM1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL SEGUNDO VALOR");
            NUM2 = int.Parse(Console.ReadLine());


            if (NUM1 > NUM2)
            {
                RESTA = NUM1 - NUM2;
                Console.WriteLine("EL RESULTADO DE LA SUSTRACCION ES " + RESTA );
            }
            else if (NUM1 == NUM2 )
            {
                SUMA = NUM1 + NUM2;

                Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + SUMA);

            }
            else if (NUM1 < NUM2)
            {
                PRODUCTO = NUM1 * NUM2;

                Console.WriteLine("EL RESULTADO DEL PRODUCTO ES: " + PRODUCTO);
            }



            Console.ReadKey();




                


        }
    }
}
