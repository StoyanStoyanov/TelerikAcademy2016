namespace Task02
{
    using System;

    public class Task02
    {
        public static void Main()
        {
            var numberOfBuses = int.Parse(Console.ReadLine());

            var groupLead = int.Parse(Console.ReadLine());
            var numberOfGroups = 1;

            for (int i = 0; i < numberOfBuses - 1; i++)
            {
                var nextBus = int.Parse(Console.ReadLine());

                if (nextBus <= groupLead)
                {
                    groupLead = nextBus;
                    numberOfGroups++;
                }
            }

            Console.WriteLine(numberOfGroups);
        }
    }
}