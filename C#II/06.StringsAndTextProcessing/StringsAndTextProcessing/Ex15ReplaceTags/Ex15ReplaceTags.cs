namespace Ex15ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ex15ReplaceTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var startTagS = "<a href=";
            var newStartTagS = "[URL=";

            var startTagE = '>';
            var newStartTagE = ']';

            var endTag = "</a>";
            var newEndTag = "[/URL]";

            var indexOfStartTagS = 0;
            var indexOfStartTagE = 0;
            var indexesOfStartTagE = new List<int>();

            while (true)
            {
                indexOfStartTagS = input.IndexOf(startTagS, indexOfStartTagE);

                if (indexOfStartTagS == - 1)
                {
                    break;
                }

                indexOfStartTagE = input.IndexOf(startTagE, indexOfStartTagS);

                indexesOfStartTagE.Add(indexOfStartTagE);
            }

            var text = new StringBuilder(input);

            foreach (var index in indexesOfStartTagE)
            {
                text[index] = newStartTagE;
            }

            text.Replace(startTagS, newStartTagS);
            text.Replace(endTag, newEndTag);

            Console.Write(text);
        }
    }
}