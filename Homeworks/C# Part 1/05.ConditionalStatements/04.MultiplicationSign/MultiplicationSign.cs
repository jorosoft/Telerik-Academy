using System;

class MultiplicationSign
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        string sign;
        if (numberA == 0 || numberB == 0 || numberC == 0)
        {
            sign = "0";
        }
        else if ((numberA < 0 && numberB < 0 && numberC < 0) || 
            ((numberA > 0 && numberB > 0 && numberC < 0) ||
            (numberA > 0 && numberB < 0 && numberC > 0) ||
            (numberA < 0 && numberB > 0 && numberC > 0)))
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }
        Console.WriteLine(sign);
    }
}