namespace Ex09SortingArray
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/09.%20Sorting%20array

    using System;
    using System.Text;

    public class Ex09SortingArray
    {
        public static void Main()
        {
            var array = ReadInputArray();

            SortArray(array);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void SortArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                var maxElementIndex = GetMaxElementIndex(array, i);
                if (array[i] != array[maxElementIndex])
                {
                    array[i] ^= array[maxElementIndex];
                    array[maxElementIndex] ^= array[i];
                    array[i] ^= array[maxElementIndex];
                }
            }
        }

        private static int GetMaxElementIndex(int[] elements, int startIndex)
        {
            var bestElement = elements[startIndex];
            var bestElementIndex = startIndex;

            for (int i = startIndex - 1; i >= 0; i--)
            {
                var currentElement = elements[i];
                if (bestElement < currentElement)
                {
                    bestElement = currentElement;
                    bestElementIndex = i;
                }
            }

            return bestElementIndex;
        }

        private static int[] ReadInputArray()
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var array = new int[n];
            var num = new StringBuilder();

            for (int i = 0, j = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (char.IsDigit(symbol) || symbol == '-')
                {
                    num.Append(symbol);

                    if (i < input.Length - 1)
                    {
                        continue;
                    }
                }

                array[j++] = int.Parse(num.ToString());
                num.Clear();
            }

            return array;
        }
    }
}