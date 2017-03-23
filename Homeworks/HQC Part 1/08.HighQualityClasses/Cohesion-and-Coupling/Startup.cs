namespace CohesionAndCoupling
{
    using System;
    using Common;
    using Models;

    public class Startup
    {
        internal static void Main()
        {
            try
            {
                Console.WriteLine(FileManager.GetFileExtension("example"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
            }

            Console.WriteLine(FileManager.GetFileExtension("example.pdf"));
            Console.WriteLine(FileManager.GetFileExtension("example.new.pdf"));

            try
            {
                Console.WriteLine(FileManager.GetFileNameWithoutExtension("example"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
            }

            Console.WriteLine(FileManager.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileManager.GetFileNameWithoutExtension("example.new.pdf"));

            var distanceCalculator = new DistanceCalculator();
            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                distanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                distanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            var parallelepiped = new Parallelepiped(3, 4, 5, distanceCalculator);
            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", parallelepiped.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", parallelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalcDiagonalYZ());
        }
    }
}
