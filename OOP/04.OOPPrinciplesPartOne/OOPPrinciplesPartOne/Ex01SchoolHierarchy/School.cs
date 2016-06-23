namespace Ex01SchoolHierarchy
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private readonly Dictionary<string, Class> setOfClasses;

        public School(Dictionary<string, Class> setOfClasses)
        {
            this.setOfClasses = new Dictionary<string, Class>(setOfClasses);
        }

        public Dictionary<string, Class> SetOfClasses
        {
            get 
            { 
                return this.setOfClasses; 
            }
        }

        public void AddClass(Class classToAdd)
        {
            if (this.setOfClasses.ContainsKey(classToAdd.Name))
            {
                throw new ArgumentException("There's already a class with the same text identifier.");
            }

            this.setOfClasses.Add(classToAdd.Name, classToAdd);
            Console.WriteLine("{0} has been successfully added!", classToAdd);
        }

        public void RemoveClass(string classTextIdentifier)
        {
            if (!this.setOfClasses.ContainsKey(classTextIdentifier))
            {
                throw new ArgumentException("The class you're trying to remove does not exist in the school set of classes.");
            }

            Console.WriteLine("{0} has been successfully removed!", setOfClasses[classTextIdentifier]);
            this.setOfClasses.Remove(classTextIdentifier);
        }
    }
}