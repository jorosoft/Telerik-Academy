using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial(BigInteger number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * Factorial(number - 1);
    }

    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(number));
    }
}