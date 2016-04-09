using System;

class BitExchange
{
    static int GetBitByPosition(long number, int position)
    {
        long mask = 1 << position;
        int searchedBit = (int)((number & mask) >> position); 
        return searchedBit;
    }

    static long SetZeroAtPosition(long number, int position)
    {
        long mask = ~(1 << position);
        long result = number & mask;
        return result;
    }

    static long SetOneAtPosition(long number, int position)
    {
        long mask = 1 << position;
        long result = number | mask;
        return result;
    }

    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        for (int currentPosition = 3, tempLowBit, tempHighBit; currentPosition <= 5; currentPosition++)
        {
            tempLowBit = GetBitByPosition(input, currentPosition);
            tempHighBit = GetBitByPosition(input, currentPosition + 21);
            if (tempLowBit == 0)
            {
                input = SetZeroAtPosition(input, currentPosition + 21);
            }
            else
            {
                input = SetOneAtPosition(input, currentPosition + 21);
            }
            if (tempHighBit == 0)
            {
                input = SetZeroAtPosition(input, currentPosition);
            }
            else
            {
                input = SetOneAtPosition(input, currentPosition);
            }
        }
        Console.WriteLine(input);
    }
}