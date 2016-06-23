namespace Ex01SchoolHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Class : SchoolObject
    {
        private readonly Dictionary<string, Teacher> setOfTeachers;
        private readonly Dictionary<int, Student> setOfStudents;

        public Class(string uniqueTextIdentifier, Dictionary<string, Teacher> setOfTeachers, Dictionary<int, Student> setOfStudents, string comments)
            : base(uniqueTextIdentifier, comments)
        {
            this.setOfTeachers = new Dictionary<string, Teacher>(setOfTeachers);
            this.setOfStudents = new Dictionary<int, Student>(setOfStudents);
        }

        public Class(string uniqueTextIdentifier, Dictionary<string, Teacher> setOfTeachers, Dictionary<int, Student> setOfStudents)
            : this(uniqueTextIdentifier, setOfTeachers, setOfStudents, String.Empty)
        {
        }

        public void AddTeacher(Teacher teacher)
        {
            if (this.setOfTeachers.ContainsKey(teacher.Name))
            {
                throw new ArgumentException("This class already has a teacher with the same name.");
            }

            this.setOfTeachers.Add(teacher.Name, teacher);
            Console.WriteLine("{0} has been successfully added!", teacher);
        }

        public void RemoveTeacher(string name)
        {
            if (!this.setOfTeachers.ContainsKey(name))
            {
                throw new ArgumentException(String.Format("There's no teacher in this class with the name {0}.", name));
            }

            Console.WriteLine("{0} has been successfully removed!", setOfTeachers[name]);
            this.setOfTeachers.Remove(name);
        }

        public void AddStudent(Student student)
        {
            if (this.setOfStudents.ContainsKey(student.UniqueClassNumber))
            {
                throw new ArgumentException("This class already has a student with the same class number.");
            }

            this.setOfStudents.Add(student.UniqueClassNumber, student);
            Console.WriteLine("{0} has been successfully added!", student);
        }

        public void RemoveStudent(int uniqueClassNumber)
        {
            if (!this.setOfStudents.ContainsKey(uniqueClassNumber))
            {
                throw new ArgumentException(String.Format("There's no student in this class corresponding to the number {0}.", uniqueClassNumber));
            }

            Console.WriteLine("{0} has been successfully removed!", setOfStudents[uniqueClassNumber]);
            this.setOfStudents.Remove(uniqueClassNumber);
        }
    }
}