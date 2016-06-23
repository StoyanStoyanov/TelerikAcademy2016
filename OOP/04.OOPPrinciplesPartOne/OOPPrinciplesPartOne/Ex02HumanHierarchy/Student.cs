namespace Ex02HumanHierarchy
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, decimal grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public decimal Grade { get; private set; }
    }
}