﻿namespace Ex03AnimalsHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, byte age) 
            : base(name, age, Sex.Male)
        {
        }
    }
}