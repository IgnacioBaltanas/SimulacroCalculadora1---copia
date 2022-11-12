using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroCalculadora1
{
    class PonerNumeros
    {
        public static double SetPrimNum()
        { 

            do
            {
                try
                {
                    Console.WriteLine("Introduzca un número");
                    numero = double.Parse(Console.ReadLine());
                    salame = false;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Poné un número, no seas salame");
                    salame = true;
                }
                catch (OverflowException ofe)
                {
                    Console.WriteLine("Te pasaste con ese número, probá otra vez");
                    salame = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    salame = true;
                }

            } while (salame == true);
            
            return numero;
        }


        public static double SetOtroNum()
        {
            do
            {
                try
                {
                    Console.WriteLine("Introduzca otro número para realizar su ecuación");
                    otroNum = double.Parse(Console.ReadLine());
                    salame = false;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Poné un número, no seas salame");
                    salame = true;
                }
                catch (OverflowException ofe)
                {
                    Console.WriteLine("Te pasaste con ese número, probá otra vez");
                    salame = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    salame = true;
                }
            } while (salame == true);

            return otroNum;
        }

        private static bool salame;

        private static double numero;

        private static double otroNum;
    }
}