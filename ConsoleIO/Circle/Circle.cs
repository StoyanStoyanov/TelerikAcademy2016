// 03. Write a program that reads from the console the radius r of a circle and prints its perimeter and area, 
// rounded and formatted with 2 digits after the decimal point.

using System;

public class Circle
{
    public static void Main()
    {
        var radius = double.Parse(Console.ReadLine());

        var perimeter = 2 * Math.PI * radius;
        var area = Math.PI * radius * radius;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}