using System;

class calculate
{
    static int Factorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * Factorial(number - 1);
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        double numberX = double.Parse(Console.ReadLine());
        double sum = 1.0;
        if (numberX != 0)
        {
            for (int i = 1; i <= numberN; i++)
            {
                sum += Factorial(i) / Math.Pow(numberX, i);
            }            
        }
        Console.WriteLine("{0:F5}", sum);
    }
}