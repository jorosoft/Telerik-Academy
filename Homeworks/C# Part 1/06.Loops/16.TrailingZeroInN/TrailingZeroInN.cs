using System;
using System.Numerics;

class TrailingZeroInN
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int counterZeros = 0;
        for (int power5 = 5; power5 <= numberN; power5 *= 5)
            counterZeros += numberN / power5;
        Console.WriteLine(counterZeros);
    }
}
