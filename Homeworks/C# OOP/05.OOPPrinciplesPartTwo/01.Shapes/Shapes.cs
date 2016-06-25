namespace _01.Shapes
{
    using System;

    internal class Shapes
    {
        internal static void Main()
        {
            var shapes = new Shape[]
                {
                    new Triangle(2.5, 5.3),
                    new Rectangle(7, 8),
                    new Square(2),
                    new Rectangle(2.5, 4.8),
                    new Square(3.14)
                };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"SURFACE OF SHAPE \"{shape.GetType().ToString().Substring(11)}\" IS: {shape.CalculateSurface()}");
            }
        }
    }
}
