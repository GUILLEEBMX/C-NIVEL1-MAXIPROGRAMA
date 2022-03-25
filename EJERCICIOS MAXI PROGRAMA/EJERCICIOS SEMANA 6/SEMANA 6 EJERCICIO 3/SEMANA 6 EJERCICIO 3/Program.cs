using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_6_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 1;
            int CONTADOR = 0;


            Console.WriteLine("INGRESA UN NUMERO MAYOR QUE CERO...");

            NUM = int.Parse(Console.ReadLine());



            while (NUM >= 0)
            {
                CONTADOR = 0;



           


                while (NUM > 0 )
                {
                    CONTADOR++;







                    NUM = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("EL TOTAL DE NUMEROS DE ESTA LISTA ES DE: " + CONTADOR);


                //Console.WriteLine("INGRESA UN NUMERO POSITIVO PARA CONTINUAR...");

                NUM = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("FIN DE LA CARGA NUMERO NEGATIVO...");


            Console.ReadKey();

        }
    }
}
