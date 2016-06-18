namespace VersionAttributeImplementation
{
    using System;

    public class VersionAttributeImplementation
    {
        public static void Main()
        {
            var sample = new Sample();
            var version = sample.GetType().GetCustomAttributes(typeof(VersionAttribute), false).GetValue(0);
            Console.WriteLine("The version of our sample class is {0}", version);
        }
    }
}