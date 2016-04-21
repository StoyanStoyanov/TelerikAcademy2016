namespace Task03Maslan
{
    // http://bgcoder.com/Contests/Practice/Index/203#2

    using System;
    using System.Text;
    using System.Numerics;

    public class Task03Maslan
    {
        public static void Main()
        {
            var currentNumber = new StringBuilder(Console.ReadLine());

            var currentSumsProduct = new BigInteger(1);
            var transformations = 0;
            Console.WriteLine(GetSumOfDigitsAtOddPositions(currentNumber));
            while (currentNumber.Length > 0)
            {
                currentNumber.Length--;

                var currentSum = GetSumOfDigitsAtOddPositions(currentNumber);
                if (currentSum != 0)
                {
                    currentSumsProduct *= currentSum;
                }
                
                if (currentNumber.Length == 0)
                {
                    currentNumber = new StringBuilder(currentSumsProduct.ToString());
                    transformations++;
                    currentSumsProduct = 1;

                    if (currentNumber.Length == 1)
                    {
                        Console.WriteLine(transformations);
                        Console.WriteLine(currentNumber);
                        break;
                    }

                    if (transformations == 10)
                    {
                        Console.WriteLine(currentNumber);
                        break;
                    }
                }
            }
        }

        private static int GetSumOfDigitsAtOddPositions(StringBuilder numberAsString)
        {
            int sum = 0;

            for (int i = 0, len = numberAsString.Length; i < len; i++)
            {
                if ((i & 1) == 1)
                {
                    sum += int.Parse(numberAsString[i].ToString());
                }
            }

            return sum;
        }
    }
}