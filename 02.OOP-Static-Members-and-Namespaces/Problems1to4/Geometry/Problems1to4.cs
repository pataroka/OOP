namespace Problems1to4.Geometry
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    using Problems1to4.Geometry.Geometry3D;

    public static class Problems1To4
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D p1 = new Point3D(4, 5, 8);
            Point3D p2 = new Point3D(-4, -5, -8);
            Path3D pathList1 = new Path3D { p1, p2 };

            Console.WriteLine("P1 coordinates: {0}", p1);
            Console.WriteLine("P2 coordinates: {0}", p2);
            Console.WriteLine();
            Console.WriteLine("Distance between P1 and P2: {0}", DistanceCalculator3D.CalculateDistance3D(p1, p2));
            Console.WriteLine();
            Console.WriteLine("Coordinates of all points in Path List 1:\n{0}", pathList1);
            Console.WriteLine();

            Storage.Storage.ToFile("../../paths.txt", pathList1);
            var pathList2 = Storage.Storage.FromFile("../../paths2.txt");

            Console.WriteLine("Coordinates of all points in Path List 2:\n{0}", pathList2);
            Console.WriteLine();
            Console.WriteLine(
                "Distance between first and last element in Path List 2:\n{0}", 
                DistanceCalculator3D.CalculateDistance3D(pathList2.First(), pathList2.Last()));
            Console.WriteLine();
            Console.WriteLine(
                "Distance between third and sixth element in Path List 2:\n{0}", 
                DistanceCalculator3D.CalculateDistance3D(pathList2[3], pathList2[6]));
        }
    }
}