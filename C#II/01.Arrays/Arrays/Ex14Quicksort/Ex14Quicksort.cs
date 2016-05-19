namespace Ex14Quicksort
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/14.%20Quick%20sort

    using System;
    using System.Text;

    public class Ex14Quicksort
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            QuickSort(array);

            var output = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                output.Append(array[i]);
                output.AppendLine();
            }

            Console.Write(output);
        }

        private static void QuickSort(int[] arr)
        {
            // shuffle the elements of the array
            // shuffle needed for performance guarantee!
            Shuffle(arr);

            // sort the array recursively
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (end <= start)
                return;

            // improvement 1 
            // insertionsort small subarrays (+ ~ 20% performance)
            // even quicksort has too much overhead for tiny subarrays
            // cutoff to insertionsort for ~ [10... 20] items
            var cutoff = 10;
            if (end <= start + cutoff - 1)
            {
                InsertionSort(arr, start, end);
                return;
            }

            // TODO improvement 2
            // best choice of pivot item == median
            // estimate true median by taking median of sample
            // median of 3 (random) items
            // var median = GetMedianOfThree(arr, start, start + (end - start) / 2, end);

            // index of element in position
            var sortedElementIndex = Partition(arr, start, end);

            // sort left part
            Sort(arr, start, sortedElementIndex - 1);

            // sort right part
            Sort(arr, sortedElementIndex + 1, end);
        }

        private static int Partition(int[] arr, int start, int end)
        {
            // Phase I. Repeat until i and j pointers cross:
            // - Scan i from left to right so long as arr[i] < partitioning element (arr[start])
            // - Scan j from right to left so long as arr[j] > partitioning element (arr[start])
            // - Exchange arr[i] with arr[j]
            // Phase II. When pointers cross:
            // - Exchange partitioning element with arr[j]
            var pivot = arr[start];

            for (int i = start, j = end + 1; true;)
            {
                // find item on the left to swap
                while (arr[++i] < pivot && i != end);

                // find item on the right to swap
                while (arr[--j] > pivot);

                // check if pointers cross
                if (i >= j)
                {
                    // swap with partitioning element
                    Swap(ref arr[j], ref arr[start]);

                    // return index of item now known to be in place
                    return j;
                }

                // swap items
                Swap(ref arr[i],  ref arr[j]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            if (a != b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
        }
 
        private static void Shuffle(int[] arr)
        {
            // modern version of the Fisher–Yates shuffle
            // algorithm of Richard Durstenfeld
            // https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

            var gen = new Random();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var randIndex = gen.Next(0, i + 1);
                Swap(ref arr[randIndex], ref arr[i]);
            }
        }

        private static void InsertionSort(int[] arr, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = i; j > start; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}