using System;
using System.Numerics;

class CatalanNumbers
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
        BigInteger result = 1;
        result = Factorial(2 * numberN) / (Factorial(numberN + 1) * Factorial(numberN));
        Console.WriteLine(result);
    }
}
