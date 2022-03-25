using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_2_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float DISTANCIA = 0;
          
            float VELOCIDAD_PROMEDIO = 0;
            float TIEMPO_APROXIMADO = 0;


            Console.WriteLine("INGRESA LA DISTANCIA");
            DISTANCIA = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA LA VELOCIDAD PROMEDIO");
            VELOCIDAD_PROMEDIO = float.Parse(Console.ReadLine());
            TIEMPO_APROXIMADO = DISTANCIA / VELOCIDAD_PROMEDIO;
            Console.WriteLine("EL TIEMPO APROXIMADO SERA DE: "    + TIEMPO_APROXIMADO + " HS");

            Console.ReadLine();





           




        }
    }
}
