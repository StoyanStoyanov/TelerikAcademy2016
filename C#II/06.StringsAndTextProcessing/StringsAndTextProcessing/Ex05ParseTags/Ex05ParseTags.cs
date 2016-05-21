namespace Ex05ParseTags
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/05.%20Parse%20tags

    using System;
    using System.Text;

    public class Ex05ParseTags
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var parsed = new StringBuilder();
            var inTags = false;

            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                if (ch == '<')
                {
                    while (text[++i] != '>');
                    inTags = !inTags;
                    continue;
                }

                parsed.Append(inTags ? char.ToUpper(ch) : ch);
            }

            Console.WriteLine(parsed);
        }
    }
}