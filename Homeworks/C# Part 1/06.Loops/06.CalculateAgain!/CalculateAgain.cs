using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        byte numberN = byte.Parse(Console.ReadLine());
        byte numberK = byte.Parse(Console.ReadLine());
        BigInteger factorialN= 1;
        BigInteger factorialK = 1;
        BigInteger result;
        for (byte i = 2; i <= numberN; i++)
        {
            factorialN *= i;
            if (i <= numberK)
            {
                factorialK *= i;
            }
            else
            {
                continue;
            }
        }
        result = factorialN / factorialK;
        Console.WriteLine("{0}", result);
    }
}