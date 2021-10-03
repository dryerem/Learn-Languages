using System;

namespace Ternaty_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ternary operator");

	    bool access = false;
	    string password = "qwerty";
		
	    Console.WriteLine("[if-else]");
	    Console.Write("Input your password: ");
	    if (Console.ReadLine() == password)
	    	access = true;
	    Console.WriteLine("Access: " + access + "\n");

	    Console.WriteLine("[Ternary operator]");
	    Console.Write("Input your password: ");
	    bool ternary_access = Console.ReadLine() == password ? true : false;
	    Console.WriteLine("Access: " + ternary_access);
        }
    }
}
