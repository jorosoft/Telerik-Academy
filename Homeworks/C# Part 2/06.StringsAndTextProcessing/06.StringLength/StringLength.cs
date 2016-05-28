using System;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Replace("\\", string.Empty).PadRight(20, '*');
        Console.WriteLine(input);
    }
}