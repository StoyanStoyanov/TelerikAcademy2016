namespace Ex10PointCircleRectangle
{
    /* 
        10. Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
        if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        Print inside circle if the point is inside the circle and outside circle if it's outside. 
        Then print a single whitespace followed by inside rectangle if the point is inside the rectangle 
        and outside rectangle otherwise. See the sample tests for a visual description.
    */

    using System;

    public class PointCircleRectangle
    {
        public static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            // check if the point is within the circle K({1, 1}, 1.5)
            bool isInCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5;

            // check if the point is within the rectangle R(top=1, left=-1, width=6, height=2)
            bool isInRectangle = (x >= -1) && (x <= 5) && (y <= 1) && (y >= -1);

            Console.WriteLine("{0} circle {1} rectangle", isInCircle ? "inside" : "outside", isInRectangle ? "inside" : "outside" );
        }
    }
}