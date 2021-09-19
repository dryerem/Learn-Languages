using System;

namespace Reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of even digits in an array");
		
	    Console.Write("Input the size array: ");
	    int size = int.Parse(Console.ReadLine());

	    int[] array = new int[size];
	    for (int i = 0; i < size; i++)
	    {
		Console.Write("Array value [" + i + "]: ");
		array[i] = int.Parse(Console.ReadLine());
	    }

	    Console.Write("Array: ");
	    for (int i = 0; i < size; i++)
		Console.Write(array[i] + " ");
	    Console.WriteLine();

	    int min = array[0]; 
	    for (int i = 1; i < size; i++)
		if (array[i] < min)
		    min = array[i];
	    Console.WriteLine("Minimal value: " + min);
        }
    }
}
