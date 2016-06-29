namespace PersonImplementation
{
    public class Person
    {
        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public byte? Age { get; private set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age.HasValue ? this.Age.ToString() : "Not specified");
        }
    }
}