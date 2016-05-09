using System;

class FrequentNumber
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int tempCount = 1;
        int tempIndex = 0;
        int maxCount = 0;
        int maxIndex = 0;
        for (int current = 0; current < numbers.Length - 1; current++, tempCount = 1)
        {
            for (int compared = current + 1; compared < numbers.Length; compared++)
            {
                if (numbers[current] == numbers[compared])
                {
                    tempCount++;
                    tempIndex = current;
                }
            }
            if (maxCount < tempCount)
            {
                maxCount = tempCount;
                maxIndex = tempIndex;
            }
        }
        Console.WriteLine("{0} ({1} times)", numbers[maxIndex], maxCount);
    }
}