namespace Ex08ExtractSentences
{
    using System;
    using System.Text;

    public class Ex08ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToUpperInvariant();
            var txt = "." + Console.ReadLine() + ".";
            var sb = new StringBuilder();

            for (int i = 0, j = 0; i < txt.Length; i++)
            {
                var match = true;

                for (j = i; j < i + word.Length; j++)
                {
                    if (char.ToUpperInvariant(txt[j]) != word[j - i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match && !char.IsLetter(txt[i - 1]) && !char.IsLetter(txt[j]))
                {
                    while (txt[--i] != '.');
                    while (txt[++i] != '.')
                        sb.Append(txt[i]);

                    sb.Append('.');
                }
            }

            Console.WriteLine(sb);
        }
    }
}