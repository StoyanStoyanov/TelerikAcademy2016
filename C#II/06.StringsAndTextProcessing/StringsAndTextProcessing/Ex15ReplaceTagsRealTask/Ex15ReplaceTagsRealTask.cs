namespace Ex15ReplaceTagsRealTask
{
    using System;
    using System.Text;

    public class Ex15ReplaceTagsRealTask
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var tagStart = "<a href=";

            var url = new StringBuilder();
            var innerText = new StringBuilder();
            var output = new StringBuilder();

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + tagStart.Length; j++)
                {
                    if (char.ToLowerInvariant(text[j]) != tagStart[j - i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    i = j;

                    while (text[i++] != '"');
                    while (text[i] != '"')
                    {
                        url.Append(text[i++]);
                    }

                    while (text[i++] != '>');
                    while (text[i] != '<')
                    {
                        innerText.Append(text[i++]);
                    }

                    output.Append('[');
                    output.Append(innerText);
                    output.Append(']');

                    output.Append('(');
                    output.Append(url);
                    output.Append(')');

                    innerText.Clear();
                    url.Clear();

                    while (text[i++] != '>');
                }

                output.Append(text[i]);
            }

            Console.WriteLine(output);
        }
    }
}