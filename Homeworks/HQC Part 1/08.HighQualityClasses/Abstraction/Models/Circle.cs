namespace Abstraction.Models
{
    using System;
    using Contracts;

    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Invalid value for radius: {value}");
                }

                this.radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
