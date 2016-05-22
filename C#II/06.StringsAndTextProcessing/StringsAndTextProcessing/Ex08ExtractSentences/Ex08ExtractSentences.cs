namespace Ex08ExtractSentences
{
    using System;
    using System.Text;

    public class Ex08ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToUpper();
            var text = "." + Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + word.Length; j++)
                {
                    if (char.ToUpper(text[j]) != word[j - i])
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match && !char.IsLetter(text[i - 1]) 
                          && !char.IsLetter(text[j]))
                {   // go back to sentence start
                    while (text[--i] != '.'); 
                    while (text[++i] != '.') 
                        sb.Append(text[i]);
                    sb.Append('.');
                }
            }

            Console.Write(sb);
        }
    }
}