namespace Ex23SeriesOfLetters
{
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