namespace Ex03FirstNameBeforeLastNameLinq
{
    /* 03. Write a method that from a given array of students finds all students
     * whose first name is before its last name alphabetically. Use LINQ query operators.
     */

    using System;
    using System.Linq;

    public class FirstNameBeforeLastNameLinq
    {
        public static void Main()
        {
            var students = new[]
            {
                new { FirstName = "Victoria", LastName = "Stoyanova" },
                new { FirstName = "Stoyan", LastName = "Stoyanov" },
                new { FirstName = "Atanas", LastName = "Buchvarov" },
                new { FirstName = "Stefan",  LastName = "Zlatkov" },
                new { FirstName = "George", LastName = "Simeonov" }
            };

            var filteredStudents = from s in students where s.FirstName.CompareTo(s.LastName) < 0 select s;
            // var filteredStudents = students.Where(s => s.FirstName.CompareTo(s.LastName) < 0);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
