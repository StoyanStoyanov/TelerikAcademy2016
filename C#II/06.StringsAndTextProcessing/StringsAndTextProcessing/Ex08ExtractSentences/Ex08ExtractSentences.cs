namespace Ex08ExtractSentences
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/08.%20Extract%20sentences
    // 100/100, 0.015

    using System;
    using System.Text;

    public class Ex08ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine(); 
            var text = "." + Console.ReadLine();
            var s = new StringBuilder();

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + word.Length; j++)
                {
                    if (text[j] != word[j - i])
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match && !char.IsLetter(text[i - 1]) 
                          && !char.IsLetter(text[j]))
                {   // go back to sentence start
                    while (text[--i] != '.');
                    // trim start
                    while (text[++i] == ' ');
                    // get sentence
                    while (text[i] != '.') 
                        s.Append(text[i++]);
                    // next trim end
                    while (s[s.Length - 1] == ' ')
                        s.Length--;
                    s.Append(". ");
                }
            }

            Console.Write(s);
        }
    }
}