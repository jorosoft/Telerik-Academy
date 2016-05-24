using System;

class EvenDifferences
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        long[] numbers = new long[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        long result = 0;
        int startIndex = 1;
        while (startIndex < numbers.Length)
        {
            long difference = Math.Max(numbers[startIndex], numbers[startIndex - 1]) - Math.Min(numbers[startIndex], numbers[startIndex - 1]);
            if (difference % 2 == 0)
            {
                startIndex += 2;
                result += difference;
            }
            else
            {
                startIndex++;
            }
        }
        Console.WriteLine(result);
    }
}
