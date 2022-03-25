using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3,SUMA,PRODUCTO;

            Console.WriteLine("INGRESA EL PRIMER NUMERO");
            NUM1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL SEGUNDO NUMERO");
            NUM2 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL TERCER NUMERO");
            NUM3 = int.Parse(Console.ReadLine());

            SUMA = NUM1 + NUM2;

            PRODUCTO = NUM2 * NUM3;


            if (SUMA > PRODUCTO)
                Console.WriteLine("LA SUMA DEL 1ERO MAS EL 2DO ES MAYOR QUE EL PRODUCTO DEL 2DO POR EL 3RO");
            else Console.WriteLine("LO CONTRARIO XD");

            Console.ReadKey();








        }
    }
}
