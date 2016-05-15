namespace Ex04AppearanceCount
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/04.%20Appearance%20count

    using System;
    using System.Text;

    public class Ex04AppearanceCount
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var x = Console.ReadLine();

            var xFrequency = GetFrequency(x, input);

            Console.WriteLine(xFrequency);
        }

        private static int GetFrequency(string pattern, string source)
        {
            var frequency = 0;
            var num = new StringBuilder();

            for (int i = 0; i < source.Length; i++)
            {
                var symbol = source[i];
                if (symbol == ' ')
                {
                    if (num.ToString() == pattern)
                    {
                        frequency++;
                    }

                    num.Clear();
                }
                else
                {
                    num.Append(symbol);
                }
            }

            return frequency;
        }
    }
}