namespace StudentImplementation
{ 
    // Exercises 01, 02, 03:
  
    // Exercise 01. 
    // Define a class Student, which contains data about a student – 
    // first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
    // Use an enumeration for the specialties, universities and faculties. 
    // Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
    
    // Exercise 02.
    // Add implementations of the ICloneable interface. 
    // The Clone() method should deeply copy all object's fields into a new object of type Student.

    // Exercise 03.
    // Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
    // and by social security number (as second criteria, in increasing order).
    
    using System;

    public class StudentImplementation
    {
        public static void Main()
        {
            // Create an instance of the class Student and print it's info
            var student = new Student("Gosho", "Petrov", "892299281");
            Console.WriteLine(student);

            // Create another instance of the class Student and print its info
            var anotherStudent = new Student("Gosho", "Petrov", "892299281");
            Console.WriteLine(anotherStudent);

            // Check whether the two instances are equal by value
            Console.WriteLine(student == anotherStudent); // True
            Console.WriteLine(student != anotherStudent); // False
            Console.WriteLine(student.Equals(anotherStudent)); // True

            // Check whether the two instance are equal by reference, too 
            // In other words, check if the two instances point to the same address in the heap
            Console.WriteLine(ReferenceEquals(student, anotherStudent)); // False

            // Now let's check if our Clone() method creates a DEEP copy
            // First, let's create a new instance of the Student class using the "fully-detailed" constructor
            var studentToClone = new Student("Alexander", "Trifonov", "Alexandrov", "808906756", "60, Dondukoff St, Sofia",
                "0884982603", "sashko_Programist4eto@mail.bg", "Programming",
                Universities.SofiaUniversity, Faculties.MathematicsandInformatics, Specialties.ComputerScience);
            // Let's print the info of studentToClone on the console
            Console.WriteLine(studentToClone);

            // Now let's create a deep copy of our studentToClone 
            var copyOfStudentToClone = studentToClone.Clone();
            // Let's print the info of copyOfStudentToClone on the console
            Console.WriteLine(copyOfStudentToClone);

            // We see all members have been copied correctly, so let's now put it to the final test
            // It's a correct copy but is it a shallow or a deep one? Let's check!
            // Let's change a few of our members' values in the copy and see if we're actually changing the original, too.
            copyOfStudentToClone.FirstName = "ChangedName";
            copyOfStudentToClone.SocialSecurityNumber = "ChangedSSN";
            copyOfStudentToClone.Specialty = Specialties.Law;
            copyOfStudentToClone.University = Universities.MassachusettsInstituteofTechnology;

            // Print the original student (It's the same, no changes made)
            Console.WriteLine(studentToClone);

            // Print the copy (We see the changes we just made to a few of its properties)
            Console.WriteLine(copyOfStudentToClone);

            // We did it, we made a deep copy, a brand new object, a perfect reflection of our original object
            // which does not share a single bit of information with the original object

            // Compare two students

            Console.WriteLine("When we compare 2 students with the same names and SSN we get {0}", student.CompareTo(anotherStudent));
            Console.WriteLine("Compare two different students, then we get {0}", student.CompareTo(copyOfStudentToClone));
            Console.WriteLine("And vice versa {0}", studentToClone.CompareTo(student));
        }
    }
}