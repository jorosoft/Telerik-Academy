using System;

class AppearanceCount
{
    static int CountNumberRepeats(int[] array, int searchedNumber)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchedNumber)
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
        int numberX = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberN; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        Console.WriteLine(CountNumberRepeats(numbers, numberX));
    }
}
