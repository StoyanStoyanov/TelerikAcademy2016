namespace Ex01SchoolHierarchy
{
    /* 01. We are given a school. In the school there are classes of students. 
     * Each class has a set of teachers. Each teacher teaches a set of disciplines. 
     * Students have name and unique class number. Classes have unique text identifier. 
     * Teachers have name. Disciplines have name, number of lectures and number of exercises. 
     * Both teachers and students are people. 
     * Students, classes, teachers and disciplines could have optional comments (free text block).
     * Your task is to identify the classes (in terms of  OOP) and their attributes and operations, 
     * encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
     */

    using System;
    using System.Collections.Generic;

    public class SchoolHierarchy
    {
        public static void Main()
        {
            try
            {
                // Disclaimer: tried to test most of the code, I might have missed some tests

                // Create some sets of disciplines taught by different teachers

                var disciplinesTaughtByYordanova = new Dictionary<string, Discipline>()
                {
                    { "Physics", new Discipline("Physics", 20, 200) },
                    { "Mathematics", new Discipline("Mathematics", 40, 600) },
                    { "Chemistry", new Discipline("Chemistry", 20, 200) },
                };

                var disciplinesTaughtByGeorgiev = new Dictionary<string, Discipline>()
                {
                    { "Literature", new Discipline("Literature", 15, 150) },
                    { "English", new Discipline("English", 40, 600) },
                    { "Bulgarian", new Discipline("Bulgarian", 10, 100) },
                };

                var disciplinesTaughtByPetrova = new Dictionary<string, Discipline>() 
                {
                    { "Modern Art", new Discipline("Modern Art", 10, 100) },
                    { "Music", new Discipline("Music", 10, 20 ) },
                };

                var disciplinesTaughtByMetodiev = new Dictionary<string, Discipline>()
                {
                    { "Informatics", new Discipline("Informatics", 20, 200) },
                    { "Information Technologies", new Discipline("Information Technologies", 40, 600) },
                };

                // Create some teachers who teach those disciplines

                var yordanova = new Teacher("Yordanova", disciplinesTaughtByYordanova);
                var georgiev = new Teacher("Georgiev", disciplinesTaughtByGeorgiev);
                var petrova = new Teacher("Petrova", disciplinesTaughtByPetrova);
                var metodiev = new Teacher("Metodiev", disciplinesTaughtByMetodiev);

                // Create a set of teachers for our specific class 12a

                var teachersOfTwelveA = new Dictionary<string, Teacher>()
                {
                    { "Yordanova", yordanova },
                    { "Georgiev", georgiev },
                    { "Petrova", petrova },
                    { "Metodiev", metodiev },
                };

                var studentsInTwelveA = new Dictionary<int, Student>()
                {
                    { 1, new Student("Alexander", 1, "Excellent student") },
                    { 2, new Student("Boris", 2, "Very bad") },
                    { 3, new Student("Cvetan", 1, "Moderate") },
                    { 4, new Student("Ceca", 1, "Bitch") },
                    { 5, new Student("Victoria", 1, "Smarty pants") },
                    { 6, new Student("Gosho", 6) },
                    { 7, new Student("Sasho", 1) },
                    { 8, new Student("Mariika", 1, "Cutie") },
                    { 9, new Student("Mario", 1, "Excellent student") },
                    { 10, new Student("Peter", 1, "Excellent student") },
                };

                // Create a class 12a with the above set of teachers

                var twelveA = new Class("12a", teachersOfTwelveA, studentsInTwelveA, "Best Class Ever");

                // Create a school with a set of classes (we have only 1 class, buT it's our favorite :D)

                var school = new School(new Dictionary<string, Class>() { { "12a", twelveA } });

                // Test the add and remove methods we have, (the commented lines throw an exception)

                // Test Teacher methods

                //yordanova.AddDiscipline(new Discipline("Physics", 20, 200));
                yordanova.RemoveDiscipline("Physics");
                yordanova.AddDiscipline(new Discipline("Physics", 20, 200));

                // Test Class methods

                //twelveA.AddStudent(new Student("Alexander", 1, "Excellent student"));
                twelveA.AddStudent(new Student("Nikola", 21));
                twelveA.RemoveStudent(21);

                //twelveA.AddTeacher(new Teacher("Yordanova", disciplinesTaughtByYordanova));
                twelveA.RemoveTeacher("Yordanova");
                twelveA.AddTeacher(yordanova);
                //twelveA.RemoveTeacher("Illegal Name");
                // Test School methods

                //school.AddClass(twelveA);
                school.RemoveClass("12a");
                school.AddClass(twelveA);

                // Test optional comments

                Console.WriteLine(twelveA.Comments);
                //twelveA.Comments = "asdf";
                Console.WriteLine(twelveA.Comments);
                twelveA.RemoveComment();
                Console.WriteLine(twelveA.Comments);
                Console.WriteLine("ALLA");
                //twelveA.AddComment("this comment is too short");
                
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}