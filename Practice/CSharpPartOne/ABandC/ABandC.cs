using System;

class ABandC
{
    static void Main()
    {
        int numbersCount = 3;
        int[] numbers = new int[numbersCount];
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Array.Sort(numbers);
        Console.WriteLine(numbers[numbersCount - 1]);
        Console.WriteLine(numbers[0]);
        Console.WriteLine("{0:F3}", sum / (double)numbersCount );
    }
}
