namespace Ex05TriangleSurfaceByThreeSides
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/05.%20Triangle%20surface%20by%20three%20sides

    using System;

    public class Ex05TriangleSurfaceByThreeSides
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var surface = CalculateTriangleSurface(a, b, c);

            Console.WriteLine("{0:F2}", surface);
        }

        private static double CalculateTriangleSurface(double a, double b, double c)
        {
            double surface = 0;

            var p = (a + b + c) / 2;

            surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return surface;
        }
    }
}