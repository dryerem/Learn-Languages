using System;

namespace Fill_array_from_the_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill array from the keyboard");
		
	    Console.Write("Input the size array: ");
	    int size = int.Parse(Console.ReadLine());

	    int[] array = new int[size];
	    for (int i = 0; i < size; i++)
	    {
		Console.Write("array value [" + i + "]: ");
		array[i] = int.Parse(Console.ReadLine());
	    }

	    Console.Write("Array: ");
	    for (int i = 0; i < size; i++)
		Console.Write(array[i] + " ");
	    Console.WriteLine();
        }
    }
}
