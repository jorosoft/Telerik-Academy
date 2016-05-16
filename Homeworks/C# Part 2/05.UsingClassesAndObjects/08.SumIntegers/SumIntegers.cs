using System;
using System.Linq;

class SumIntegers
{
    static int SumOfIntegers(string numbersString)
    {
        int[] numbers = Array.ConvertAll(numbersString.Split(' '), s => int.Parse(s));
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(SumOfIntegers(input));
    }
}
