namespace Ex04UnicodeCharacter
{
    // 04. Declare a character variable and assign it with the symbol that has Unicode code 42  
    // (decimal) using the  \u00XX  syntax, and then print it.
    // Hint: first, use the Windows Calculator to find the hexadecimal representation of  42 . The output should be  * .

    using System;
    using System.Text;

    public class UnicodeCharacter
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var symbol = '\u002A';

            Console.WriteLine(symbol);
        }
    }
}
