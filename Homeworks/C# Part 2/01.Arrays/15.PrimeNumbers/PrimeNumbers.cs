using System;

class PrimeNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        bool[] array = new bool[numberN + 1];
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(numberN); i++)
        {
            if (array[i] == true)
            {
                for (int sqr = i * i, index = 0, j = sqr; j < numberN + 1; index++, j = sqr + index * i)
                {
                    array[j] = false;
                }
            }
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == true)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}