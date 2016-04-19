namespace Task01Printing
{
    // http://bgcoder.com/Contests/Practice/Index/202#0
    // 100/100

    using System;

    public class Task01Printing
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var sheetsPerStudent = int.Parse(Console.ReadLine());
            var priceOfRealm = decimal.Parse(Console.ReadLine());
            const decimal realmSize = 500;

            var totalSheetsOfPaper = numberOfStudents * sheetsPerStudent;
            var totalRealms = totalSheetsOfPaper / realmSize;

            var moneySaved = totalRealms * priceOfRealm;

            Console.WriteLine("{0:F2}", moneySaved);
        }
    }
}