using System;

class SortingArray
{
    static int GetMaxElement(int[] array, int index)
    {
        int maxElementIndex = index;
        for (int i = 0; i <= index; i++)
        {
            if (array[i] > array[maxElementIndex])
            {
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
    }

    static void SortArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int maxElementIndex = GetMaxElement(array, i);
            int temp = array[i];
            array[i] = array[maxElementIndex];
            array[maxElementIndex] = temp;
        }
    }

    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        SortArray(numbers);
        for (int i = 0; i < arrayLength; i++)
        {
            if (i != arrayLength - 1)
            {
                Console.Write("{0} ", numbers[i]);
            }
            else
            {
                Console.Write(numbers[i]);
            }
        }
        Console.WriteLine();
    }
}
