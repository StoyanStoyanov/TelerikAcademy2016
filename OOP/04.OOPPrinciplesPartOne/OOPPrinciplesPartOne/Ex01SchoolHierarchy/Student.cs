namespace Ex01SchoolHierarchy
{
    using System;

    public class Student : SchoolObject
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber, string comments)
            : base(name, comments)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public Student(string name, int uniqueClassNumber)
            : this(name, uniqueClassNumber, String.Empty)
        {
        }

        public int UniqueClassNumber
        {
            get 
            { 
                return this.uniqueClassNumber; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student's number in the class can't be negative.");
                }

                this.uniqueClassNumber = value;
            }
        }
    }
}