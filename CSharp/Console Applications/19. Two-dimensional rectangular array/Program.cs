using System;

namespace Two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
	    /*
	     * To create a two-dimensional and over-dimensional array, you must adhere to the 
	     * following syntax. The comma in square brackets indicates the * dimension of 
	     * the array, one comma is a two-dimensional array, two commas are a 
	     * three-dimensional array, etc. The absence of a comma is a regular line array. 
	     *
	     * When initializing an array, we first specify the number of rows, then columns.
	     *
	     * Чтобы создать двумерный и более-мерный массив, необходимо придерживаться следующего 
	     * синтаксиса. Запятая в квадратных скобках указывает на *мерность массива, одна 
	     * запятая - это двумерный массив, две запятые - трехмерный массив и т.д. 
	     * Отсутствие запятой - обычный линейный массив.
	     *
	     * При инициализации массива, мы сначала указываем кол-во строк, затем столбцов.
	     */
            int[,] myArray = new int[4, 2]; // row, column

	    for (int row = 0; row < 4; row++)
	    {
		for (int column = 0; column < 2; column++)
		{
		    Console.Write($"row: {row}, column: {column} : ");
		    int val = int.Parse(Console.ReadLine());
		    myArray[row, column] = val;
		}			
	    }

	    Console.WriteLine("myArray: ");
	    /*
	     * The GetLength() method returns the length of the subarray, for 
	     * this it needs to specify the dimension (subarray) whose length 
	     * we want to get. 
	     * measurements are indicated from scratch.
	     *
	     * Метод массива GetLength() возвращает длину подмассива (кол-во элементов),
	     * для этого нужно указать измерение (подмассив), длину которого мы хотим получить.
	     * Нумерация измерений начинается с нуля.
	    */
	    for (int i = 0; i < myArray.GetLength(0); i++)
	    {
		for (int j = 0; j < myArray.GetLength(1); j++)
		{
		    Console.Write(myArray[i, j] + "\t");
		}
		Console.WriteLine();
	    }

	    /*
	     * Filling an array with random numbers.
	     * Заполнение массива случайными числами.
	     */
	    Console.WriteLine("myArray random filling: ");
	    Random rand = new Random();
	    for (int i = 0; i < myArray.GetLength(0); i++)
	    {
 		for (int j = 0; j < myArray.GetLength(1); j++)
		{
		    myArray[i, j] = rand.Next(0, 255);
		}
	    }

	    for (int i = 0; i < myArray.GetLength(0); i++)
	    {
	 	for (int j = 0; j < myArray.GetLength(1); j++)
		{
		    Console.Write(myArray[i, j] + "\t");
		}
		Console.WriteLine();
	    }
        }
    }
}
