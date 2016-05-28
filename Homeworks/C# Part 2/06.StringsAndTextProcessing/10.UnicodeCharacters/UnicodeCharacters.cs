using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        foreach (var item in input)
        {
            Console.Write("\\u{0:X4}", (int)item);
        }
        Console.WriteLine();
    }
}