using System;

class EnglishDigit
{
    static string GetDigitName(int digit)
    {
        string[] digitsNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return digitsNames[digit];
    }

    static void Main()
    {
        string input = Console.ReadLine();
        int lastDigit = Convert.ToInt32(input[input.Length - 1] - '0');
        Console.WriteLine(GetDigitName(lastDigit));
    }
}
