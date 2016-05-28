namespace Ex15ReplaceTagsRealTask
{
    using System;
    using System.Text;

    public class Ex15ReplaceTagsRealTask
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var x = "<a href=";

            var url = new StringBuilder();
            var info = new StringBuilder();
            var result = new StringBuilder();

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + x.Length; j++)
                { 
                    if (char.ToLower(text[j]) != x[j - i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {  
                    while (text[j++] != '"');
                    while (text[j] != '"')
                    {
                        url.Append(text[j++]);
                    }

                    while (text[j++] != '>');
                    while (text[j] != '<')
                    {
                        info.Append(text[j++]);
                    }

                    while (text[j++] != '>');

                    result.AppendFormat("[{0}]({1})", info, url);
                    info.Clear();
                    url.Clear();

                    i = j;
                }

                result.Append(text[i]);
            }

            Console.WriteLine(result);
        }
    }
}