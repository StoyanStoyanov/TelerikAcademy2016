namespace Ex03DayOfWeek
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/03.%20Day%20of%20week

    using System;

    public class Ex03DayOfWeek
    {
        public static void Main()
        {
            var today = DateTime.Today;

            var dayOfWeek = today.DayOfWeek;

            Console.WriteLine(dayOfWeek);
        }
    }
}