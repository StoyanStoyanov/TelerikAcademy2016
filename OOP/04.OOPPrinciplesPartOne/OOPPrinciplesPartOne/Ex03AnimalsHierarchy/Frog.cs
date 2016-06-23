namespace Ex03AnimalsHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, byte age, Sex sex) : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} {1} says: ribbit, ribbit!", this.GetType().Name, this.Name);
        }
    }
}