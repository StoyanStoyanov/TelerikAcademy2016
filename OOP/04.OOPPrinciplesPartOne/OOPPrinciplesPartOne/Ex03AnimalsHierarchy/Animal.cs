namespace Ex03AnimalsHierarchy
{
    public abstract class Animal : ISound
    {
        protected Animal(string name, byte age, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public string Name { get; protected set; }

        public byte Age { get; protected set; }

        public Sex Sex { get; protected set; }

        public virtual void ProduceSound() { }
    }
}