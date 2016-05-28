using System;
using System.Collections.Generic;


class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> result = new List<char>();
        result.Add(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != result[result.Count - 1])
            {
                result.Add(input[i]);
            }
        }
        Console.WriteLine(string.Join("", result));
    }
}
