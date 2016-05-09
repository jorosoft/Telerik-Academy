using System;

class CompareArrays
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] arrOne = new int[numberN];
        int[] arrTwo = new int[numberN];
        bool areEqual = true;
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrTwo.Length; i++)
        {
            arrTwo[i] = int.Parse(Console.ReadLine());
            if (arrTwo[i] != arrOne[i])
            {
                areEqual = false;
            }
        }
        Console.WriteLine(areEqual ? "Equal" : "Not equal");
    }
}
