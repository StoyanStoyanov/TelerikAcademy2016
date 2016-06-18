namespace Euclidian3DSpace
{
    using System;
    using Utilities;

    public class Test
    {
        public static void Main()
        {
            var firstPoint = new Point3D(2, 3, -1);
            var secondPoint = new Point3D(0, 5, 7);

            var distance = Point3DMethods.GetDistance3D(firstPoint, secondPoint);

            Console.WriteLine(distance);
        }
    }
}