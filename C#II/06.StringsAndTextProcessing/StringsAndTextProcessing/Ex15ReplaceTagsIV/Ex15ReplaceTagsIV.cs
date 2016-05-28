namespace Ex15ReplaceTagsIV
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/15.%20Replace%20tags
    // 100/100, 0.046

    using System;
    using System.Text;

    public class Ex15ReplaceTagsIV
    {
        public static void Main()
        {
            var parts = Console.ReadLine().Split(new[] { "<a ", "/a>" }, StringSplitOptions.None);
            var result = new StringBuilder();

            for (int i = 0; i < parts.Length; i++)
            {
                var p = parts[i];
                if (p.StartsWith("href="))
                {
                    result.AppendFormat("[{0}]({1})", GetChars('>', '<', p), GetChars('"', '"', p));
                }
                else
                {
                    result.Append(p);
                }
            }

            Console.Write(result);
        }

        private static string GetChars(char sCh, char eCh, string str)
        {
            var s = str.IndexOf(sCh);
            var e = str.IndexOf(eCh, s + 1);
            var chars = new StringBuilder(e - s + 1);
            for (int i = s + 1; i < e; i++)
                chars.Append(str[i]);
            return chars.ToString();
        }
    }
}