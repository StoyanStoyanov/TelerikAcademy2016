namespace Ex08ExtractSentencesII
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/08.%20Extract%20sentences
    // 100/100, 0.031

    using System;
    using System.Linq;
    using System.Text;

    public class Ex08ExtractSentencesII
    {
        static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var sentences = text.Split('.')
                .Select(s => s.Trim());
            var separators = text
                .Where(ch => !char.IsLetter(ch))
                .Distinct()
                .ToArray();

            var e = new StringBuilder();

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(separators);
                foreach (var word in words)
                {
                    if (word == pattern)
                    {
                        e.Append(sentence);
                        e.Append(". ");
                        break;
                    }
                }
            }

            Console.Write(e);
        }
    }
}