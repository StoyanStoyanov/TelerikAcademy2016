namespace Ex09FrequentNumber
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/09.%20Frequent%20number

    using System;

    public class Ex09FrequentNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int count = 1, maxCount = 1, mostFrequent = numbers[0];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (maxCount < count)
                {
                    mostFrequent = numbers[i];
                    maxCount = count;
                }

                count = 1;
            }

            Console.WriteLine("{0} ({1} times)", mostFrequent, maxCount);
        }
    }
}