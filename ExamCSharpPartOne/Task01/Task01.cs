namespace Task01
{
    using System;

    public class Task01
    {
        public static void Main()
        {
            var numberOfBirds = long.Parse(Console.ReadLine());
            var totalNumberOfFeathers = double.Parse(Console.ReadLine());

            double averageFeathersPerBird = totalNumberOfFeathers / numberOfBirds;

            Console.WriteLine("{0:F4}", (numberOfBirds & 1) == 0 ? averageFeathersPerBird * 123123123123 : averageFeathersPerBird / 317);
        }
    }
}