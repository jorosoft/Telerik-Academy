using System;

class MergeSort
{
    static int[] MergeSorting(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
        int[] left = new int[array.Length / 2];
        int[] right = new int[array.Length - array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            left[i] = array[i];
        }
        for (int i = array.Length / 2, index = 0; i < array.Length; i++, index++)
        {
            right[index] = array[i];
        }
        left = MergeSorting(left);
        right = MergeSorting(right);
        return MergeArrays(left, right);
    }

    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] array = new int[left.Length + right.Length];
        int leftIndex = 0;
        int rightIndex = 0;
        int index = 0;
        while (index < array.Length)
        {
            if ((rightIndex == right.Length) || ((leftIndex < left.Length) && (left[leftIndex] < right[rightIndex])))
            {
                array[index] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                array[index] = right[rightIndex];
                rightIndex++;
            }
            index++;
        }
        return array;
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        numbers = MergeSorting(numbers);
        foreach (var element in numbers)
        {
            Console.WriteLine(element);
        }
    }
}