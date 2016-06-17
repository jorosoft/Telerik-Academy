namespace DefiningClassesPartTwo
{
    using System;

    public static class Calculate
    {
        public static double GetDistanceBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(firstPoint.CoordX - secondPoint.CoordX, 2) 
                + Math.Pow(firstPoint.CoordY - secondPoint.CoordY, 2) 
                + Math.Pow(firstPoint.CoordZ - secondPoint.CoordZ, 2));
            return distance;
        }
    }
}
