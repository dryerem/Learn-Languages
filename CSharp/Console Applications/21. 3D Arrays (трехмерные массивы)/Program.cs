using System;

namespace Arrays__трехмерные_массивы_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[4, 3, 5];

	    	Random rand = new Random();
			int x, y, z;
	    	for (x = 0; x < 4; x++)
	    	{
				for (y = 0; y < 3; y++)
				{
		    		for (z = 0; z < 5; z++)
		    		{
						myArray[x, y, z] = rand.Next(255);
		    		}
				}
	    	}

	    	for (x = 0; x < 4; x++)
	    	{
				for (y = 0; y < 3; y++)
				{
		    		for (z = 0; z < 5; z++)
		    		{
						Console.WriteLine($"{{x: {x}, y: {y}, z: {z}}} - {myArray[x, y, z]}");
		    		}
				}
				Console.WriteLine();
	    	}
        }
    }
}
