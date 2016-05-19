namespace Ex08SumIntegers
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/08.%20Sum%20integers

    using System;
    using System.Text;

    public class Ex08SumIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var sum = ExtractNumbersSum(input);

            Console.WriteLine(sum);
        }

        private static int ExtractNumbersSum(string input)
        {
            var sum = 0;
            var num = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];

                if (char.IsDigit(symbol))
                {
                    num.Append(symbol);

                    if (i != input.Length - 1)
                    {
                        continue;
                    }
                }

                sum += int.Parse(num.ToString());
                num.Clear();
            }

            return sum;
        }
    }
}