namespace Ex02HumanHierarchy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /* 02. 
     * Define abstract class Human with first name and last name. 
     * Define new class Student which is derived from Human and has new field – grade.
     * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
     * and method MoneyPerHour() that returns money earned by hour by the worker. 
     * Define the proper constructors and properties for this hierarchy. 
     * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
     * Initialize a list of 10 workers and sort them by money per hour in descending order. 
     * Merge the lists and sort them by first name and last name.
     * 
     */

    public class HumanHierarchy
    {
        public static void Main()
        {
            // Create a list of 10 students
            var students = new List<Student>() 
            { 
                new Student("Stoyan", "Stoyanov", 5.50M),
                new Student("Atanas", "Mavrodiev", 4.50M),
                new Student("Anna", "Malakova", 5.30M),
                new Student("Dimitar", "Totev", 3.50M),
                new Student("Maria", "Stoyanova", 4.58M),
                new Student("Ivan", "Penkov", 6.00M),
                new Student("Dragana", "Mirkovich", 5.50M),
                new Student("Svetlin", "Nakov", 6.00M),
                new Student("Petko", "Buchvarov", 3.51M),
                new Student("Eva", "Milanova", 4.80M),
            };

            // Display the original list on the console
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student, student.Grade);
            }

            Console.WriteLine();

            // Display the sorted students list on the console
            foreach (var student in students.OrderBy(s => s.Grade))
            {
                Console.WriteLine("{0} {1}", student, student.Grade);               
            }

            Console.WriteLine();

            // Create a list of 10 workers
            var workers = new List<Worker>()
            {
                new Worker("Mitko", "Dimitroff", 300M, 12M),
                new Worker("Gosho", "Grigorov", 160M, 8M),
                new Worker("Tosho", "Angelov", 250M, 10M),
                new Worker("Mariika", "Kapon", 500M, 15M),
                new Worker("Gabriela", "Todorova", 180M, 7M),
                new Worker("Victor", "Alexandrov", 260M, 6M),
                new Worker("Kalina", "Georgieva", 250M, 10M),
                new Worker("Sashko", "Alexandrov", 600M, 12M),
                new Worker("Victoria", "Stoyanova", 500M, 9M),
                new Worker("Velko", "Velkov", 300M, 3M),
            };

            // Display the original list
            foreach (var worker in workers)
            {
                Console.WriteLine("{0} {1:C}", worker, worker.GetMoneyPerHour());
            }

            Console.WriteLine();

            // Display the sorted list of workers
            foreach (var worker in workers.OrderByDescending(w => w.GetMoneyPerHour()))
            {
                Console.WriteLine("{0} {1:C}", worker, worker.GetMoneyPerHour());
            }

            Console.WriteLine();

            // Merge the two lists
            var humans = students.Concat<Human>(workers);

            // Sort the resulting IEnumerable<Human> by first name and then by last name
            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            //// Display the sorted list
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}