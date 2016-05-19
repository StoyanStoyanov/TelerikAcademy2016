namespace Ex01LeapYear
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/01.%20Leap%20year

    using System;

    public class Ex01LeapYear
    {
        public static void Main()
        {
            var year = int.Parse(Console.ReadLine());

            var isLeap = DateTime.IsLeapYear(year);

            Console.WriteLine(isLeap ? "Leap" : "Common");
        }
    }
}