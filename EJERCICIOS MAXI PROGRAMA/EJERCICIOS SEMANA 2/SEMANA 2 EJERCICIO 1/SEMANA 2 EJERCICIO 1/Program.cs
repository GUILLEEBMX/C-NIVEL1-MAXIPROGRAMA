using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_2_EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1 = 0;
            int NUM2 = 0;
            int RESULTADO = 0;


            Console.WriteLine("INGRESA UN NUMERO");
            NUM1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA OTRO NUMERO");
            NUM2 = int.Parse(Console.ReadLine());

            RESULTADO = NUM1 + NUM2;


            Console.WriteLine("EL RESULTADOD DE LA OPERACION ES: " + RESULTADO);

            Console.ReadLine();




        }
    }
}
