namespace Ex02FloatOrDouble
{
    // 02. Which of the following values can be assigned to a variable of type float  
    // and which to a variable of type double:  34.567839023, 12.345, 8923.1234857, 3456.091 ? 
    // Write a program to assign the numbers in variables and print them to ensure no precision is lost.

    using System;

    public class FloatOrDouble
    {
        public static void Main()
        {
            double firstNumber = 34.567839023d;
            float secondNumber = 12.345f;
            double thirdNumber = 8923.1234857d;
            float forthNumber = 3456.091f;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(forthNumber);
        }
    }
}
