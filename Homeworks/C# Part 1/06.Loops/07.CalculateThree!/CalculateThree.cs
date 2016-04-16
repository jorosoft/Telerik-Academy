using System;
using System.Numerics;

class CalculateThree
{
    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        byte numberN = byte.Parse(Console.ReadLine());
        byte numberK = byte.Parse(Console.ReadLine());
        BigInteger result = 1;
        result = Factorial(numberN) / (Factorial(numberK) * Factorial(numberN - numberK));
        Console.WriteLine(result);
    }
}
