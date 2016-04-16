using System;

class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long remainder;
        string result = "";
        do
        {
            remainder = input % 2;
            result = remainder + result;
            input /= 2;
        }
        while (input != 0);
        Console.WriteLine(result);
    }
}
