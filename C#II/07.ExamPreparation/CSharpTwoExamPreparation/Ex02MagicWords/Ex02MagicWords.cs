namespace Ex02MagicWords
{
    // http://bgcoder.com/Contests/Practice/Index/94#1
    // 100/100

    using System;
    using System.Text;

    public class Ex02MagicWords
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var words = new string[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            string[] reordered = Reorder(words);

            Print(reordered);
        }

        private static void Print(string[] reordered)
        {
            var sb = new StringBuilder();
            var i = 0;

            while (true)
            {
                var found = false;

                for (int j = 0; j < reordered.Length; j++)
                {
                    var word = reordered[j];
                    if (word.Length > i)
                    {
                        if (!found)
                        {
                            found = true;
                        }

                        sb.Append(word[i]);
                    }
                }

                if (!found)
                {
                    break;
                }

                i++;
            }

            Console.WriteLine(sb);
        }

        private static string[] Reorder(string[] words)
        {
            for (int i = 0, n = words.Length; i < n; i++)
            {
                var index = i;
                var newIndex = words[i].Length % (n + 1);

                while (newIndex > index + 1)
                {
                    var temp = words[index];
                    words[index] = words[index + 1];
                    words[index + 1] = temp;
                    index++;
                }

                while (newIndex < index)
                {
                    var temp = words[index];
                    words[index] = words[index - 1];
                    words[index - 1] = temp;
                    index--;
                }
            }

            return words;
        }
    }
}