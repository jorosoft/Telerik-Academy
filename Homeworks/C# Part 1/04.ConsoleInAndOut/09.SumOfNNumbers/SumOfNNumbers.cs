using System;

class SumOfNNumbers
{
    static void Main()
    {
        byte number = byte.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < number; i++)
        {
            double currentInput = double.Parse(Console.ReadLine());
            sum += currentInput;
        }
        Console.WriteLine(sum);
    }
}