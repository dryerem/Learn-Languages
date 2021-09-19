using System;
using System.Linq;

namespace Test_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test array");

	    /* Общий принцип создания массива
	     *
	     * тип_данных имя = new тип_данных[кол-во элементов];
	     * int[] array = new int[5];
	     */
		
	    // будет инициализирован нулями
	    int[] array_a = new int[5];

	    // Будет инициализирован числами - 0, 1, 2, 3, 4
	    int[] array_b = new int[5] {0, 1, 2, 3, 4}; 
	
	    /* получим ошибку на этапе компиляции, 
	     * так как при таком способе инициализации нужно указывать
	     * точное количество элементов, равное длине массива
	     * 
	     * int[] array = new int[5] {0, 1, 2}; 
	     */
	    
	    /* динамический способ инициализации массива,
	     * при таком способе не требуется указывать длину будущего 
	     * массива
	     */
	    int[] array_c = new int[] {3, 4, 5};
	    /* При динамическом способе инициализации, тип данных
	     * после ключевого слова *new* можно не указывать. Таким образом, 
	     * запись выше можно записать как:
	     *
	     * int[] array_c = new[] {3, 4, 5};
	     *
	     * можно также не указывать *new[]*:
	     * int[] array_C = {3, 4, 5};
	     */
		
	    Console.Write("array a: ");
	    for (int i = 0; i < array_a.Length; i++)
		Console.Write(array_a[i] + " ");
	    Console.WriteLine("\nLength of array: " + array_a.Length + "\n");
		
	    Console.Write("array b: ");
	    for (int i = 0; i < array_b.Length; i++)
		Console.Write(array_b[i] + " ");
	    Console.WriteLine("\nLength of array: " + array_b.Length + "\n");
		
	    Console.Write("array c: ");
	    for (int i = 0; i < array_c.Length; i++)
		Console.Write(array_c[i] + " ");
	    Console.WriteLine("\nLength of array: " + array_c.Length + "\n");
		
	    /* Метод Repeat класса Enumerable проинициализирует 
	     * массив на 5 элементов числом 3. 
	     * Для этого необходимо подключить System.Linq.
	     */ 
	    Console.Write("array d: ");
	    int[] array_d = Enumerable.Repeat(3, 5).ToArray();
	    for (int i = 0; i < array_d.Length; i++)
	    	Console.Write(array_d[i] + " ");
	    Console.WriteLine("\nLength of array: " + array_d.Length + "\n");
		
	    /* Метод Range класса Enumerable из библиотеки System.Linq
	     * позволяет инициализировать массив на 20 элементов,
	     * начиная с кого-то стартового, в данном случае 10
	     */
	    Console.Write("array e: ");
	    int[] array_e = Enumerable.Range(10, 20).ToArray();
	    for (int i = 0; i < array_e.Length; i++)
	    	Console.Write(array_e[i] + " ");
	    Console.WriteLine("\nLength of array: " + array_e.Length + "\n");

	    /* При попытке обратиться к элементу массива по индексу 
	     * за его пределами, будем выбрашено исключение
	     * Out of range exception
	     *
	     * array[5] = 1;
	     * array[-1] = 5;
	    */

        }
    }
}
