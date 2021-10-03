using System;
using System.Linq;

namespace Array_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine($"Max element in array: {Array.Max()}");
            Console.WriteLine($"Min element in array: {Array.Min()}");
            Console.WriteLine($"Sum of array: {Array.Sum()}");
        }
    }
}
