namespace Ex08NumberAsArray
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/08.%20Number%20as%20array

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ex08NumberAsArray
    {
        public static void Main()
        {
            var sizes = Console.ReadLine().Split(' ');

            var firstArraySize = int.Parse(sizes[0]);
            var secondArraySize = int.Parse(sizes[1]);
            var bestSize = firstArraySize > secondArraySize ? firstArraySize : secondArraySize;

            var firstArray = ReadInputArray(firstArraySize);
            var secondArray = ReadInputArray(secondArraySize);

            var resultingArray = DigitByDigitSum(firstArray, secondArray, bestSize);

            Console.WriteLine(string.Join(" ", resultingArray));
        }

        private static int[] DigitByDigitSum(int[] firstNumberDigits, int[] secondNumberDigits, int bestSize)
        {
            var sumAsDigits = new List<int>();
         
            for (int d = 0, carry = 0; d < bestSize; d++)
            {
                var currentDigitsSum = carry;

                if (d < firstNumberDigits.Length)
                {
                    currentDigitsSum += firstNumberDigits[d];
                }

                if (d < secondNumberDigits.Length)
                {
                    currentDigitsSum += secondNumberDigits[d];
                }

                if (currentDigitsSum >= 10)
                {
                    currentDigitsSum %= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                sumAsDigits.Add(currentDigitsSum);
            }

            return sumAsDigits.ToArray();
        }

        private static int[] ReadInputArray(int size)
        {
            var input = Console.ReadLine();

            var array = new int[size];
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