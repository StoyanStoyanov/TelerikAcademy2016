namespace Ex10FindSumInArray
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/10.%20Find%20sum%20in%20array

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ex10FindSumInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var wantedSum = int.Parse(Console.ReadLine());

            var elements = new List<long>(numbers.Length);
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                elements.Add(numbers[i]);
                for (int j = i - 1; j >= 0; j--)
                {
                    if (elements.Sum() == wantedSum)
                    {
                        Console.WriteLine("{0}", string.Join(", ", elements));
                        return;
                    }

                    elements.Add(numbers[j]);
                }

                elements.Clear();
            }

            Console.WriteLine("Given sum is not present in the array");
        }
    }
}