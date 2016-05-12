using System;

class IntegerCalculations
{
    static long MinNumber(long[] array)
    {
        long minNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
        return minNumber;
    }

    static long MaxNumber(long[] array)
    {
        long maxNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
        }
        return maxNumber;
    }

    static double AverageValue(long[] array)
    {
        return NumbersSum(array) / (double)array.Length;
    }

    static long NumbersSum(long[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static long NumbersProduct(long[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        long[] numbers = new long[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        Console.WriteLine(MinNumber(numbers));
        Console.WriteLine(MaxNumber(numbers));
        Console.WriteLine("{0:F2}", AverageValue(numbers));
        Console.WriteLine(NumbersSum(numbers));
        Console.WriteLine(NumbersProduct(numbers));
    }
}
