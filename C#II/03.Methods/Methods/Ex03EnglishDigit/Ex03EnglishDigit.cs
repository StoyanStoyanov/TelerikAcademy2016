namespace Ex03EnglishDigit
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/03.%20English%20digit

    using System;

    public class Ex03EnglishDigit
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var lastDigit = GetLastDigit(num);

            var digitAsWord = DigitToWord(lastDigit);

            Console.WriteLine(digitAsWord);
        }

        private static int GetLastDigit(int number)
        {
            var digit = number % 10;

            digit = Math.Abs(digit);

            return digit;
        }

        private static string DigitToWord(int digit)
        {
            var word = "zero";

            switch (digit)
            {
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
            }

            return word;
        }
    }
}