namespace Ex06FourDigits
{
    using System;
    using System.Text;

    public class FourDigits
    {
        public static void Main()
        {
            string numberAsString = Console.ReadLine();
            var output = new StringBuilder();

            // get sum
            output.AppendLine(GetSum(numberAsString).ToString());

            // get reversed string
            output.AppendLine(GetReversedString(numberAsString));

            // move last character to first position
            output.Append(numberAsString[numberAsString.Length - 1]);
            output.AppendLine(numberAsString.Substring(0, numberAsString.Length - 1));

            // swap values
            var numberAsCharArray = numberAsString.ToCharArray();
            SwapValues(ref numberAsCharArray[1], ref numberAsCharArray[2]);

            // get swapped string
            output.AppendLine(string.Join("", numberAsCharArray));
            
            Console.WriteLine(output);
        }

        private static byte GetSum(string input)
        {
            byte sum = 0;

            for (int i = 0, digitsLen = input.Length; i < digitsLen; i++)
            {
                sum += byte.Parse(input[i].ToString());
            }

            return sum;
        }

        private static string GetReversedString(string input)
        {
            var reversed = new StringBuilder();
            var numberOfDigits = input.Length;

            for (int i = numberOfDigits - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        private static void SwapValues(ref char firstValue, ref char secondValue)
        {
            firstValue ^= secondValue;
            secondValue ^= firstValue;
            firstValue ^= secondValue;
        }
    }
}
