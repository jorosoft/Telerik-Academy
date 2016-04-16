using System;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int numberA = Convert.ToInt32(numbers[0]);
        int numberB = Convert.ToInt32(numbers[1]);
        int temp, remainder, result;
        if (numberB > numberA)
        {
            temp = numberA;
            numberA = numberB;
            numberB = temp;
        }
        do
        {
            if (numberA == 0)
            {
                result = numberB;
                break;
            }
            if (numberB == 0)
            {
                result = numberA;
                break;
            }
            remainder = numberA % numberB;
            numberA = numberB;
            numberB = remainder;
            result = numberA;
        } while (numberB != 0);        
        Console.WriteLine(Math.Abs(result));
    }
}