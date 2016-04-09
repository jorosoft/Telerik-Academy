using System;

class ThirdDigit
{
    static void Main()
    {
        uint numberN = uint.Parse(Console.ReadLine());
        byte digit;
        for (int i = 0; i <2; i++)
        {
            numberN /= 10;
        }
        digit = (byte)(numberN % 10);
        Console.WriteLine(digit==7 ? "true" : "false "+digit);
    }
}
