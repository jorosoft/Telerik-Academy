using System;

class BinaryShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        string result = Convert.ToString(number, 2);
        result = result.Substring(Math.Max(result.Length - 16, 0)).PadLeft(16, '0');
        Console.WriteLine(result);
    }
}
