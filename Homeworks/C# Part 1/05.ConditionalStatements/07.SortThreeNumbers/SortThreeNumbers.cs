using System;

class SortThreeNumbers
{
    static void Main()
    {
        short numberA = short.Parse(Console.ReadLine());
        short numberB = short.Parse(Console.ReadLine());
        short numberC = short.Parse(Console.ReadLine());
        short temp;
        if (numberB > numberA && numberB > numberC)
        {
            temp = numberA;
            numberA = numberB;
            numberB = temp;
            if (numberC > numberB)
            {
                temp = numberB;
                numberB = numberC;
                numberC = temp;
            }
        }
        else if (numberC > numberA && numberC > numberB)
        {
            temp = numberC;
            numberC = numberA;
            numberA = temp;
            if (numberC > numberB)
            {
                temp = numberB;
                numberB = numberC;
                numberC = temp;
            }
        }
        else if (numberC > numberB)
        {
            temp = numberB;
            numberB = numberC;
            numberC = temp;
        }
        Console.WriteLine("{0} {1} {2}", numberA, numberB, numberC);
    }
}