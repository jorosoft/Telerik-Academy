using System;

class SelectionSort
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int current = 0; current < numbers.Length - 1; current++)
        {
            for (int compared = current + 1; compared < numbers.Length; compared++)
            {
                if (numbers[current] > numbers[compared])
                {
                    int temp = numbers[current];
                    numbers[current] = numbers[compared];
                    numbers[compared] = temp;
                }
            }
        }
        foreach (var element in numbers)
        {
            Console.WriteLine(element);
        }
    }
}