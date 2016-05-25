namespace Ex02EvenDifferences
{
    using System;
    using System.Linq;

    public class Ex02EvenDifferences
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();

            long sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                var diff = Math.Abs(numbers[i] - numbers[i - 1]);
                if (diff % 2 == 0)
                {
                    sum += diff;
                    i++;
                }
            }

            Console.WriteLine(sum);
        } 
    }
}