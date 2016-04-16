using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long result = 0;
        for (int i = input.Length - 1; i >=0 ; i--)
        {
            result += long.Parse(input[i].ToString()) * (long)Math.Pow(2, input.Length - i - 1);
        }
        Console.WriteLine(result);
    }
}