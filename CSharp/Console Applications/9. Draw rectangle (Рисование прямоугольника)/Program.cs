using System;

namespace Draw_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Draw triangle");

	    int height;
	    Console.Write("Input the height of the rectangle: ");
	    if (!int.TryParse(Console.ReadLine(), out height))
	    {
		Console.WriteLine("Incorrect input number, please, try again");
		Environment.Exit(1);
	    }

	    int width;
	    Console.Write("Input the width of the rectangle: ");
	    if (!int.TryParse(Console.ReadLine(), out width))
	    {
		Console.WriteLine("Incorrect input number, please, try again");
		Environment.Exit(1);
	    }

	    for (int recHeight = 0; recHeight < height; recHeight++)
	    {
		for (int recWidth = 0; recWidth < width; recWidth++)
		{
		    Console.Write("#");
		}
		Console.WriteLine("#");
	    }
        }
    }
}
