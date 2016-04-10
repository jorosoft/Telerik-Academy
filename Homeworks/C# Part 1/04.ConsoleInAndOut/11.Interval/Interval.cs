using System;

class Interval
{
    static void Main()
    {
        short numberN = short.Parse(Console.ReadLine());
        short numberM = short.Parse(Console.ReadLine());
        short counter = 0;
        short begin = Math.Min(numberN, numberM);
        begin++;
        for (short i = begin; i < Math.Max(numberN, numberM); i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}