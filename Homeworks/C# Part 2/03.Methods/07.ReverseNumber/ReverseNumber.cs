using System;

class ReverseNumber
{
    static string ReverseGivenNumber(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ReverseGivenNumber(input));
    }
}


