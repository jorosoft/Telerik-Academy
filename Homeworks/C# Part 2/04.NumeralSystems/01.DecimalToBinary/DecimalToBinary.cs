using System;

class DecimalToBinary
{
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
    
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToAnySystem(number, 2));
    }
}