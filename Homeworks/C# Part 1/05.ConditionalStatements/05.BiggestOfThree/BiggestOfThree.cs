using System;

class BiggestOfThree
{
    static void Main()
    {
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        float max = numberA;
        if (numberB > max)
        {
            max = numberB;
        }
        if (numberC > max)
        {
            max = numberC;
        }
        Console.WriteLine(max);
    }
}
