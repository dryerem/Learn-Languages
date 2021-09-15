using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the average of two numbers");

            Console.Write("Input the first number: ");
            double a;
            string firstNumber = Console.ReadLine();
            if (!double.TryParse(firstNumber, out a))
            {
                Console.WriteLine("Error! Please try again");
                Environment.Exit(1);
            }
            
            Console.Write("Input the second number: ");
            double b;
            string secondNumber = Console.ReadLine();
            if (!double.TryParse(secondNumber, out b))
            {
                Console.WriteLine("Error! Please try again");
                Environment.Exit(1);
            }

            double result = (a + b) / 2.0;
            Console.WriteLine("Result: " + result);
        }
    }
}
