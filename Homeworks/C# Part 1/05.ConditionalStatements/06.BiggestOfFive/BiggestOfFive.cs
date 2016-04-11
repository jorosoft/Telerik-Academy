using System;

class BiggestOfFive
{
    static void Main()
    {
        float numberA = float.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        float numberD = float.Parse(Console.ReadLine());
        float numberE = float.Parse(Console.ReadLine());
        float max = numberA;
        if (numberB > max)
        {
            max = numberB;
        }
        if (numberC > max)
        {
            max = numberC;
        }
        if (numberD > max)
        {
            max = numberD;
        }
        if (numberE > max)
        {
            max = numberE;
        }
        Console.WriteLine(max);
    }
}