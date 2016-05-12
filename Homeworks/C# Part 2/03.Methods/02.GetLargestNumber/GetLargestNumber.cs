using System;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber, secondNumber);
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' '); 
        int numberA = int.Parse(input[0]);
        int numberB = int.Parse(input[1]);
        int numberC = int.Parse(input[2]);
        Console.WriteLine(GetMax(GetMax(numberA, numberB), numberC));
    }
}
