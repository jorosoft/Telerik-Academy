using System;

class HexadecimalToBinary
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

    static string DecimalToAnySystem(long decimalNumber, int destinationSystemBase)
    {
        string resultNumber = "";
        char[] alphabet = "0123456789ABCDEF".ToCharArray();
        long remainder = 0;
        do
        {
            remainder = decimalNumber % destinationSystemBase;
            resultNumber = alphabet[remainder] + resultNumber;
            decimalNumber /= destinationSystemBase;
        } while (decimalNumber > 0);
        return resultNumber;
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
        Console.WriteLine(DecimalToAnySystem(AnySystemToDecimal(number, 16), 2));
    }
}