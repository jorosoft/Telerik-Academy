using System;

class BitSwap
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

    static long SwapBits(long number, int positionOne, int positionTwo)
    {
        int valueBitOne = GetBitByPosition(number, positionOne);
        int valueBitTwo = GetBitByPosition(number, positionTwo);
        if (valueBitOne == 0)
        {
            number = SetZeroAtPosition(number, positionTwo);
        }
        else
        {
            number = SetOneAtPosition(number, positionTwo);
        }
        if (valueBitTwo == 0)
        {
            number = SetZeroAtPosition(number, positionOne);
        }
        else
        {
            number = SetOneAtPosition(number, positionOne);
        }
        return number;
    }
    
    static void Main()
    {
        long numberN = long.Parse(Console.ReadLine());
        int numberP = int.Parse(Console.ReadLine());
        int numberQ = int.Parse(Console.ReadLine());
        int numberK = int.Parse(Console.ReadLine());
        for (int positionP = numberP; positionP <= numberP + numberK - 1; positionP++, numberQ++)
        {
            numberN = SwapBits(numberN, positionP, numberQ);            
        }
        Console.WriteLine(numberN);
    }
}
