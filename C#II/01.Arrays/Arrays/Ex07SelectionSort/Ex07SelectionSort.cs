namespace Ex07SelectionSort
{
    /*
        07. Selection sort

        Description:

        Sorting an array means to arrange its elements in increasing order.
        Write a program to sort an array. Use the Selection sort algorithm:
        Find the smallest element, move it at the first position, 
        find the smallest from the rest, move it at the second position, etc.

        Input:

        On the first line you will receive the number N
        On the next N lines the numbers of the array will be given

        Output:

        Print the sorted array
        Each number should be on a new line

        Constraints:

        1 <= N <= 1024
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class Ex07SelectionSort
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                var currentMax = array[i];
                var currentMaxIndex = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (currentMax < array[j])
                    {
                        currentMax = array[j];
                        currentMaxIndex = j;
                    }
                }

                if (currentMaxIndex != i)
                {
                    array[i] ^= array[currentMaxIndex];
                    array[currentMaxIndex] ^= array[i];
                    array[i] ^= array[currentMaxIndex];
                }
            }

            var output = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                output.Append(array[i]);
                output.AppendLine();
            }

            Console.Write(output);
        }
    }
}