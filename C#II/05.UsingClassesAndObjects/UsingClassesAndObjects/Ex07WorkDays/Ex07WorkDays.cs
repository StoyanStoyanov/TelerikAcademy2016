namespace Ex07WorkDays
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/07.%20Workdays

    using System;

    public class Ex07WorkDays
    {
        public static void Main()
        {
            var year = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());

            var date = new DateTime(year, month, day);
            var holidays = new DateTime[] { new DateTime(2016, 12, 25), new DateTime(2016, 12, 31) };
            var workDays = GetWorkDays(DateTime.Now, date, holidays);

            Console.WriteLine(workDays);
        }

        private static int GetWorkDays(DateTime now, DateTime date, DateTime[] holidays)
        {
            var days = date.Subtract(now).Days;

            var weekends = (days / 7) * 2;

            var workDays = days - weekends - holidays.Length;

            return Math.Abs(workDays);
        }
    }
}