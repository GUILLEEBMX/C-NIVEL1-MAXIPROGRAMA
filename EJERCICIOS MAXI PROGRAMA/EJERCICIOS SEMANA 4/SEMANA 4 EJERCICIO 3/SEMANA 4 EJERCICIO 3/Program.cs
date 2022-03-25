using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int PROCESADORES = 0;
            int RAM = 0;
            int HDD = 0;
            int TOTAL;
            Console.WriteLine("ELEGI EL PROCESADOR QUE DESEAS:");

            Console.WriteLine("OPCION 1: CORE I5 , OPCION 2: CORE I7 , OPCION 3: CORE I9 ");

            PROCESADORES = int.Parse(Console.ReadLine());

            switch (PROCESADORES)
            {

                case 1:

                    Console.WriteLine("ELEGI  LA CANTIDAD DE MEMORIA RAM");
                    Console.WriteLine("OPCION 1: 8GB, OPCION 2: 16 GB, OPCION 3: 32GB ");

                    RAM = int.Parse(Console.ReadLine());

                    switch (RAM)
                    {
                        case 1:

                            Console.WriteLine("ELEGISTE EL PROCESAODR I5 CON 8GB DE RAM, ESTO TIENE UN VALOR DE $800 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 800 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $800 USD"); }

                            }




                            break;


                        case 2:
                            Console.WriteLine("ELEGISTE EL PROCESADOR I5 CON 16GB DE RAM, ESTO TIENE UN VALOR DE $900 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 900 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $900 USD"); }

                            }




                            break;

                        case 3:

                            Console.WriteLine("ELEGISTE EL PROCESADOR I5 CON 32GB DE RAM, ESTO TIENE UN VALOR DE $1000 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 1000 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $1000 USD"); }

                            }







                            break;
                    }



                    break;

                case 2:




                    Console.WriteLine("ELEGI  LA CANTIDAD DE MEMORIA RAM");
                    Console.WriteLine("OPCION 1: 8GB, OPCION 2: 16 GB, OPCION 3: 32GB ");

                    RAM = int.Parse(Console.ReadLine());

                    switch (RAM)
                    {
                        case 1:

                            Console.WriteLine("ELEGISTE EL PROCESAODR I7 CON 8GB DE RAM, ESTO TIENE UN VALOR DE $900 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 900 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $900 USD"); }

                            }




                            break;


                        case 2:
                            Console.WriteLine("ELEGISTE EL PROCESADOR I7 CON 16GB DE RAM, ESTO TIENE UN VALOR DE $1000 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 1000 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $1000 USD"); }

                            }




                            break;

                        case 3:

                            Console.WriteLine("ELEGISTE EL PROCESADOR I7 CON 32GB DE RAM, ESTO TIENE UN VALOR DE $1400 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 1400 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $1400 USD"); }

                            }







                            break;
                    }


                    break;

                case 3:


                    Console.WriteLine("ELEGI  LA CANTIDAD DE MEMORIA RAM");
                    Console.WriteLine("OPCION 1: 8GB, OPCION 2: 16 GB, OPCION 3: 32GB ");

                    RAM = int.Parse(Console.ReadLine());

                    switch (RAM)
                    {
                        case 1:

                            Console.WriteLine("ELEGISTE EL PROCESAODR I9 CON 8GB DE RAM, ESTO TIENE UN VALOR DE $1200 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 1200 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $1200 USD"); }

                            }




                            break;


                        case 2:
                            Console.WriteLine("ELEGISTE EL PROCESADOR I9 CON 16GB DE RAM, ESTO TIENE UN VALOR DE $1400 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 1400 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $1400 USD"); }

                            }




                            break;

                        case 3:

                            Console.WriteLine("ELEGISTE EL PROCESADOR I9 CON 32GB DE RAM, ESTO TIENE UN VALOR DE $2000 USD");

                            Console.WriteLine("¿DESEA EXPANDIR EL HDD A 1TB?");

                            Console.WriteLine("INGRESE 1 PARA EXPANDIR, 0 PARA NO HACERLO");

                            HDD = int.Parse(Console.ReadLine());

                            {

                                if (HDD == 1)
                                {
                                    TOTAL = 2000 + 300;

                                    Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $" + TOTAL + " USD");

                                }

                                else { Console.WriteLine("EL TOTAL DE LA COMPRA SERA DE $2000 USD"); }

                            }







                            break;
                    }




                    break;


            }


            Console.ReadKey();






        }
    }
}
