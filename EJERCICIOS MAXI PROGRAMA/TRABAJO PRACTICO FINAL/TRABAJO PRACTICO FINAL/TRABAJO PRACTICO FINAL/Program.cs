using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_PRACTICO_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int contador_pares = 0;
            int contador_impares = 0;
            int mayor_pares = 0;
            int x = 0;

            


            Console.WriteLine("INGRESA NÚMEROS DISTINTOS DE CERO...");
            num = int.Parse(Console.ReadLine());
           

            while (num != 0)
            {

                if (num % 2 == 0)

            {
                contador_pares++;
                if (contador_pares == 1)
                    mayor_pares = num;
                if (num > mayor_pares)
                    mayor_pares = num;
            }

            else
                  if (num % 2 != 0)
            {
                contador_impares++;
            }

                x = MenorPrimos(num);
                Console.WriteLine("EL NUMERO ES PRIMO: " + MenorPrimos2(num));

                num = int.Parse(Console.ReadLine());


        }
            Console.WriteLine("EL MAYOR DE LOS NUMEROS PARES ES: " + mayor_pares);
            Console.WriteLine("LA CANTIDAD DE NUMEROS IMPARES SON: " + contador_impares);
            Console.WriteLine("EL MENOR DE LOS NUMEROS PRIMOS ES: " + x);


            Console.ReadKey();

        }

        static int MenorPrimos(int num)
        {
            int menor_primos = 2;
            int contador_primos = 0;


            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    contador_primos++;
            }

            

            if (contador_primos == 2 && num < menor_primos)
                menor_primos = num;

            return menor_primos;
        }

        static bool MenorPrimos2 (int num)

        {
            int contador_primos = 0;
       

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    contador_primos++;
            }

            if (contador_primos == 2)
                return true;
            else
                return false;
        }


        


    }

      

    }

