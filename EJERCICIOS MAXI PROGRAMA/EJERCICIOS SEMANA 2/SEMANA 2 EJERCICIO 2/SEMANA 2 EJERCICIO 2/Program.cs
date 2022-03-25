using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_2_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;

            Console.WriteLine("INGRESA UN NUMERO");
            NUM = int.Parse(Console.ReadLine());
            NUM = NUM * NUM * NUM ;

            Console.WriteLine("EL RESULTADO DEL NUMERO ELEVADO AL CUBO ES: " +  NUM);

            Console.ReadLine();



        }
    }
}
