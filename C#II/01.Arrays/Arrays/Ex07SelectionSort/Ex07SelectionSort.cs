namespace Ex07SelectionSort
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/07.%20Selection%20sort

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

            for (int i = array.Length - 1; i >= 0; i--)
            {
                var maxValue = array[i];
                var maxIndex = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (maxValue < array[j])
                    {
                        maxValue = array[j];
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    array[i] ^= array[maxIndex];
                    array[maxIndex] ^= array[i];
                    array[i] ^= array[maxIndex];
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