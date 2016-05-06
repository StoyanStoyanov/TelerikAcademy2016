namespace Ex04MaximalSequence
{
    /*
        04. Maximal sequence

        Description:

        Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

        Input:

        On the first line you will receive the number N
        On the next N lines the numbers of the array will be given

        Output:

        Print the length of the maximal sequence

        Constraints:

        1 <= N <= 1024
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class Ex04MaximalSequence
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var previousElement = int.Parse(Console.ReadLine());
            int count = 1, maxCount = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                var currentElement = int.Parse(Console.ReadLine());
                if (previousElement == currentElement)
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    previousElement = currentElement;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}