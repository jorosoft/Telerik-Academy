using System;
using System.Linq;

class RemoveElementsFromArray
{
    static int GetMaxIncreasingSequence(int[] array)
    {
        int[] maxSequence = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            maxSequence[i] = 1;
        }
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] <= array[i])
                {
                    maxSequence[i] = Math.Max(maxSequence[i], maxSequence[j] + 1);
                }
            }
        }
        return maxSequence.Max();
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int result = numberN - GetMaxIncreasingSequence(numbers);
        Console.WriteLine(result);
    }
}
