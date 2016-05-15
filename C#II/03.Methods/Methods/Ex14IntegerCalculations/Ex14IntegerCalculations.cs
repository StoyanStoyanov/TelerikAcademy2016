namespace Ex14IntegerCalculations
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/14.%20Integer%20calculations

    using System;
    using System.Linq;
    using System.Numerics;

    public class Ex14IntegerCalculations
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            var minimum = GetMin(numbers);
            var maximum = GetMax(numbers);
            var average = GetAverage(numbers);
            var sum = GetSum(numbers);
            var product = GetProduct(numbers);

            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", minimum, maximum, average, sum, product);
        }

        private static BigInteger GetProduct(params int[] numbers)
        {
            var product = new BigInteger(1);

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                product *= numbers[i];
            }

            return product;
        }

        private static long GetSum(params int[] numbers)
        {
            var sum = 0L;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static double GetAverage(params int[] numbers)
        {
            var average = (double)GetSum(numbers) / numbers.Length;

            return average;
        }

        private static int GetMax(params int[] numbers)
        {
            var max = numbers[0];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                var current = numbers[i];
                if (max < current)
                {
                    max = current;
                }
            }

            return max;
        }

        private static int GetMin(params int[] numbers)
        {
            var min = numbers[0];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                var current = numbers[i];
                if (min > current)
                {
                    min = current;
                }
            }

            return min;
        }
    }
}