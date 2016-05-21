namespace Ex01ReverseString
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/02.%20Reverse%20string

    using System;
    using System.Text;

    public class Ex02ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reversed = Reverse(input);

            Console.WriteLine(reversed);
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