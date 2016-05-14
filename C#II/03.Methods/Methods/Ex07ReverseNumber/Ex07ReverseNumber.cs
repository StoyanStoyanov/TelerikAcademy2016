namespace Ex07ReverseNumber
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/07.%20Reverse%20number

    using System;
    using System.Text;

    public class Ex07ReverseNumber
    {
        public static void Main()
        {
            Console.WriteLine(Reverse(Console.ReadLine()));
        }

        private static string Reverse(string input)
        {
            var reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }
    }
}