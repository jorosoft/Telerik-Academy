namespace CohesionAndCoupling.Models
{
    using System;
    using Contracts;

    public class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;
        private IDistanceCalculator distanceCalculator;

        public Parallelepiped(double width, double height, double depth, IDistanceCalculator distanceCalculator)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
            this.distanceCalculator = distanceCalculator;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Incorrect value for width: {value}");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Incorrect value for height: {value}");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Incorrect value for depth: {value}");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = this.distanceCalculator.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
