using System;

class MaximalKSum
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numberK = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        int sum = 0;
        for (int i = numbers.Length - 1; i >= numbers.Length - numberK ; i--)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}
