namespace Ex01StringBuilderExtensionSubstring
{
    /* 01.Implement an extension method Substring(int index, int length) for the class StringBuilder
     * that returns new StringBuilder and has the same functionality as Substring in the class String. 
     */

    using System;
    using System.Text;

    public class StringBuilderExtensionSubstring
    {
        public static void Main()
        {
            var test = new StringBuilder();

            for (int i = 65; i < 91; i++)
            {
                test.Append((char) i);
            }

            Console.WriteLine(test);

            Console.WriteLine(test.Substring(0));
            Console.WriteLine(test.Substring(5));
            Console.WriteLine("{0, 26}", test.Substring(21, 5));
        }
    }
}
