namespace Ex09PrintSequence
{
    // 09. Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ... 
    // Print on the console the first 10 members of the sequence from the description. Print each member on a separate line.

    using System;

    public class PrintSequence
    {
        public static void Main()
        {
            var numberOfMembers = 10;

            var oddStart = 0;
            var oddIncrease = 2;

            var evenStart = -1;
            var evenIncrease = 2;

            for (int m = 1, o = oddStart, e = evenStart; m <= numberOfMembers; m++)
            {
                var currentMember = m % 2 == 0 ? e -= evenIncrease : o += oddIncrease;
                Console.WriteLine(currentMember);
            }
        }
    }
}
