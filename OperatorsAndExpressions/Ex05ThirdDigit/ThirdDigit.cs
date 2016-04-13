namespace Ex05ThirdDigit
{
    /*  
        05. Write a program that reads an integer N from the console and prints true if the third digit of N is 7,
        or "false THIRD_DIGIT", where you should print the third digits of N.
        The counting is done from right to left, meaning 123456's third digit is 4.
    */

    using System;

    public class ThirdDigit
    {
        public static void Main()
        {
            var n = ulong.Parse(Console.ReadLine());

            var thirdDigit = (n / 100) % 10;

            Console.WriteLine(thirdDigit == 7 ? "true" : "false" + " " + thirdDigit);
        }
    }
}
