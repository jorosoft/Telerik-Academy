using System;

class PointInACircle
{
    static void Main()
    {
        float numberX = float.Parse(Console.ReadLine());
        float numberY = float.Parse(Console.ReadLine());
        double distance = Math.Sqrt(numberX*numberX + numberY*numberY);
        bool isInside;
        if (distance <= 2)
        {
            isInside = true;
            Console.WriteLine("yes {0:F2}", distance);
        }
        else
        {
            isInside = false;
            Console.WriteLine("no {0:F2}", distance);
        }        
    }
}
