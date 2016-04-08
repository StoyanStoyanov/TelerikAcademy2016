namespace Ex05BooleanVariable
{
    // 05. Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. 
    // Print it on the console.

    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            bool isFemale = false;

            Console.WriteLine("Gender: {0}", isFemale ? "Female" : "Male");
        }
    }
}
