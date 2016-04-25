namespace NextDate
{
    // http://bgcoder.com/Contests/Practice/Index/41#0
    // 100/100

    using System;

    public class NextDate
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var date = new DateTime(year, month, day);

            var nextDate = date.AddDays(1);

            Console.WriteLine(nextDate.ToString("d.M.yyyy"));
        }
    }
}