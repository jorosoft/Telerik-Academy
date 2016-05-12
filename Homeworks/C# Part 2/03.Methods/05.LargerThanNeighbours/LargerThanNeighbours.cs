using System;

class LargerThanNeighbours
{
    static int CountNumbersWithSmallerNeighbours(int[] array)
    {
        int count = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < numberN; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        Console.WriteLine(CountNumbersWithSmallerNeighbours(numbers));
    }
}