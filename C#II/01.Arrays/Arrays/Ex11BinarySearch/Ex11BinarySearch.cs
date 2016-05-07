namespace Ex11BinarySearch
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/11.%20Binary%20search

    using System;

    public class Ex11BinarySearch
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var array = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                array[n - i - 1] = int.Parse(Console.ReadLine());
            }

            var x = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, x));
        }

        private static int BinarySearch(int[] array, int target)
        {
            for (int start = 0, end = array.Length - 1, index; start <= end;)
            {
                index = start + (end - start) / 2;
                var currentElement = array[index];

                if (target == currentElement)
                {
                    return index;
                }

                if (target < currentElement)
                {
                    end = index - 1;
                }
                else
                {
                    start = index + 1;
                }
            }

            return -1;
        }
    }
}