using System;

class NumbersComparer
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(numberA, numberB)); 
    }
}