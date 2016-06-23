namespace Ex03AnimalsHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, byte age, Sex sex) 
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} {1} says: woof, woof!", this.GetType().Name, this.Name);            
        }
    }
}
