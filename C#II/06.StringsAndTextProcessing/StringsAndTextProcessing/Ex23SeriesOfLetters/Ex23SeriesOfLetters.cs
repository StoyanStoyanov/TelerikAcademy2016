namespace Ex23SeriesOfLetters
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/23.%20Series%20of%20letters

    using System;
    using System.Text;

    public class Ex23SeriesOfLetters
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var clean = new StringBuilder();

            clean.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                var next = text[i];
                if (next != text[i - 1])
                {
                    clean.Append(next);
                }
            }

            Console.WriteLine(clean);
        }
    }
}