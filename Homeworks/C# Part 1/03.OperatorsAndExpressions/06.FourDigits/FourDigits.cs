using System;

class FourDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = (byte)Char.GetNumericValue(input[0]) + (byte)Char.GetNumericValue(input[1]) +
            (byte)Char.GetNumericValue(input[2]) + (byte)Char.GetNumericValue(input[3]);
        Console.WriteLine(sum);
        char[] reversedInput = input.ToCharArray();
        Array.Reverse(reversedInput);
        Console.WriteLine(reversedInput);
        Console.WriteLine("{3}{0}{1}{2}", input[0], input[1], input[2], input[3]);
        Console.WriteLine("{0}{2}{1}{3}", input[0], input[1], input[2], input[3]);
    }
}
