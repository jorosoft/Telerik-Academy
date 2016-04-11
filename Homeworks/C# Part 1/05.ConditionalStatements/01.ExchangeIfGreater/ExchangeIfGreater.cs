using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double tmp;
        if (numberA > numberB)
        {
            tmp = numberA;
            numberA = numberB;
            numberB = tmp;
        }
        Console.WriteLine("{0} {1}", numberA, numberB);
    }
}