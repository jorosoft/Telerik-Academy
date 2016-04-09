using System;

class PointCircleRectangle
{
    static void Main()
    {
        double numberX = double.Parse(Console.ReadLine());
        double numberY = double.Parse(Console.ReadLine());
        double distanceCircle;
        distanceCircle = Math.Sqrt((numberX-1) * (numberX-1) + (numberY-1) * (numberY-1));
        if (distanceCircle > 1.5)
        {
            Console.Write("outside circle ");
        }
        else
        {
            Console.Write("inside circle ");
        }
        if (numberX > 5 || numberX < -1 || numberY > 1 || numberY < -1)
        {
            Console.WriteLine("outside rectangle");
        }
        else
        {
            Console.WriteLine("inside rectangle");
        }
    }
}
