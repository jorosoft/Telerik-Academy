using System;

class FibonacciNumbers
{
    static void Main()
    {
        byte numberN = byte.Parse(Console.ReadLine());
        long[] result = new long[numberN];
        if (numberN < 2)
        {
            result[0] = 0;
        }
        else if (numberN < 3)
        {
            result[0] = 0;
            result[1] = 1;
        }
        if (numberN >= 3)
        {
            result[0] = 0;
            result[1] = 1;
            for (byte i = 2; i < numberN; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
        }        
        for (byte i = 0; i < numberN; i++)
        {
            Console.Write("{0}", result[i]);
            if (i != numberN - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}