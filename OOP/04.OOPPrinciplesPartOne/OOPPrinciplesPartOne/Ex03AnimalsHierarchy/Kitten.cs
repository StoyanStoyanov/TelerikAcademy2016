﻿namespace Ex03AnimalsHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(string name, byte age) 
            : base(name, age, Sex.Female)
        {
        }
    }
}