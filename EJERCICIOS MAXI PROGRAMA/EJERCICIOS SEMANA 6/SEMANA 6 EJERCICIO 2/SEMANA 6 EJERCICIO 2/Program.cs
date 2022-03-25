using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_6_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {



            int NUM = 0;
            int PORCENTAJE = 0;
            int MAYOR = 0;
            int GMAX = 0;
            int MIN = 0;
            bool BANDERA_ORDENADOS;
            int CONTADOR_ORDENADOS = 0;



            for (int i = 0; i < 5; i++)
            {
                

                int CONT_IMPARES = 0;
                int CONTADOR_TOTAL = 0;
                BANDERA_ORDENADOS = true;

                Console.WriteLine("INGRESA UN NUMERO DISTINTO DE CERO PARA INICIAR...");
                NUM = int.Parse(Console.ReadLine());
                MIN = NUM;


                while (NUM != 0)
                {
                    //Console.WriteLine("INGRESA UN NUMERO");

                    CONTADOR_TOTAL++;

                    if (NUM % 2 != 0)
                        CONT_IMPARES++;


                    if (NUM <= MIN)
                        MIN = NUM;
                    else
                        BANDERA_ORDENADOS = false;


                    NUM = int.Parse(Console.ReadLine());





                }


                PORCENTAJE = (CONT_IMPARES * 100) / CONTADOR_TOTAL;
                Console.WriteLine("EL PORCENTAJE DE NUMEROS IMPARES DEL GRUPO ES: " + PORCENTAJE + " % ");

                if (PORCENTAJE > MAYOR)
                {
                    MAYOR = PORCENTAJE;
                    GMAX = i + 1;
                }



                if (BANDERA_ORDENADOS == true)
                    CONTADOR_ORDENADOS++;

            }





            Console.WriteLine("EL GRUPO CON MAYOR PORCENTAJE DE NUMEROS IMPARES ES EL NUMERO:  " + GMAX);
            Console.WriteLine("LA CANTIDAD DE GRUPOS ORDENADOS ES: " + CONTADOR_ORDENADOS );








            Console.ReadKey();






        }
    }
}
