﻿namespace PersonImplementation
{
    // Exercise 04. 
    // Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
    // Override ToString() to display the information of a person and if age is not specified – to say so. 
    // Write a program to test this functionality.

    using System;

    public class PersonImplementation
    {
        public static void Main()
        {
            Console.WriteLine(new Person("Peter", 18));
            Console.WriteLine(new Person("Peter"));
        }
    }
}