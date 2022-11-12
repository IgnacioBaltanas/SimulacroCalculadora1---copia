using System;
using System.Net;
using System.Net.Http.Headers;

//^ = alt+94

namespace SimulacroCalculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                primerNum = PonerNumeros.SetPrimNum();


                Console.WriteLine("Qué operación desea realizar? (raíz = r)");
                ecuacion = Console.ReadLine();

                segundoNum = PonerNumeros.SetOtroNum();

                Ecuaciones.GetPrimerResultado();
                
                seguirO = Verificaciones.SetSeguirO();


                if (seguirO == true)
                {
                    do
                    {
                        Console.WriteLine("¿Qué operación desea realizar?");
                        ecuacion = Console.ReadLine();

                        tercerNum = PonerNumeros.SetOtroNum();

                        Ecuaciones.GetSegundoResultado();

                        seguirO = Verificaciones.SetSeguirO();

                    } while (seguirO == true);

                }

                nuevaO = Verificaciones.SetNuevaO();

            } while (nuevaO == true);

            Console.WriteLine("El programa ha finalizado, ¡hasta pronto!");

        }


        public static string ecuacion;

        public static double primerNum;

        public static double segundoNum;

        public static double tercerNum;

        private static bool nuevaO;

        private static bool seguirO;
    }
}