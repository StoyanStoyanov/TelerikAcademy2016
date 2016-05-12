namespace Ex08MaximalSum
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/08.%20Maximal%20sum

    using System;

    public class Ex08MaximalSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new long[n];
            for (int i = n - 1; i >= 0; i--)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            long maxSum = numbers[numbers.Length - 1], currentSum;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                currentSum = numbers[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    currentSum += numbers[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}