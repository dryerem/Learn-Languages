using System;

namespace Sharp_Type_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type\tCTS Type\tSize\tRange of values");
            Console.WriteLine("bool\t" + typeof(bool) + "\t" + sizeof(bool) + "\t" + bool.TrueString + "..." + bool.FalseString);
            Console.WriteLine("byte\t" + typeof(byte) + "\t" + sizeof(byte) + "\t" + byte.MinValue + "..." + byte.MaxValue);
            Console.WriteLine("sbyte\t" + typeof(sbyte) + "\t" + sizeof(sbyte) + "\t" + sbyte.MinValue + "..." + sbyte.MaxValue);
            Console.WriteLine("short\t" + typeof(short) + "\t" + sizeof(short) + "\t" + short.MinValue + "..." + short.MaxValue);
            Console.WriteLine("ushort\t" + typeof(ushort) + "\t" + sizeof(ushort) + "\t" + ushort.MinValue + "..." + ushort.MaxValue);
            Console.WriteLine("int\t" + typeof(int) + "\t" + sizeof(int) + "\t" + "-2147483648...-2147483647");
            Console.WriteLine("uint\t" + typeof(uint) + "\t" + sizeof(uint) + "\t" + uint.MinValue + "..." + uint.MaxValue);
            Console.WriteLine("long\t" + typeof(long) + "\t" + sizeof(long) + "\t" + long.MinValue + "..." + long.MaxValue);
            Console.WriteLine("ulong\t" + typeof(ulong) + "\t" + sizeof(ulong) + "\t" + ulong.MinValue + "..." + ulong.MaxValue);
            Console.WriteLine("decimal\t" + typeof(decimal) + "\t" + sizeof(decimal) + "\t" + decimal.MinValue + "..." + decimal.MaxValue);
            Console.WriteLine("float\t" + typeof(float) + "\t" + sizeof(float) + "\t" + float.MinValue + "..." + float.MaxValue);
            Console.WriteLine("double\t" + typeof(double) + "\t" + sizeof(double) + "\t" + double.MinValue + "..." + double.MaxValue);
            Console.WriteLine("string\t" + typeof(string) + "\t" + "inf\t" + "empty...inf");
            Console.WriteLine("char\t" + typeof(char) + "\t" + sizeof(char) + "\t" + "Unicode symbol");
        }
    }
}
