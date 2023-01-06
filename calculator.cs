using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            string continuar;
            string sair;
            string operators;
            do
            {
                Console.WriteLine("Escolha um operador. +, -, *, /,");
                operators = Console.ReadLine();
                Console.WriteLine("Digite um Numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro Numero");
                num2 = int.Parse(Console.ReadLine());

                switch (operators)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;

                }
                Console.WriteLine("{0} {1} {2} {3}", num1, operators, num2, result);

                Console.WriteLine("Deseja fazer outra operação? [n / s]");
                continuar = Console.ReadLine();
            } while ((continuar != "n"));

            continuar = Console.ReadLine();
            Console.ReadKey(true);

        }
    }
}
