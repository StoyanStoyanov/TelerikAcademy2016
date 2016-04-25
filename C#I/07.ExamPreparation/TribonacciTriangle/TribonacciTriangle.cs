namespace TribonacciTriangle
{
    // http://bgcoder.com/Contests/Practice/Index/41#1
    // 100/100

    using System;
    using System.Text;

    public class TribonacciTriangle
    {
        public static void Main()
        {
            var firstNumber = long.Parse(Console.ReadLine());
            var secondNumber = long.Parse(Console.ReadLine());
            var thirdNumber = long.Parse(Console.ReadLine());

            var numberOfLines = byte.Parse(Console.ReadLine());
            var output = new StringBuilder();

            output.AppendLine(firstNumber.ToString());
            output.AppendFormat("{0} {1}\n", secondNumber, thirdNumber);

            for (int i = 2; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    var nextNumber = firstNumber + secondNumber + thirdNumber;
                    output.Append(nextNumber);
                    output.Append(" ");

                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = nextNumber;
                }

                output.Length--;
                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}