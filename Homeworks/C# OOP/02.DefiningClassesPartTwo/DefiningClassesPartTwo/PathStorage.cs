namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(List<Point3D> path)
        {
            var filePath = @"..\..\Paths.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var point in path)
                {
                    writer.Write($"{{{point.CoordX},{point.CoordY},{point.CoordZ}}}");
                    writer.Write('|');
                }

                writer.WriteLine("\n");
                writer.Close();
            }
        }

        public static List<Path> LoadPaths()
        {
            var paths = new List<Path>();
            var filePath = @"..\..\Paths.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var linePoints = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var currentPath = new Path();
                    foreach (var point in linePoints)
                    {
                        var firstCommaPos = point.IndexOf(',');
                        var secondCommaPos = point.IndexOf(',', firstCommaPos + 1);
                        var xCoord = double.Parse(point.Substring(1, firstCommaPos - 1));
                        var yCoord = double.Parse(point.Substring(firstCommaPos + 1, secondCommaPos - firstCommaPos - 1));
                        var zCoord = double.Parse(point.Substring(secondCommaPos + 1, point.Length - secondCommaPos - 2));
                        currentPath.PointsSequence.Add(new Point3D(xCoord, yCoord, zCoord));
                    }

                    paths.Add(currentPath);
                    line = reader.ReadLine();
                }

                reader.Close();
            }

            return paths;
        }
    }
}
