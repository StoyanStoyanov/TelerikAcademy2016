namespace Ex15ReplaceTagsIII
{
    using System;
    using System.Text;

    public class Ex15ReplaceTagsIII
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = new StringBuilder();
            var url = new StringBuilder();
            var info = new StringBuilder();
            var wanted = "<a";
            var start = 0;
            var end = 0;

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + wanted.Length; j++)
                {
                    if (text[j] != wanted[j - i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    start = text.IndexOf('\"', j);
                    end = text.IndexOf('\"', start + 1);
                    for (int u = start + 1; u < end; u++)
                    {
                        url.Append(text[u]);
                    }

                    start = text.IndexOf('>', end);
                    end = text.IndexOf('<', start + 1);
                    for (int t = start + 1; t < end; t++)
                    {
                        info.Append(text[t]);
                    }

                    result.AppendFormat("[{0}]({1})", info, url);
                    info.Clear();
                    url.Clear();
                    i = end + 4;
                }

                result.Append(text[i]);
            }

            Console.WriteLine(result);            
        }
    }
}