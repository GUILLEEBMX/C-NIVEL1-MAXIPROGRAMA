using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;

            int ACUMULADOR = 0;
            int PROMEDIO = 0;


            int[] VECTOR = new int[10];
            int[] VECTOR_2 = new int[10];

      



            Console.WriteLine("INGRESA NUMEROS");

            for (int i = 0; i < 10; i++)
            {
                NUM = int.Parse(Console.ReadLine());

                VECTOR[i] = NUM;
            }

            for (int i = 0; i < 10; i++)
            {



                ACUMULADOR = ACUMULADOR + VECTOR[i];
            }

            PROMEDIO = ACUMULADOR / 10;

            for (int i = 0; i < 10; i++)
            {
                if (VECTOR[i] > PROMEDIO)
                    VECTOR_2[i] = VECTOR [i];
            }
           




            Console.WriteLine("EL PROMEDIO DEL VECTOR ES DE: " + PROMEDIO + " % ");


            Console.WriteLine("LOS NÚMEROS MAYORES AL PROMEDIO SON: ");

            for (int i = 0; i < 10; i++)
            {
                if (VECTOR_2 [i] != 0)
                {
                    Console.WriteLine(VECTOR_2[i]);
                }
            }



            

            Console.ReadKey();





        }
    }
}
