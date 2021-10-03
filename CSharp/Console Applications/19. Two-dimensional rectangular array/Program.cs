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
	    /*
	     * The GetLength property returns the length of the subarray, for 
	     * this it needs to specify the dimension (subarray) whose length 
	     * we want to get. 
	     * measurements are indicated from scratch.
	    */
	    for (int i = 0; i < myArray.GetLength(0); i++)
	    {
		for (int j = 0; j < myArray.GetLength(1); j++)
		{
		    Console.Write(myArray[i, j] + "\t");
		}
		Console.WriteLine();
	    }
        }
    }
}
