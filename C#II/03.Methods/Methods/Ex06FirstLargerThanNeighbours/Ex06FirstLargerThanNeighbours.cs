namespace Ex06FirstLargerThanNeighbours
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/06.%20First%20larger%20than%20neighbours

    using System;
    using System.Text;

    public class Ex06FirstLargerThanNeighbours
    {
        public static void Main()
        {
            var array = ReadInputArray();

            var wantedIndex = GetIndexOfFirstLargerThanNeighbours(array);

            Console.WriteLine(wantedIndex);
        }

        private static bool IsLargerThanNeighbours(int position, int[] array)
        {
            var isLarger = false;

            isLarger = array[position] > array[position - 1]
                    && array[position] > array[position + 1];

            return isLarger;
        }

        private static int GetIndexOfFirstLargerThanNeighbours(int[] array)
        {
            var index = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (IsLargerThanNeighbours(i, array))
                {
                    index = i;
                    break;
                }
            }

            return index;
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