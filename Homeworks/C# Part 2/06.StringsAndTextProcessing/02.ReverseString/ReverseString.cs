using System;
using System.Text;

class ReverseString
{
    static string Reverse(string text)
    {
        var length = text.Length;
        var result = new StringBuilder(length);
        for (int i = length - 1; i >= 0; i--)
        {
            result.Append(text[i]);
        }
        return result.ToString();
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string reversed = Reverse(input);
        Console.WriteLine(reversed);
    }
}