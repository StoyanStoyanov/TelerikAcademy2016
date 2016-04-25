namespace ABC
{
    // http://bgcoder.com/Contests/Practice/Index/205#0
    // 100/100

    using System;

    public class ABC
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a, b), c));
            Console.WriteLine(GetMin(GetMin(a, b), c));
            Console.WriteLine("{0:F3}", (a + b + c) / 3.0);
        }

        private static double GetMax(double a, double b)
        {
            return (a + b) / 2 + Math.Abs((a - b) / 2);
        }

        private static double GetMin(double a, double b)
        {
            return (a + b) / 2 - Math.Abs((a - b) / 2);
        }
    }
}
