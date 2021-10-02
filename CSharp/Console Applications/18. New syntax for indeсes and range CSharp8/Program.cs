using System;

namespace New_syntax_for_indeсes_and_range_CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test_array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		
			Console.Write("[test_array]: ");
			for (int i = 0; i < test_array.Length; i++)
			{
			Console.Write($"{test_array[i]} ");
			}
			Console.WriteLine($"\n[Last element]: {test_array[^1]}");

			Console.Write("[range between 5 and last]: ");
			int[] range_array = test_array[4..];
			for (int i = 0; i < range_array.Length; i++)
				Console.Write($"{range_array[i]} ");
			Console.WriteLine();

			Index myIndex = ^4; // isFromEnd = True - take the element from the end 
			Console.WriteLine($"[end] isFromEnd={myIndex.IsFromEnd}, {test_array[myIndex]}"); 

			myIndex = 4; // isFromEnd = False - take the element at the beginning
			Console.WriteLine($"[begin] isFromEnd={myIndex.IsFromEnd}, {test_array[myIndex]}");

			myIndex = new Index(2, true); // isFromEnd = True - take the element from the end 
			Console.WriteLine($"[end] isFromEnd={myIndex.IsFromEnd}, {test_array[myIndex]}"); 
			
			Range myRange = new Range(2, 5); // 2..5
			int [] myArray = test_array[myRange];

			Console.Write("[range 2..5] - ");
			for (int i = 0; i < myArray.Length; i++)
				Console.Write($"{myArray[i]} ");
			Console.WriteLine();

			myRange = ^5..^1;
			myArray = test_array[myRange];
			Console.Write("[range ^5..^1] - ");
			for (int i = 0; i < myArray.Length; i++)
				Console.Write($"{myArray[i]} ");
			Console.WriteLine();

			string mySring = "Hello, Jame!";
			Console.WriteLine("[name] - " + mySring[^5..^1]);
		}
    }
}
