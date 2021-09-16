using System;

namespace Check_for_an_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check for an even number program");

	    int number;
	    Console.Write("Please, enter the number: ");
	    if (!int.TryParse(Console.ReadLine(), out number))
	    {
		Console.WriteLine("Error! Uncorrect input number");
		Environment.Exit(1);
	    }

	    if (number % 2 == 0)
	    {
		Console.WriteLine("This number is even!");
	    }
	    else 
	    {
		Console.WriteLine("This number not even!");
	    }
        }
    }
}
