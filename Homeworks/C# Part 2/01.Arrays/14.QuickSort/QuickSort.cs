using System;

class QuickSort
{
    static int SplitArray(int[] numbers, int left, int right)
    {
        int main = numbers[left];
        while (true)
        {
            while (numbers[left] < main)
                left++;
            while (numbers[right] > main)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static void QSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int main = SplitArray(array, left, right);
            if (main > 1)
                QSort(array, left, main - 1);

            if (main + 1 < right)
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
