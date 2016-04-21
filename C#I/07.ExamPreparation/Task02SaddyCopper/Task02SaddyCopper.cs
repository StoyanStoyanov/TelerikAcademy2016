namespace Task02SaddyCopper
{
    // http://bgcoder.com/Contests/Practice/Index/202#2
    // 90/100 wtf...

    using System;
    using System.Numerics;
    using System.Text;

    public class Task02SaddyCopper
    {
        public static void Main()
        {
            var currentNumber = new StringBuilder(Console.ReadLine());

            var currentSumsProduct = new BigInteger(1);
            var transformationsCount = 0;

            while (currentNumber.Length > 0)
            {
                currentNumber.Length--;

                var currentSum = GetSumOfDigitsAtEvenPositions(currentNumber);
                if (currentSum != 0)
                {
                    currentSumsProduct *= currentSum;
                }

                if (currentNumber.Length == 0)
                {
                    currentNumber = new StringBuilder(currentSumsProduct.ToString());
                    transformationsCount++;
                    currentSumsProduct = 1;

                    if (currentNumber.Length == 1)
                    {
                        Console.WriteLine(transformationsCount);
                        Console.WriteLine(currentNumber);
                        break;
                    }

                    if (transformationsCount == 10)
                    {
                        Console.WriteLine(currentNumber);
                        break;
                    }
                }
            }
        }

        private static int GetSumOfDigitsAtEvenPositions(StringBuilder numberAsString)
        {
            var sum = 0;

            for (int i = 0, len = numberAsString.Length; i < len; i++)
            {
                if ((i & 1) == 0)
                {
                    sum += int.Parse(numberAsString[i].ToString());
                }
            }

            return sum;
        }

        //private static int CalculateSumOfEvenDigits(BigInteger number)
        //{
        //    int sum = 0;

        //    var position = GetDigitsCount(number);

        //    while (number > 0)
        //    {
        //        if ((position & 1) == 0)
        //        {
        //            sum += (int)(number % 10);
        //        }

        //        number /= 10;
        //        position--;
        //    }

        //    return sum;
        //}

        //private static int CalculateSumOfEvenDigits(string digits)
        //{
        //    int sum = 0;

        //    for (int i = 0, len = digits.Length; i < len; i++)
        //    {
        //        if ((i & 1) == 0)
        //        {
        //            sum += int.Parse(digits[i].ToString());
        //        }
        //    }

        //    return sum;
        //}

        //private static byte GetDigitsCount(BigInteger n)
        //{
        //    byte count = 0; do { count++; } while ((n /= 10) >= 1);

        //    return count;
        //}
    }
}