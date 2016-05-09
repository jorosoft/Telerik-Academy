using System;

class AllocateArray
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] theArray = new int[numberN];
        for (int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = i * 5;
            Console.WriteLine(theArray[i]);
        }
    }
}