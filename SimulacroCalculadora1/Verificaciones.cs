using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroCalculadora1
{
    class Verificaciones
    {
        public static bool SetSeguirO()
        {
            do
            {
                Console.WriteLine("Desea seguir operando? (Y/N)");
                seguir = Console.ReadLine();


                if (seguir == "Y" || seguir == "y" || seguir == "yes" || seguir == "YES" || seguir == "Yes" || seguir == "YeS" || seguir == "yEs"
                    || seguir == "yES" || seguir == "yeS" || seguir == "SI" || seguir == "Si" || seguir == "sI" || seguir == "si" || seguir == "SÍ"
                    || seguir == "Sí" || seguir == "sÍ" || seguir == "sí" || seguir == "s" || seguir == "S")
                {
                    seguirO = true;
                    salame = false;
                }

                else if (seguir == "N" || seguir == "n" || seguir == "NO" || seguir == "No" || seguir == "nO" || seguir == "no")
                {
                    seguirO = false;
                    salame = false;
                }

                else
                {
                    Console.WriteLine("Sos un salame, literalmente puse todas las combinaciones de si y no y le pifiaste igual");
                    salame = true;
                }
            } while (salame == true);

            return seguirO;
        }


        public static bool SetNuevaO()
        {
            do
            {
                Console.WriteLine("¿Desea realizar una nueva operación? (Y/N)");
                string nuevaOperacion = Console.ReadLine();

                switch (nuevaOperacion)
                {
                    case "Y":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "y":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "yes":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "YES":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "Yes":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "YeS":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "yEs":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "yES":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "yeS":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "SI":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "Si":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "sI":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "si":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "SÍ":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "Sí":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "sÍ":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "sí":
                        nuevaO = true;
                        salame = false;
                        break;

                    case "N":
                        nuevaO = false;
                        salame = false;
                        break;

                    case "n":
                        nuevaO = false;
                        salame = false;
                        break;

                    case "NO":
                        nuevaO = false;
                        salame = false;
                        break;

                    case "No":
                        nuevaO = false;
                        salame = false;
                        break;

                    case "nO":
                        nuevaO = false;
                        salame = false;
                        break;

                    case "no":
                        nuevaO = false;
                        salame = false;
                        break;

                    default:
                        Console.WriteLine("Sos un salame, literalmente puse todas las combinaciones de si y no y le pifiaste igual");
                        salame = true;
                        break;
                }

            } while (salame == true);

            return nuevaO;
        }

        private static bool nuevaO;

        private static bool salame;

        private static bool seguirO;

        private static string seguir;
    }
}
