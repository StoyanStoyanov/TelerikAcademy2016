namespace Ex01SchoolHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Teacher : SchoolObject
    {
        private readonly Dictionary<string, Discipline> setOfDisciplines;

        public Teacher(string name, Dictionary<string, Discipline> setOfDisciplines, string comments)
            : base(name, comments)
        {
            this.setOfDisciplines = new Dictionary<string, Discipline>(setOfDisciplines);
        }

        public Teacher(string name, Dictionary<string, Discipline> setOfDisciplines)
            : this(name, setOfDisciplines, string.Empty)
        {
        }

        public void AddDiscipline(Discipline discipline)
        {
            if (this.setOfDisciplines.ContainsKey(discipline.Name))
            {
                throw new ArgumentException("There's already a discipline named the same way.");
            }
         
            this.setOfDisciplines.Add(discipline.Name, discipline);
            Console.WriteLine("{0} has been successfully added!", discipline);
        }

        public void RemoveDiscipline(string name)
        {
            if (!this.setOfDisciplines.ContainsKey(name))
            {
                throw new ArgumentException(string.Format("The discipline {0} you're trying to remove does not exist.", name));
            }

            Console.WriteLine("{0} has been successfully removed!", setOfDisciplines[name]);
            this.setOfDisciplines.Remove(name);
        }
    }
}