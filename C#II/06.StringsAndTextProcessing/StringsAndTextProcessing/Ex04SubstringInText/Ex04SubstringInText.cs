namespace Ex04SubstringInText
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/04.%20Sub-string%20in%20text

    using System;
    using System.Text;

    public class Ex04SubstringInText
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var frequency = GetPatternFrequency(pattern, text);

            Console.WriteLine(frequency);
        }

        private static int GetPatternFrequency(string pattern, string text)
        {
            var substring = new StringBuilder();
            var frequency = 0;

            for (int i = text.Length - 1; i >= pattern.Length - 1; i--)
            {
                var match = true;

                for (int j = pattern.Length - 1, k = i; j >= 0; j--, k--)
                {
                    if (char.ToLower(pattern[j]) != char.ToLower(text[k]))
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    frequency++;
                }
            }

            return frequency;
        }
    }
}