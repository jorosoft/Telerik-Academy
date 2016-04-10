using System;

class QuadraticEquation
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        double determinant = (numberB * numberB) - (4 * numberA * numberC);
        double rootOne = (-numberB + Math.Sqrt(determinant)) / (double)(2 * numberA);
        double rootTwo = (-numberB - Math.Sqrt(determinant)) / (double)(2 * numberA);
        if (determinant > 0)
        {
            Console.WriteLine("{0:F2}", Math.Min(rootOne, rootTwo));
            Console.WriteLine("{0:F2}", Math.Max(rootOne, rootTwo));
        }
        else if (determinant == 0)
        {
            Console.WriteLine("{0:F2}", rootOne);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}