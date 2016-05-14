namespace Ex09Trapezoids
{
    /* 
        09. Write an expression that calculates trapezoid's area by given sides a and b and height h.
        The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
    */

    using System;

    public class Trapezoids
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double area = (h * (a + b)) / 2;

            Console.WriteLine("{0:F7}", area);
        }
    }
}