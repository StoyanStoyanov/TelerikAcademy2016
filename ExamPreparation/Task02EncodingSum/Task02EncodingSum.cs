namespace Task02EncodingSum
{
    // http://bgcoder.com/Contests/Practice/Index/203#1

    using System;

    public class Task02EncodingSum
    {
        public static void Main()
        {
            var m = int.Parse(Console.ReadLine());
            var text = Console.ReadLine().ToUpper();

            long result = 0;

            for (int i = 0, len = text.Length; i < len; i++)
            {
                char currentChar = text[i];
                if (currentChar == '@')
                {
                    Console.WriteLine(result);
                    break;
                }
                else if (char.IsDigit(currentChar))
                {
                    result *= byte.Parse(currentChar.ToString());
                }
                else if (char.IsLetter(currentChar))
                {
                    result += (currentChar - 65);
                }
                else
                {
                    result %= m;
                }
            }
        }
    }
}