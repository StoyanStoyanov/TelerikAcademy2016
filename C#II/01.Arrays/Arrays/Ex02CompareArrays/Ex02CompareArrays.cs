namespace Ex02CompareArrays
{
    /*
        02. Compare arrays

        Description:

        Write a program that reads two integer arrays of size N from the console 
        and compares them element by element.

        Input:

        On the first line you will receive the number N
        On the next N lines the numbers of the first array will be given
        On the next N lines the numbers of the second array will be given

        Output:

        Print Equal if the two arrays are the same and Not equal if they are not
        Constraints

        1 <= N <= 20
        N will always be a valid integer number
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class Ex02CompareArrays
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            // Allocate the first array and read its elements
            var firstArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            // Allocate the second array and read its elements
            var secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            // Compare the two arrays
            var equal = true;
            for (int i = n - 1; i >= 0; i--)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }

            // Print the corresponding result on the console
            Console.WriteLine(equal ? "Equal" : "Not equal");
        }
    }
}