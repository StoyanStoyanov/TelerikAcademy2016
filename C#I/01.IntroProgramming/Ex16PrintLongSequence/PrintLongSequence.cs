namespace Ex16PrintLongSequence
{
    // 16. Write a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, … 
    // Output the first 1000 members of the sequence, each on a separate line.

    using System;
    using System.Text;

    public class PrintLongSequence
    {
        public static void Main()
        {
            var sequence = GenerateSequence(1000, 0, 2, -1, 2);

            var output = new StringBuilder();

            for (int i = 0, len = sequence.Length; i < len; i++)
            {
                output.AppendLine(sequence[i].ToString());
            }

            Console.Write(output);
        }

        private static int[] GenerateSequence(int numberOfMembers, int oddStart, int oddIncrease, int evenStart, int evenIncrease)
        {
            var sequence = new int[numberOfMembers];

            for (int m = 1, o = oddStart, e = evenStart; m <= numberOfMembers; m++)
            {
                var currentMember = m % 2 == 0 ? e -= evenIncrease : o += oddIncrease;
                sequence[m - 1] = currentMember;
            }
            
            return sequence;
        }
    }
}
