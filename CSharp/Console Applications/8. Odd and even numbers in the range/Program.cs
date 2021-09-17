using System;

namespace Odd_and_even_numbers_in_the_range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum and the count of even and odd numbers in 		the range");

	    int start;
	    Console.Write("Input start: ");
	    if (!int.TryParse(Console.ReadLine(), out start))
	    {
		Console.WriteLine("Incorrect number input, please, try again");
		Environment.Exit(1);
	    }

	    int stop;
	    Console.Write("Input stop: ");
	    if (!int.TryParse(Console.ReadLine(), out stop))
	    {
		Console.WriteLine("Incorrect number input, please, try again");
		Environment.Exit(1);
	    }

	    int countOfEven = 0;
	    int sumEven = 0;

	    int countOfOdd = 0;
	    int sumOdd = 0;

	    while (start <= stop)
	    {
		if (start % 2 == 0)
		{
		    sumEven += start;
		    countOfEven++;
		}
		else
		{
		    sumOdd += start;
		    countOfOdd++;
		}
		start++;
	    }

	    Console.WriteLine("Sum of even numbers: " + sumEven);
	    Console.WriteLine("Count of even numbers: " + countOfEven);
	    Console.WriteLine("Sum of odd numbers: " + sumOdd);
	    Console.WriteLine("Count of odd numbers: " + countOfOdd);
        }
    }
}
