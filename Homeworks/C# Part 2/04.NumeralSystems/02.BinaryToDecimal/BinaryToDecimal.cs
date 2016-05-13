using System;

class BinaryToDecimal
{
    static long AnySystemToDecimal(string anySystemNumber, int sourceSystemBase)
    {
        long decimalPresentation = 0;
        char[] alphabet = "0123456789ABCDEF".ToCharArray();
        int power = 0;
        anySystemNumber = anySystemNumber.ToUpper();
        for (int digit = anySystemNumber.Length - 1; digit >= 0; digit--)
        {
            if (char.IsLetter(anySystemNumber[digit]))
            {
                decimalPresentation += (anySystemNumber[digit] - 'A' + 10) * NumberPower(sourceSystemBase, power);
            }
            else
            {
                decimalPresentation += (anySystemNumber[digit] - '0') * NumberPower(sourceSystemBase, power);
            }
            power++;
        }
        return decimalPresentation;
    }

    static long NumberPower(long number, int power)
    {
        if (power == 0)
        {
            return 1;
        }
        long result = number;
        for (int i = 1; i < power; i++)
        {
            result *= number;
        }
        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(AnySystemToDecimal(number, 2));
    }
}