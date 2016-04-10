using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", numberA + numberB + numberC);        
    }
}