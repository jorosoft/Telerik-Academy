using System;

class QuickSort
{
    static int SplitArray(int[] numbers, int left, int right)
    {
        int main = numbers[right];
        int result = left;
        for (int i = left; i < right; i++)
        {
            if (numbers[i] <= main)
            {
                int temp = numbers[i];                
                numbers[i] = numbers[result];
                numbers[result] = temp;
                result++;
            }
        }
        numbers[right] = numbers[result];
        numbers[result] = main;        
        return result;
    }

    static void QSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int main = SplitArray(array, left, right);
            QSort(array, left, main - 1);
            QSort(array, main + 1, right);
        }
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        QSort(numbers, 0, numbers.Length - 1);
        foreach (var element in numbers)
        {
            Console.WriteLine(element);
        }
    }
}
