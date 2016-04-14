// 06. Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
// (prints its real roots).

using System;

public class QuadraticEquation
{
    public static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());

        var discriminant = (b * b) - (4 * a * c);

        if (discriminant == 0)
        {
            Console.WriteLine("{0:F2}", -(b / (2 * a)));
        }
        else if (discriminant > 0)
        {
            double rootOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double rootTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("{0:F2}", GetMin(rootOne, rootTwo));
            Console.WriteLine("{0:F2}", GetMax(rootOne, rootTwo));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
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