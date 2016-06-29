namespace Ex01Shapes
{
    /* Exercise 01. 
     * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
     * Define two new classes Triangle and Rectangle that implement the virtual method 
     * and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). 
     * Define class Circle and suitable constructor so that at initialization height must be kept equal to width 
     * and implement the CalculateSurface() method. 
     * Write a program that tests the behavior of  the CalculateSurface() method 
     * for different shapes (Circle, Rectangle, Triangle) stored in an array.
     */

    using System;

    public class Shapes
    {
        public static void Main()
        {
            try
            {
                // The following three lines of code result in an ArgumentException()
                // var circle = new Circle(10.0, 5.0);
                // var rectangle = new Rectangle(0, 5);
                // var triangle = new Triangle(-5, 3);

                // Test the behavior of the CalculateSurface() method for different shapes 

                var shapes = new Shape[] { new Triangle(8.0, 5.0), new Rectangle(10.0, 7.0), new Circle(5.0, 5.0) };

                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape);
                    Console.WriteLine("{0} surface: {1}", shape.GetType().Name, shape.CalculateSurface());
                    Console.WriteLine();
                }
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}