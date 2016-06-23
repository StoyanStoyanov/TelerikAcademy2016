namespace Ex01SchoolHierarchy
{
    using System;

    public class Discipline : SchoolObject
    {
        private int numberOfLectures;

        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comments)
            : base(name, comments)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            : this(name, numberOfLectures, numberOfExercises, string.Empty)
        {
        }

        public int NumberOfExercises
        {
            get 
            { 
                return this.numberOfExercises; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises can't be less than zero.");
                }

                this.numberOfExercises = value; 
            }
        }

        public int NumberOfLectures
        {
            get 
            { 
                return this.numberOfLectures; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures can't be less than zero.");
                }

                this.numberOfLectures = value; 
            }
        }
    }
}