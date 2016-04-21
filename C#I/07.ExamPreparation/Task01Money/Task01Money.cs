namespace Task01Money
{
    // http://bgcoder.com/Contests/Practice/Index/203#0

    using System;

    public class Task01Money
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var sheetsPerStudent = int.Parse(Console.ReadLine());
            var priceOfRealm = decimal.Parse(Console.ReadLine());
            const decimal realmSize = 400;

            var totalSheetsOfPaper = numberOfStudents * sheetsPerStudent;
            var totalRealms = totalSheetsOfPaper / realmSize;

            var moneySaved = totalRealms * priceOfRealm;

            Console.WriteLine("{0:F3}", moneySaved);
        }
    }
}
