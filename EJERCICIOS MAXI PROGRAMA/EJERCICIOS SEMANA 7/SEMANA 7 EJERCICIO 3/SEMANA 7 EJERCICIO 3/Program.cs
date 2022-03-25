using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            Char LETRA1;
            Char LETRA2;

            Console.WriteLine("INGRESA UNA CADENA...");

            A = Console.ReadLine();

            Console.WriteLine("INGRESA UN CARACTER...");

            LETRA1 = char.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA OTRO CARACTER...");

            LETRA2 = char.Parse(Console.ReadLine());


          A =  A.Replace(LETRA1, LETRA2);

            Console.WriteLine(A);

            Console.ReadKey();

        }
    }
}
