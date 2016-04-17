namespace Ex14CurrentDateTime
{
    // 14. Create a console application that prints the current date and time. Find out how in Internet.

    using System;

    public class CurrentDateTime
    {
        public static void Main()
        {
            var now = DateTime.Now;

            Console.WriteLine(now);
        }
    }
}
