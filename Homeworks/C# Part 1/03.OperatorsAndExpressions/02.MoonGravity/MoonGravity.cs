using System;

class MoonGravity
{
    static void Main()
    {
        double manWeight = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F3}", manWeight * 0.17);
    }
}

