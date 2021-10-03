using System;

namespace Two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[4, 2]; // row, column

	    for (int row = 0; row < 4; row++)
	    {
		for (int column = 0; column < 2; column++)
		{
		    Console.Write($"row: {row}, column: {column} : ");
		    int val = int.Parse(Console.ReadLine());
		    myArray[row, column] = val;
		}			
	    }

	    Console.WriteLine("myArray: ");
	    for (int row = 0; row < 4; row++)
	    {
		for (int column = 0; column < 2; column++)
		{
		    Console.Write(myArray[row, column] + "\t");
		}
		Console.WriteLine();
	    }
        }
    }
}
