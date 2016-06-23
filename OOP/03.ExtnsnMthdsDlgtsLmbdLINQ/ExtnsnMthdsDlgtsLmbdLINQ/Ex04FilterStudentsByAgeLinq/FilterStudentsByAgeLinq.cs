namespace Ex04FilterStudentsByAgeLinq
{
    // 04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    using System;
    using System.Linq;

    public class FilterStudentsByAgeLinq
    {
        public static void Main()
        {
            var students = new[]
            {
                new { FirstName = "Victoria", LastName = "Stoyanova", Age = 28 },
                new { FirstName = "Stoyan", LastName = "Stoyanov", Age = 26 },
                new { FirstName = "Atanas", LastName = "Buchvarov", Age = 24 },
                new { FirstName = "Stefan",  LastName = "Zlatkov", Age = 18 },
                new { FirstName = "George", LastName = "Simeonov", Age = 22 }
            };

            var studentsFilteredByAge = from s in students where s.Age > 17 && s.Age < 25 select s;
            //var studentsFilteredByAge = students.Where(s => s.Age > 17 && s.Age < 25);

            foreach (var student in studentsFilteredByAge)
            {
                Console.WriteLine(student);
            }
        }
    }
}
