namespace Ex06TriangleSurfaceByTwoSidesAndAngle
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/06.%20Triangle%20surface%20by%20two%20sides%20and%20an%20angle

    using System;

    public class Ex06TriangleSurfaceByTwoSidesAndAngle
    {
        public static void Main()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var angle = double.Parse(Console.ReadLine());

            var surface = CalculateTriangleSurface(sideA, sideB, angle);

            Console.WriteLine("{0:F2}", surface);
        }

        private static double CalculateTriangleSurface(double sideA, double sideB, double angle)
        {
            double surface = 0;

            var angleInRadians = angle * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);

            surface = (sideA * sideB * sin) / 2;

            return surface;
        }
    }
}