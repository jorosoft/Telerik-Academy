using System;

class ThreeNumbers
{
    static void Main()
    {
        int[] numbers = new int[3];
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());
        numbers[2] = int.Parse(Console.ReadLine());
        Array.Sort(numbers);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[0]);
        Console.WriteLine("{0:F2}", (numbers[0] + numbers[1] + numbers[2]) / 3.00);
    }
}