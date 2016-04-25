namespace Enigmanation
{
    // http://bgcoder.com/Contests/Practice/Index/107#2
    // 100/100

    using System;
    using System.Text;

    public class Task03Enigmanation
    {
        public static void Main()
        {
            var expression = Console.ReadLine();
            decimal result = 0;
            char sign = '+';
            var currentNumber = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                var currentChar = expression[i];
                if (char.IsDigit(currentChar))
                {
                    currentNumber.Append(currentChar);
                }
                else if (currentChar == '+' || currentChar == '-' || currentChar == '*' || currentChar == '%')
                {
                    result = Calculate(result, decimal.Parse(currentNumber.ToString()), sign);
                    sign = currentChar;
                    currentNumber.Clear();
                }
                else if (currentChar == '(')
                {
                    currentNumber.Append(CalculateExpressionInBrackets(expression, ref i));
                }
                else if (currentChar == '=')
                {
                    result = Calculate(result, decimal.Parse(currentNumber.ToString()), sign);
                }
            }

            Console.WriteLine("{0:F3}", result);
        }

        private static string CalculateExpressionInBrackets(string expression, ref int i)
        {
            var number = new StringBuilder();
            decimal result = 0;
            char sign = '+';

            while (expression[++i] != ')')
            {
                if (char.IsDigit(expression[i]))
                {
                    number.Append(expression[i]);
                }
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '%')
                {
                    result = Calculate(result, decimal.Parse(number.ToString()), sign);
                    sign = expression[i];
                    number.Clear();
                }
            }

            return Calculate(result, decimal.Parse(number.ToString()), sign).ToString();
        }

        private static decimal Calculate(decimal result, decimal number, char sign)
        {
            switch (sign)
            {
                case '+': return result + number;
                case '-': return result - number;
                case '%': return result % number;
                default: return result * number;
            }
        }
    }
}