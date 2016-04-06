namespace Ex15Age
{
    // 15. Write a program that reads your birthday(in the format  MM.DD.YYYY ) from the console 
    // and prints on the console how old you are you now 
    // and how old will you be after 10 years.

    // You should print two lines with one number on the each line: 
    // i.How old are you now, on the first line.
    // ii.How old will you be after 10 years, on the second line.


    using System;
    using System.Linq;

    public class Age
    {
        public static void Main()
        {
            int[] monthDayYear = Console.ReadLine().Split('.').Select(item => int.Parse(item)).ToArray();

            var birthDate = new DateTime(monthDayYear[2], monthDayYear[0], monthDayYear[1]);
            var currentDate = DateTime.Now;

            var ageInYears = currentDate.Subtract(birthDate).Days / 365;
            var ageIn10Years = ageInYears + 10;

            Console.WriteLine(ageInYears);
            Console.WriteLine(ageIn10Years);
        }
    }
}
