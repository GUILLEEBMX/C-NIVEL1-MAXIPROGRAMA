using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ARTICULO = 0;
            int CANTIDAD = 0;
            int MAYOR = 0; 
            int[] VECTOR_ARTICULOS = new int [15];
            int POSICION = 0;
            int [] VECTOR_NO_VENDIDOS = new int [15];
            int CONTADOR = 0;
            int POSICION_NO_VENDIDOS = 0;
  

        

            for (int i = 0; i < 15; i++)
            {
                VECTOR_ARTICULOS [i] = 0;
               
            

            }








            Console.WriteLine("INGRESA EL NUMERO DE ARTÍCULO...");
            ARTICULO = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA LA CANTIDAD VENDIDA...");
            CANTIDAD = int.Parse(Console.ReadLine());

            if (ARTICULO == 10)
                CONTADOR++;


            while (ARTICULO != 0  )
            {
                VECTOR_ARTICULOS[ARTICULO -1 ] += CANTIDAD;



                Console.WriteLine("INGRESA EL NUMERO DE ARTÍCULO...");
                ARTICULO = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESA LA CANTIDAD VENDIDA...");
                CANTIDAD = int.Parse(Console.ReadLine());
              
            }


            CONTADOR = 0;

            for (int i = 0; i < 15; i++)
            {

                if (VECTOR_ARTICULOS[i] >= 0)
                    CONTADOR++;

                if (CONTADOR == 1)
                    MAYOR = VECTOR_ARTICULOS[i];


                if (VECTOR_ARTICULOS[i] >= MAYOR)
                {
                    MAYOR = VECTOR_ARTICULOS[i];
                    POSICION = i + 1;
                }


         
            }

            for (int i = 0; i < 15; i++)
            {
                if (VECTOR_ARTICULOS[i] == 0)
                {
                   POSICION_NO_VENDIDOS = i + 1;
                   VECTOR_NO_VENDIDOS[i] = POSICION_NO_VENDIDOS;
                }

                if (VECTOR_NO_VENDIDOS[i] != 0)
                    Console.WriteLine("LOS ARTICULOS DE LOS QUE NO SE VENDIO NADA SON: " + VECTOR_NO_VENDIDOS[i]);
            }
            


            Console.WriteLine("EL NUMERO DE ARTICULO QUE MAS SE VENDIO EN TOTAL FUE EL: " + POSICION);
            Console.WriteLine("DEL ARTICULO 10 SE VENDIERON: " + VECTOR_ARTICULOS[9] + " UNIDADES");
            









            Console.ReadKey();




        }
    }
}
