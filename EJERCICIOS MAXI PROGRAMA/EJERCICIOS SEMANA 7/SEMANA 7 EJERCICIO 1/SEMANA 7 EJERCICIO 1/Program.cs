using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;
            int [] VECTOR = new int [10];
            int CONTADOR = 0;
            int MAYOR = 0;
            int POSICION = 0;


            Console.WriteLine("INGRESA NUMEROS");

            for (int i = 0; i < 10; i++)
            {

                NUM = int.Parse(Console.ReadLine());
                VECTOR[i] = NUM;

            }


           


            Console.WriteLine("LOS ELEMENTOS INTERNOS DEL VECTOR SON: ");


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(VECTOR[i]);
                CONTADOR++;


                if (CONTADOR == 1)
                    MAYOR = VECTOR [0];

                if (VECTOR[i] > MAYOR)
                {
                    MAYOR = VECTOR[i];
                    POSICION = i + 1;
                }



            }



            Console.WriteLine("EL VALOR MÁXIMO DENTRO DEL VECTOR ES:" + MAYOR);
            Console.WriteLine("LA POSICION DEL VALOR MÁXIMO DENTRO DEL VECTOR ES LA POSICION: " + POSICION);






            Console.ReadKey();






        }
    }
}
