namespace DefiningClassesPartTwo
{
    using System;
    using System.Collections.Generic;

    [Version(3, 14)]
    public class DefiningClassesPartTwo
    {
        internal static void Main()
        {
            Console.WriteLine("=============== Print 3D Point Test ===============");
            Console.WriteLine();
            var point = new Point3D(2, 4.56, 8.11);
            Console.WriteLine(point.ToString());
            Console.WriteLine();
            Console.WriteLine("======= Calculate Distance Between Two Points Test =======");
            Console.WriteLine();
            var otherPoint = new Point3D(2.14, 8.16, 33.56);
            Console.WriteLine(Calculate.GetDistanceBetweenPoints(point, otherPoint));
            Console.WriteLine();
            //// =============== Writing Path To File Test ===============
            //var path = new Path();
            //path.PointsSequence.Add(new Point3D(12, 13, 14));
            //path.PointsSequence.Add(new Point3D(123, 133, 143));
            //path.PointsSequence.Add(new Point3D(1234, 1334, 1434));
            //path.PointsSequence.Add(new Point3D(12345, 13345, 14345));
            //PathStorage.SavePath(path.PointsSequence);
            //// =============== Reading Paths From File Test ===============
            //var paths = new List<Path>();
            //paths = PathStorage.LoadPaths();
            Console.WriteLine("============ Generic List Test ============");
            Console.WriteLine();      
            var list = new GenericList<int>();
            list.Add(17);
            list.Add(1755);
            list.Add(2223127);
            list.Add(2317);
            list.Add(127);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            Console.WriteLine("============ Generic List After Removal Test ============");
            Console.WriteLine();
            list.RemoveAtIndex(2);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            Console.WriteLine("============ Generic List After Insertion Test ============");
            Console.WriteLine();
            list.Insert(0, 255);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            Console.WriteLine("============ Generic List Find Element By Index Test ============");
            Console.WriteLine();
            var index = list.IndexOf(2317);
            Console.WriteLine("Index of '2317' is: {0}", index);
            Console.WriteLine();
            Console.WriteLine("============ Generic List Min And Max Value Test ============");
            Console.WriteLine();
            Console.WriteLine("Min value: {0}", list.Min());
            Console.WriteLine("Max value: {0}", list.Max());
            Console.WriteLine();
            Console.WriteLine("============ Generic List After Clearing Test ============");
            Console.WriteLine();
            list.Clear();
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            Console.WriteLine("============ Generic List Auto Grow Test ============");
            Console.WriteLine();
            var newList = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                newList.Add(i);
                Console.WriteLine("Count: {0}, Capacity: {1}", newList.Count, newList.Capacity);
            }

            Console.WriteLine();

            // ============ Matrix Multiplication Test ============
            var myMatrix = new Matrix<double>(4, 3);
            myMatrix[0, 0] = 1;
            myMatrix[0, 1] = -1;
            myMatrix[0, 2] = 0;
            myMatrix[1, 0] = 0;
            myMatrix[1, 1] = 2;
            myMatrix[1, 2] = 3;
            myMatrix[2, 0] = 1;
            myMatrix[2, 1] = -3;
            myMatrix[2, 2] = 1;
            myMatrix[3, 0] = 4;
            myMatrix[3, 1] = 0;
            myMatrix[3, 2] = 2;
            var otherMatrix = new Matrix<double>(3, 2);
            otherMatrix[0, 0] = 2;
            otherMatrix[0, 1] = 1;
            otherMatrix[1, 0] = -1;
            otherMatrix[1, 1] = 0;
            otherMatrix[2, 0] = 3;
            otherMatrix[2, 1] = 1;           
            var matrix = myMatrix * otherMatrix;
            // expected result:
            //
            //  3    1
            //  7    3  
            //  8    2
            // 14    6 
            Console.WriteLine("============ Version Attribute Test ============");
            Console.WriteLine();
            var attributes = typeof(DefiningClassesPartTwo).GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("=================================================");
        }
    }
}
