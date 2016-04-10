using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        short numberOne = short.Parse(Console.ReadLine());
        short numberTwo = short.Parse(Console.ReadLine());
        short numberThree = short.Parse(Console.ReadLine());
        short numberFour = short.Parse(Console.ReadLine());
        short numberFive = short.Parse(Console.ReadLine());
        Console.WriteLine(numberOne + numberTwo + numberThree + numberFour + numberFive);
    }
}