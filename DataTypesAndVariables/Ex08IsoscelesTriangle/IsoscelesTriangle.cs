namespace Ex08IsoscelesTriangle
{
    // 08. Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
    /* 
           ©
          © ©
         ©   ©
        © © © ©
        Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

        Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
    */

    using System;
    using System.Text;

    public class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var n = 9;
            var sign = '\u00A9';
            var backgroundSign = ' ';

            var rows = n / 3 + 1;
            var cols = (n / 3) * 2 + 1;

            var center = cols / 2;
            var left = center;
            var right = center;

            var output = new StringBuilder();

            // add the body
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    output.Append(col == left || col == right ? sign : backgroundSign);
                }

                output.AppendLine();
                left--;
                right++;
            }

            // add the base
            for (int col = 0; col < cols; col++)
            {
                output.Append(col % 2 == 0 ? sign : backgroundSign);
            }
        
            Console.WriteLine(output);
        }
    }
}