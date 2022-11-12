using System;
using System.Collections.Generic;
using System.Text;

namespace SimulacroCalculadora1
{
    //TODO agregar % (alt+37)
    class Ecuaciones
    {
        public static void GetPrimerResultado()
        {
            do
            {
                switch (Program.ecuacion)
                {
                    case "+":
                        resultado = Program.primerNum + Program.segundoNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "-":
                        resultado = Program.primerNum - Program.segundoNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "*":
                        resultado = Program.primerNum * Program.segundoNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "/":
                        resultado = Program.primerNum / Program.segundoNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "^":
                        resultado = Math.Pow(Program.primerNum, Program.segundoNum);
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "r":
                        resultado = Math.Pow(Program.primerNum, (Math.Pow(Program.segundoNum, -1)));
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "%":
                        resultado = (Program.segundoNum / 100) * Program.primerNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    default:
                        Console.WriteLine("Poné bien el símbolo de operación, salamín (son +,-,*,/,^,% y r (raíz), no es tan dificil)");
                        Program.ecuacion = Console.ReadLine();
                        break;
                }

            } while (bien == false);

        }


        public static void GetSegundoResultado()
        {
            do
            {
                switch (Program.ecuacion)
                {
                    case "+":
                        resultado = ans + Program.tercerNum;
                        Console.WriteLine("El resultado de su ecuación es " + (resultado));
                        bien = true;
                        ans = resultado;
                        break;

                    case "-":
                        resultado = ans - Program.tercerNum;
                        Console.WriteLine("El resultado de su ecuación es " + (resultado));
                        bien = true;
                        ans = resultado;
                        break;

                    case "*":
                        resultado = ans * Program.tercerNum;
                        Console.WriteLine("El resultado de su ecuación es " + (resultado));
                        bien = true;
                        ans = resultado;
                        break;

                    case "/":
                        resultado = ans / Program.tercerNum;
                        Console.WriteLine("El resultado de su ecuación es " + (resultado));
                        bien = true;
                        ans = resultado;
                        break;

                    case "^":
                        resultado = Math.Pow(resultado, Program.tercerNum);
                        Console.WriteLine("El resultado de tu ecuación: " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "r":
                        resultado = Math.Pow(ans, (Math.Pow(Program.tercerNum, -1)));
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    case "%":
                        resultado = (ans / 100) * Program.tercerNum;
                        Console.WriteLine("El resultado de su ecuación es " + resultado);
                        bien = true;
                        ans = resultado;
                        break;

                    default:
                        Console.WriteLine("Poné bien el símbolo de operación salamín (son +,-,*,/,^,% y r (raíz), no es tan dificil)");
                        Program.ecuacion = Console.ReadLine();
                        break;
                }

            } while (bien == false);

        }


        private static bool bien;

        private static double resultado;

        private static double ans;
    }
}
