namespace Ex03AnimalsHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, byte age, Sex sex) : base(name, age, sex)
        {
        
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} {1} says: meow!", this.GetType().Name, this.Name);
        }
    }
}