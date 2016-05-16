using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        Console.WriteLine("{0:F2}", surface);
    }
}