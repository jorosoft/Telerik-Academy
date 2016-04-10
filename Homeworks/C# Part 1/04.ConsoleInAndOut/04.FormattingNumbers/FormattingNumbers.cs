using System;

class FormattingNumbers
{
    static void Main()
    {
        short numberA = short.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        string binary = Convert.ToString(numberA, 2).PadLeft(10, '0');
        Console.WriteLine("{0, -10:X}|{1,10}|{2, 10:F2}|{3, -10:F3}|", numberA, binary, numberB, numberC);
    }
}