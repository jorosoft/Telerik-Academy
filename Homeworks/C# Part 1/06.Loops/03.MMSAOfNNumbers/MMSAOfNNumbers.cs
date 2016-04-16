using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        double[] numbers = new double[numbersCount];
        double sum = 0;
        double average = 0;
        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        average = sum / numbersCount;
        Array.Sort(numbers);
        Console.WriteLine("min={0:F2}", numbers[0]);
        Console.WriteLine("max={0:F2}", numbers[numbersCount-1]);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}