using System;

class MaximalSum
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        int tempSum = 0;
        int maxSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            tempSum += numbers[i];
            if (maxSum < tempSum)
            {
                maxSum = tempSum;
            }
            else if (tempSum < 0)
            {
                tempSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}