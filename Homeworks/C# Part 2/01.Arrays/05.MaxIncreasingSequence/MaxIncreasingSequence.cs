using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int tempSequence = 1;
        int maxSequence = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] - numbers[i - 1] > 0)
            {
                tempSequence++;
            }
            else
            {
                tempSequence = 1;
            }
            if (maxSequence < tempSequence)
            {
                maxSequence = tempSequence;
            }
        }
        Console.WriteLine(maxSequence);
    }
}
