using System;
using System.Numerics;

class ConsoleApplication1
{
    static void Main()
    {
        int position = 0;
        BigInteger product = 1;
        do
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            long number = long.Parse(input);
            if (position == 10)
            {
                Console.WriteLine(product);
                product = 1;
            }
            if (position % 2 == 1)
            {
                long currentProduct = 1;
                while (number != 0)
                {                    
                    long currentDigit = number % 10;
                    if (currentDigit != 0)
                    {
                        currentProduct *= currentDigit;
                    }
                    number /= 10;
                }
                product *= currentProduct; 
            }
            position++;
        } while (true);
        Console.WriteLine(product);
    }
}