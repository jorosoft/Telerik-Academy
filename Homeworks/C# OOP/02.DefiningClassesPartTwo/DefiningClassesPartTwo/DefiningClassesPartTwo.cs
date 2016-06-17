namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;

    public class DefiningClassesPartTwo
    {
        internal static void Main()
        {
            //// TEST WRITING IN FILE
            //var path = new Path();
            //path.PointsSequence.Add(new Point3D(12, 13, 14));
            //path.PointsSequence.Add(new Point3D(123, 133, 143));
            //path.PointsSequence.Add(new Point3D(1234, 1334, 1434));
            //path.PointsSequence.Add(new Point3D(12345, 13345, 14345));
            //PathStorage.SavePath(path.PointsSequence);

            //// TEST READING FFROM FILE
            //var paths = new List<Path>();
            //paths = PathStorage.LoadPaths();

            //// TEST GENERIC LIST
            //var list = new GenericList<Point3D>(12);
            //list.Add(new Point3D(1, 2, 3));
            //list.Add(new Point3D(8, 5, 43));
            //list.Add(new Point3D(12, 2333, 34));
            //list[3] = new Point3D(12, 13, 14);
            var list = new GenericList<int>();
            list.Add(17);
            list.Add(1755);
            list.Add(127);
            list.Add(2317);
            list.Add(2223127);
            Console.WriteLine(list.ToString());
            //list.RemoveAtIndex(2);
            //Console.WriteLine(list.ToString());
            //list.Insert(0, 255);
            //Console.WriteLine(list.ToString());
            //list.Clear();
            //Console.WriteLine(list.ToString());
            var index = list.IndexOf(2317);
            Console.WriteLine("Index of 127 is: {0}", index);
        }
    }
}
