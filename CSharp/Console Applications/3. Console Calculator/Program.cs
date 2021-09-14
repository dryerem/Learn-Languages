using System;
using System.Globalization;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to simple console calculator!");

            double a;
            double b;
            Console.Write("Enter a first number: ");
            string firstNumber = Console.ReadLine();
            if (!double.TryParse(firstNumber, NumberStyles.AllowDecimalPoint, getSeparator(firstNumber), out a))
            {
                Console.WriteLine("Error! Uncorrect number!");
                Environment.Exit(1);
            }
            Console.Write("Enter a second number: ");
            string secondNumber = Console.ReadLine();
            if (!double.TryParse(secondNumber, NumberStyles.AllowDecimalPoint, getSeparator(secondNumber), out b))
            {
                Console.WriteLine("Error! Uncorrect number!");
                Environment.Exit(1);
            }
            Console.Write("Enter a sign: ");
            string sign = Console.ReadLine();
    
            Console.Write("Result: ");
            switch (sign)
            {
                case "+":
                    Console.Write(a + b);
                    break;
                case "-":
                    Console.Write(a - b);
                    break;
                case "*":
                    Console.Write(a * b);
                    break;
                case "/":
                    Console.Write(a / b);
                    break;
                default:
                    Console.WriteLine("Uncorrect sign!");
                    break;
            }
            Console.WriteLine("");
        }

        static NumberFormatInfo getSeparator(string input)
        {
            NumberFormatInfo format = new NumberFormatInfo();
            if (input.Contains(".")) {
                format.NumberDecimalSeparator = ".";
            }
            else {
                format.NumberDecimalSeparator = ",";
            }
            return format;
        }
    }
}
