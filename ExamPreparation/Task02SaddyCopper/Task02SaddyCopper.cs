namespace Task02SaddyCopper
{
    // http://bgcoder.com/Contests/Practice/Index/202#2

    using System;
    using System.Numerics;
    using System.Text;

    public class Task02SaddyCopper
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var currentSumsProduct = new BigInteger(1);
            var currentNumber = new BigInteger(n);
            var transformationsCount = 0;
            var output = new StringBuilder();

            while (true)
            {
                currentNumber /= 10;
                if (currentNumber == 0)
                {
                    currentNumber = currentSumsProduct;
                    transformationsCount++;
                    currentSumsProduct = 1;

                    if (currentNumber / 10 == 0)
                    {
                        output.AppendFormat("{0}\n{1}", transformationsCount, currentNumber);
                        break;
                    }
                    else if (transformationsCount == 10)
                    {
                        output.Append(currentNumber);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                var digits = currentNumber.ToString();
                var currentSum = 0;
                for (int i = 0, len = digits.Length; i < len; i++)
                {
                    if ((i & 1) == 0)
                    {
                        currentSum += int.Parse(digits[i].ToString());
                    }
                }

                currentSumsProduct *= currentSum;
            }

            Console.Write(output);
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

        //    return --count;
        //}
    }
}