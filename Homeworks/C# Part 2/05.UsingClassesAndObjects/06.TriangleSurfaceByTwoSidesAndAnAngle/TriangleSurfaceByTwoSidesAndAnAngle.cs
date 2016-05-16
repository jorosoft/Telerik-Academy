using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        double angleInRadians = angle * Math.PI / 180;
        double surface = (sideA * sideB * Math.Sin(angleInRadians)) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}