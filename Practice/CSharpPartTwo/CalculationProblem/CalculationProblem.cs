using System;

class CalculationProblem
{
    static long AnySystemToDecimal(string anySystemNumber, int sourceSystemBase)
    {
        long decimalPresentation = 0;
        char[] alphabet = "abcdefghijklmnopqrstuvw".ToCharArray();
        int power = 0;
        anySystemNumber = anySystemNumber.ToLower();
        for (int digit = anySystemNumber.Length - 1; digit >= 0; digit--)
        {
            decimalPresentation += (anySystemNumber[digit] - 'a') * NumberPower(sourceSystemBase, power);
            power++;
        }
        return decimalPresentation;
    }

    static string DecimalToAnySystem(long decimalNumber, int destinationSystemBase)
    {
        string resultNumber = string.Empty;
        char[] alphabet = "abcdefghijklmnopqrstuvw".ToCharArray();
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
        string[] text = Console.ReadLine().Split(' ');
        long sumInDecimal = 0;
        for (int i = 0; i < text.Length; i++)
        {
            sumInDecimal += AnySystemToDecimal(text[i], 23);
        }
        string sumInTwentyThreeBase = DecimalToAnySystem(sumInDecimal, 23);
        Console.WriteLine("{0} = {1}", sumInTwentyThreeBase, sumInDecimal);
    }
}
