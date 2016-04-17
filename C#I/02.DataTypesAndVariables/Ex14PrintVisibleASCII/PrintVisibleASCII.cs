namespace Ex14PrintVisibleASCII
{
    // 14. Find online more information about ASCII (American Standard Code for Information Interchange) 
    // and write a program that prints the visible characters of the ASCII table on the console 
    // (characters from 33 to 126 including).
    // Note: You may need to use for-loops(learn in Internet how).

    using System;
    using System.Text;

    public class PrintVisibleASCII
    {
        public static void Main()
        {
            var output = new StringBuilder();

            for (int i = 33; i < 127; i++)
            {
                output.Append((char)i);
            }

            Console.Write(output);
        }
    }
}
