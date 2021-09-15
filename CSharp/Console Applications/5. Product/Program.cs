using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This program outputs the sum and product a three numbers");

            double a;
            Console.Write("Input a first number: ");
            string fisrtNumber = Console.ReadLine();
            if (!double.TryParse(fisrtNumber, out a))
            {
                Console.WriteLine("Error! Please, try again");
                Environment.Exit(1);
            }

            double b;
            Console.Write("Input a second number: ");
            string secondNumber = Console.ReadLine();
            if (!double.TryParse(secondNumber, out b))
            {
                Console.WriteLine("Error! Please, try again");
                Environment.Exit(1);
            }

            double c;
            Console.Write("Input a third number: ");
            string thirdNumber = Console.ReadLine();
            if (!double.TryParse(thirdNumber, out c))
            {
                Console.WriteLine("Error! Please, try again");
                Environment.Exit(1);
            }

            double sum = a + b + c;
            double product = a * b * c;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
    }
}
