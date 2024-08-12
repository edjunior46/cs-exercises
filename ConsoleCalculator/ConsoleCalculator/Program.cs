using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {

        static int calcA;
        static int calcB;
        static char operation;
        static int result;

        static void Main(string[] args)
        {

            Console.WriteLine("Calculator\nEnter the value for A, then B, and select the operation from:\n+. Addition\n-. Subtraction\n*. Multiplication\n/. Division");

            ReadValues();

            ReadOperation();

            WriteOperation();
        }

        private static void WriteOperation()
        {
            Console.WriteLine("\n" + calcA + " " + operation + " " + calcB + "\nResult: " + result);
        }

        private static void ReadValues()
        {
            try
            {
                Console.WriteLine("\nEnter A value:");
                calcA = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter B value:");
                calcB = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid value! Retype two numeric values.");
                ReadValues();
            }
        }

        private static void ReadOperation()
        {
            Console.WriteLine("\nEnter the symbol of the arithmetic operation: ");
            operation = Console.ReadLine()[0];

            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("\nInvalid operation!\nSelect an operation from:\n+. Addition\n-. Subtraction\n*. Multiplication\n/. Division\n");
                ReadOperation();
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        result = calcA + calcB;
                        break;
                    case '-':
                        result = calcA - calcB;
                        break;
                    case '*':
                        result = calcA * calcB;
                        break;
                    case '/':
                        result = calcA / calcB;
                        break;
                }
            }

        }
    }
}
