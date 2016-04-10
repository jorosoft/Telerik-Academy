using System;

class NumbersFromOneToN
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}