namespace Ex12IndexOfLetters
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/12.%20Index%20of%20letters

    using System;
    using System.Text;

    public class Ex12IndexOfLetters
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var output = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                output.AppendFormat("{0}\n", word[i] - 97);
            }

            Console.Write(output);
        }
    }
}