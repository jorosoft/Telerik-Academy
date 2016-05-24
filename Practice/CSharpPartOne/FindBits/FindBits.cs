using System;

class FindBits
{
    static int GetBitAtPosition(int number, int p)
    {
        int mask = 1 << p;
        int nAndMask = number & mask;
        nAndMask >>= p;
        if (nAndMask == 0)
        {
            return 0;
        }
        else return 1;
    }

    static void Main()
    {
        int numberS = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            for (int pos = 0; pos <= 24; pos++)
            {
                bool areEqual = true;
                for (int j = 0; j <= 4; j++)
                {
                    if (GetBitAtPosition(numberS, j) != GetBitAtPosition(currentNumber, pos + j))
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (areEqual)
                {
                    counter++;
                }
            }           
        }
        Console.WriteLine(counter);
    }
}