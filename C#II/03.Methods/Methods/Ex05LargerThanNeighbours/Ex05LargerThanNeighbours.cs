namespace Ex05LargerThanNeighbours
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/05.%20Larger%20than%20neighbours

    using System;
    using System.Text;

    public class Ex05LargerThanNeighbours
    {
        public static void Main()
        {
            var array = ReadInputArray();

            var elementsCount = GetLargerThanNeighboursCount(array);

            Console.WriteLine(elementsCount);
        }

        private static bool IsLargerThanNeighbours(int position, int[] array)
        {
            var isLarger = false;

            isLarger = array[position] > array[position - 1]
                    && array[position] > array[position + 1];

            return isLarger;
        }

        private static int GetLargerThanNeighboursCount(int[] array)
        {
            var count = 0;

            for (int i = array.Length - 2; i > 0; i--)
            {
                if (IsLargerThanNeighbours(i, array))
                {
                    count++;
                }
            }

            return count;
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