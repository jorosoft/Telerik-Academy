using System;

class BinarySearch
{
    static int BiSearch(int[] array, int searchedNumber, int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (array[i] == searchedNumber)
            {
                return i;                
            }            
        }
        return -1;
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberN];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int numberX = int.Parse(Console.ReadLine());
        int firstIndex = 0;
        int lastIndex = numbers.Length - 1;
        int resultIndex = 0;
        for (int i = firstIndex; i < lastIndex; i++)
        {
            int middle = lastIndex / 2;
            if (numbers[middle] == numberX)
            {
                resultIndex = middle;
                break;
            }
            if (numbers[middle] < numberX)
            {
                firstIndex = middle;
                resultIndex = BiSearch(numbers, numberX, firstIndex, lastIndex);
            }
            if (numbers[middle] > numberX)
            {
                lastIndex = middle;
                resultIndex = BiSearch(numbers, numberX, firstIndex, lastIndex);
            }
        }
        if (resultIndex >= 0 && resultIndex < numbers.Length)
        {
            Console.WriteLine(resultIndex);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}
