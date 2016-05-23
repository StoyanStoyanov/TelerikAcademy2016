namespace Ex15ReplaceTagsRealTask
{
    using System;
    using System.Text;

    public class Ex15ReplaceTagsRealTask
    {
        public static void Main()
        {
            var txt = Console.ReadLine();
            var x = "<a href=";
            var url = new StringBuilder();
            var inf = new StringBuilder();
            var r = new StringBuilder();

            for (int i = 0, j = 0; i < txt.Length; i++) {
                var match = true;
                for (j = i; j < i + x.Length; j++) { 
                    if (char.ToLower(txt[j]) != x[j - i]) {
                        match = false;
                        break;
                    }
                }
                if (match) {  
                    while (txt[j++] != '"');
                    while (txt[j] != '"') url.Append(txt[j++]);
                    while (txt[j++] != '>');
                    while (txt[j] != '<') inf.Append(txt[j++]);
                    while (txt[j++] != '>');
                    r.AppendFormat("[{0}]({1})", inf, url);
                    inf.Clear();
                    url.Clear();
                    i = j;
                }
                r.Append(txt[i]);
            }
            Console.Write(r);
        }
    }
}