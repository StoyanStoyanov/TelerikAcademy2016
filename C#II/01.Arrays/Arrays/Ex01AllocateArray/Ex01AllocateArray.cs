namespace Ex01AllocateArray
{
    /*
        01. Allocate array

        Description:

        Write a program that allocates array of N integers, initializes each element by its index multiplied by 5
        and then prints the obtained array on the console.

        Input:
        
        On the only line you will receive the number N

        Output:

        Print the obtained array on the console.
        Each number should be on a new line

        Constraints:

        1 <= N <= 20
        N will always be a valid integer number
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class Ex01AllocateArray
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            // Allocate array of N integers
            var array = new int[n];

            // Initialize each element by its index multiplied by 5
            for (int i = n - 1; i >= 0; i--)
            {
                array[i] = i * 5;
            }

            // Print the obtained array on the console
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}