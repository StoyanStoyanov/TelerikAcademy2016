namespace Ex03DivisibleBy7And5
{
    /* 03. Write a program that does the following:

        Reads an integer number from the console.
        Stores in a variable if the number can be divided by 7 and 5 without remainder.
        Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5.
        Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
    */

    using System;

    public class DivisibleBy7And5
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}", number % 35 == 0 ? "true" : "false", number);
        }
    }
}
