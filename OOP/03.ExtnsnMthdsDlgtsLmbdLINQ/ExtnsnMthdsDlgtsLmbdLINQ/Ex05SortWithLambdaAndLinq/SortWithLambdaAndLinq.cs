namespace Ex05SortWithLambdaAndLinq
{
    /* 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions 
     * sort the students by first name and last name in descending order. 
     * Rewrite the same with LINQ.
     */

    using System;
    using System.Linq;

    public class SortWithLambdaAndLinq
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

            // Using Lambda 
            var sortedStudentsLambda = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);

            foreach (var student in sortedStudentsLambda)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Using Linq
            var sortedStudentsLinq =
                from s in students
                orderby s.FirstName descending, s.LastName descending
                select s;

            foreach (var student in sortedStudentsLinq)
            {
                Console.WriteLine(student);
            }
        }
    }
}
