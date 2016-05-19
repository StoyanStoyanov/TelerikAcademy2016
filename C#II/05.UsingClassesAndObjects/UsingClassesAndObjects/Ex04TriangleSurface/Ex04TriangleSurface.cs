namespace Ex04TriangleSurface
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/04.%20Triangle%20surface%20by%20side%20and%20altitude

    using System;

    public class Ex04TriangleSurface
    {
        public static void Main()
        {
            var sideLength = double.Parse(Console.ReadLine());
            var altitude = double.Parse(Console.ReadLine());

            var surface = CalculateTriangleSurface(sideLength, altitude);

            Console.WriteLine("{0:F2}", surface);
        }

        private static double CalculateTriangleSurface(double sideLength, double altitude)
        {
            double surface = 0;

            surface = (sideLength * altitude) / 2;

            return surface;
        }
    }
}