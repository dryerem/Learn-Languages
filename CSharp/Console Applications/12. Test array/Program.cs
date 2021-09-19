using System;

namespace Test_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test array");
		
	    // create array
	    int[] array = new int[5];

	    array[1] = 3;
	    array[4] = 5;
	
	    /* index out of range
	    array[5] = 1;
	    array[-1] = 5;
	    */

	    Console.WriteLine("Array[1] = " + array[1]);
	    Console.WriteLine("Array[4] = " + array[4]);
        }
    }
}
