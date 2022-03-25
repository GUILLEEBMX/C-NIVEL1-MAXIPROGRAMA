using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_2_EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double NOTA1 = 0, NOTA2 = 0, NOTA3 = 0, PROMEDIO_FINAL =0;

            Console.WriteLine("INGRESA LA NOTA NUMERO 1");
            NOTA1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA LA NOTA NUMERO 2");
            NOTA2 = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA LA NOTA NUMERO 3");
            NOTA3 = double.Parse(Console.ReadLine());

            PROMEDIO_FINAL = (NOTA1 + NOTA2 + NOTA3) / 3;

            Console.WriteLine("EL PROMEDIO FINAL DE LAS 3 NOTAS SERA DE: " + PROMEDIO_FINAL);

            Console.ReadKey();



            




        }
    }
}
