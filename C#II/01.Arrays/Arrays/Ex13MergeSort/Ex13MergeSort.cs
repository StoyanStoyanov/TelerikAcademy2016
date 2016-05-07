namespace Ex13MergeSort
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/13.%20Merge%20sort

    using System;
    using System.Text;

    public class Ex13MergeSort
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Sort(array);

            var output = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                output.AppendFormat("{0}\n", array[i]);
            }

            Console.Write(output);
        }

        private static void Merge(int[] arr, int s, int m, int e)
        {
            // save original array to copy
            var copy = (int[])arr.Clone();

            // compare the halves of copy item by item and save to original
            for (int i = s, left = s, right = m + 1; i <= e; i++)
            {
                if (left > m)                       arr[i] = copy[right++];
                else if (right > e)                 arr[i] = copy[left++];
                else if (copy[left] <= copy[right]) arr[i] = copy[left++];
                else if (copy[left] > copy[right]) arr[i] = copy[right++];
            }
        }

        private static void Sort(int[] arr)
        {
            for (int size = 1, n = arr.Length; size < n; size += size)
            {
                for (int start = 0; start < n - size; start += 2 * size)
                {
                    Merge(arr, start, start + size - 1, Math.Min(start + 2 * size - 1, n - 1));
                }
            }
        }
    }
}