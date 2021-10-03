using System;

namespace Draw_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Draw triangles");
		
	    int height;
	    Console.Write("Input the height of the triangles: ");
	    if (!int.TryParse(Console.ReadLine(), out height))
	    {
		Console.WriteLine("Error! Incorrect input number, please, try again");
		Environment.Exit(1);
	    }

	    /* Bottom right triangle */
	    for (int col = 0; col < height; col++)
	    {
		for (int row = 0; row < col; row++)
		    Console.Write("*");
		Console.WriteLine("*");
	    }

	    Console.WriteLine("");

	    /* Bottom left triangle */
	    for (int col = height; col >= 1; col--)
	    {
		for (int row = 1; row < height; row++)
		{
		    if (row >= col || col == 1)
			Console.Write("*");
		    else Console.Write(" ");
		}
		Console.WriteLine("*");
	    }

	    Console.WriteLine("");

	    /* Top left triangle */
	    for (int col = height; col >= 1; col--)
	    {
		for (int row = 1; row < col; row++)
		    Console.Write("*");
		Console.WriteLine("*");
	    }

	    Console.WriteLine("");

	    /* Top right triangle */
	    for (int col = 0; col < height; col++)
	    {
		for (int row = 1; row < height; row++)
		{
		    if (row > col)
			Console.Write("*");
		    else Console.Write(" ");
		}
		Console.WriteLine("*");
	    }
        }
    }
}
