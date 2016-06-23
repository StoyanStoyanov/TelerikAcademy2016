namespace Ex03AnimalsHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, byte age) : base(name, age, Sex.Female)
        {
        }
    }
}