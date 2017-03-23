namespace Methods.Common
{
    using System;
    using Enumerations;
    
    public static class Calculator
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Invalid triangle sides!");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }        

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Invalid input arguments!");
            }

            var maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }
       
        public static double CalcDistance(double x1, double y1, double x2, double y2, out DirectionType direction)
        {
            direction = (y1 == y2) ? DirectionType.Horizontal : DirectionType.Undefined;
            direction = (x1 == x2) ? DirectionType.Vertical : DirectionType.Undefined;

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }        
    }
}