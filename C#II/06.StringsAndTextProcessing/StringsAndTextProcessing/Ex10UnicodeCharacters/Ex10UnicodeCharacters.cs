namespace Ex10UnicodeCharacters
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/10.%20Unicode%20characters

    using System;
    using System.Text;

    public class Ex10UnicodeCharacters
    {
        public static void Main()
        {
            var str = Console.ReadLine();

            var unicodeChars = ConvertToUnicodeChars(str);

            Console.WriteLine(unicodeChars);
        } 

        private static string ConvertToUnicodeChars(string str)
        {
            var template = "\\u0000";
            var sequence = new StringBuilder(template.Length * str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                var hex = DecimalToHex(ch);

                var instance = new StringBuilder(template);

                for (int j = instance.Length - 1, k = hex.Length - 1; k >= 0; k--, j--)
                {
                    instance[j] = hex[k];
                }

                sequence.Append(instance);
            }

            return sequence.ToString();
        }


        private static string DecimalToHex(int number)
        {
            var hex = new StringBuilder();
            var map = "0123456789ABCDEF";

            while (number > 0)
            {
                var hexDigit = map[(number % 16)];
                hex.Insert(0, hexDigit);
                number >>= 4;
            }

            return hex.ToString();
        }
    }
}