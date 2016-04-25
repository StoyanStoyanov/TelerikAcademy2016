namespace SymbolToNumber
{
    // http://bgcoder.com/Contests/Practice/Index/205#1
    // 100/100

    using System;
    using System.Text;

    public class SymbolToNumber
    {
        public static void Main()
        {
            var secret = byte.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            var encoded = new StringBuilder();

            for (int i = 0, textLen = text.Length - 1; i < textLen; i++)
            {
                var currentChar = text[i];
                var newCharCode = (int)currentChar;

                if (char.IsLetter(currentChar))
                {
                    newCharCode *= secret;
                    newCharCode += 1000;
                }
                else if (char.IsDigit(currentChar))
                {
                    newCharCode += secret;
                    newCharCode += 500;
                }
                else
                {
                    newCharCode -= secret;
                }

                if ((i & 1) == 0)
                {
                    encoded.AppendFormat("{0:F2}\n", newCharCode / 100.0);
                }
                else
                {
                   encoded.AppendLine((newCharCode * 100).ToString());
                }
            }

            Console.WriteLine(encoded);
        }
    }
}