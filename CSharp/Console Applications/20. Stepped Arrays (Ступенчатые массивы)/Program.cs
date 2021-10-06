using System;

namespace Stepped_Arrays__Ступенчатые_массивы_
{
    class Program
    {
        static void Main(string[] args)
        {
	    /*A jagged array is a one-dimensional array that contains other 
	     * arrays that can be of arbitrary length.
	     * Зубчатый массив - это одномерный массив, который содержит в себе
	     * другие массивы, которые могут быть произвольной длины. 
	     */
            int[][] myArray = new int[3][];

	    myArray[0] = new int[2];
	    myArray[1] = new int[4];
	    myArray[2] = new int[8];
	
	    Random rand = new Random();
	    for (int i = 0; i < myArray[2].Length; i++)
	    {
 		myArray[2][i] = rand.Next(255);
	    }

	    int[] arr = myArray[2];
	    Console.Write("arr: ");
	    for (int i = 0; i < arr.Length; i++)
	    {
		Console.Write(arr[i] + " ");
	    }
	    Console.WriteLine();
        }
    }
}
