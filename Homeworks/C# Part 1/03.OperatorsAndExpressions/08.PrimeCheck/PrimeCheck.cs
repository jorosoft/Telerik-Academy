using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number < 2)
        {
            isPrime = false;
        }
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime ? "true" : "false");
    }
}
