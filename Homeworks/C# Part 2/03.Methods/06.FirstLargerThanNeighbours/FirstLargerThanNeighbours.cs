using System;

class FirstLargerThanNeighbours
{
    static int GetFirstNumbersWithSmallerNeighbours(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                index = i;
                break;
            }
        }        
        return index;
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
        Console.WriteLine(GetFirstNumbersWithSmallerNeighbours(numbers));
    }
}
