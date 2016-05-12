using System;
using System.Linq;

class NumberAsArray
{
    static int[] GetSumOfNumbers(int[] arrOne, int[] arrTwo)
    {
        int minLength = Math.Min(arrOne.Length, arrTwo.Length);
        int maxLength = Math.Max(arrOne.Length, arrTwo.Length);
        int[] result = new int[maxLength + 1];
        int addedValue = 0;
        int biggerArray = 0;
        if (arrOne.Length > minLength)
        {
            biggerArray = 1;
        }
        else
        {
            biggerArray = 2;
        }
        for (int digit = 0; digit < maxLength; digit++)
        {
            if (digit < minLength)
            {
                result[digit] += arrOne[digit] + arrTwo[digit];
            }
            else
            {
                if (biggerArray == 1)
                {
                    result[digit] += arrOne[digit];
                }
                if (biggerArray == 2)
                {
                    result[digit] += arrTwo[digit];
                }
            }
            if (result[digit] > 9)
            {
                result[digit] = result[digit] % 10 + addedValue;
                addedValue++;
            }
            if (addedValue == 1)
            {
                result[digit + 1]++;
                addedValue = 0;
            }
        }
        return result;
    }

    static void Main()
    {
        string[] dimm = Console.ReadLine().Split(' ');
        int arrayOneLength = int.Parse(dimm[0]);
        int arrayTwoLength = int.Parse(dimm[1]);
        int[] arrayOne = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
        int[] arrayTwo = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
        int[] result = new int[Math.Max(arrayOneLength, arrayTwoLength) + 1];
        result = GetSumOfNumbers(arrayOne, arrayTwo);
        int resultLength = result.Length;
        if (result[result.Length - 1] == 0)
        {
            for (int i = 0; i < resultLength - 2; i++)
            {
                Console.Write("{0} ", result[i]);
            }
            Console.Write(result[result.Length - 2]);
        }
        else
        {
            Console.Write(string.Join(" ", result));
        }
        Console.WriteLine();
    }
}