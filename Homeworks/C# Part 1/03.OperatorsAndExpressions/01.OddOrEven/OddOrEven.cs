using System;

class OddOrEven
{
    static void Main()
    {
        sbyte number = sbyte.Parse(Console.ReadLine());
        Console.WriteLine(number % 2 == 0 ? "even "+number : "odd "+number);        
    }
}
