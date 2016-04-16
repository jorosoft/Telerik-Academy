using System;

class DecimalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long remainder;
        string result = "";
        do
        {
            remainder = input % 16;
            if (remainder == 10)
            {
                result = "A" + result;
            }
            else if (remainder == 11)
            {
                result = "B" + result;
            }
            else if (remainder == 12)
            {
                result = "C" + result;
            }
            else if (remainder == 13)
            {
                result = "D" + result;
            }
            else if (remainder == 14)
            {
                result = "E" + result;
            }
            else if (remainder == 15)
            {
                result = "F" + result;
            }
            else
            {
                result = remainder + result;
            }
            input /= 16;
        }
        while (input != 0);
        Console.WriteLine(result);
    }
}
