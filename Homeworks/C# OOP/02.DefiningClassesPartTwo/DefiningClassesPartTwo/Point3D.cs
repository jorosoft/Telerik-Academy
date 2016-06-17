namespace DefiningClassesPartTwo
{
    public struct Point3D
    {
        private static readonly Point3D CoordSystemStart = new Point3D(0, 0, 0);

        public Point3D(double coordX, double coordY, double coordZ)
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
            this.CoordZ = coordZ;
        }

        public static Point3D CSStart
        {
            get
            {
                return CoordSystemStart;
            }
        }

        public double CoordX { get; private set; }

        public double CoordY { get; private set; }

        public double CoordZ { get; private set; }

        public override string ToString()
        {
            return $"{{{this.CoordX}, {this.CoordY}, {this.CoordZ}}}";
        }
    }
}
