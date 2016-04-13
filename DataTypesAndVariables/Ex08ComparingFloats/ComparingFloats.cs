namespace Ex13ComparingFloats
{
    // 08. Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
    // Note: Two floating-point numbers a and b cannot be compared directly by a == b 
    // because of the nature of the floating-point arithmetic.
    // Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double firstFloat = double.Parse(Console.ReadLine());
            double secondFloat = double.Parse(Console.ReadLine());

            // precision
            double eps = 0.000001;

            bool checkIfEqual = Math.Abs(firstFloat - secondFloat) <= eps;

            Console.WriteLine(checkIfEqual.ToString().ToLower());
        }
    }
}
