namespace NightmareOnCodeStreet
{
    // http://bgcoder.com/Contests/Practice/Index/107#1
    // 100/100

    using System;

    public class Task02NightmareOnCodeStreet
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var sum = 0;
            var digitsCount = 0;

            for (int i = 0, textLen = text.Length; i < textLen; i++)
            {
                var currentChar = text[i];
                if (((i & 1) == 1) && char.IsDigit(currentChar))
                {
                    digitsCount++;
                    sum += (currentChar - '0');
                }
            }

            Console.WriteLine("{0} {1}", digitsCount, sum);
        }
    }
}