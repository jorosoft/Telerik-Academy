using System;

class LongSequence
{
    static void Main()
    {
        int numberOne = 0;
        int numberTwo = -1;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                numberOne += 2;
                Console.WriteLine(numberOne);
            }
            else
            {
                numberTwo -= 2;
                Console.WriteLine(numberTwo);
            }
        }
    }
}