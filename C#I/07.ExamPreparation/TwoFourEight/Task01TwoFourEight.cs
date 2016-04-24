namespace TwoFourEight
{
    // http://bgcoder.com/Contests/Practice/Index/107#0
    // 100/100

    using System;

    public class TwoFourEight
    {
        public static void Main()
        {
            var firstNumber = long.Parse(Console.ReadLine());
            var secretCode = long.Parse(Console.ReadLine());
            var secondNumber = long.Parse(Console.ReadLine());

            long result = 0;

            if (secretCode == 2)
            {
                result = firstNumber % secondNumber;
            }
            else if (secretCode == 4)
            {
                result = firstNumber + secondNumber;
            }
            else if (secretCode == 8)
            {
                result = firstNumber * secondNumber;
            }

            Console.WriteLine(result % 4 == 0 ? result / 4 : result % 4);
            Console.WriteLine(result);
        }
    }
}