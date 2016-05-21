namespace Ex02CorrectBrackets
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/03.%20Correct%20brackets

    using System;

    public class Ex03CorrectBrackets
    {
        public static void Main()
        {
            var expression = Console.ReadLine();

            bool correctBrackets = CheckBrackets(expression);

            Console.WriteLine(correctBrackets ? "Correct" : "Incorrect");
        }

        private static bool CheckBrackets(string expression)
        {
            var unclosed = 0;

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                switch (expression[i])
                {
                    case ')': unclosed++; break;
                    case '(': unclosed--; break;
                }
            }

            return unclosed == 0;
        }
    }
}