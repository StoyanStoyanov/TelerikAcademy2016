namespace Ex06MaximalKSum
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/06.%20Maximal%20K%20sum

    using System;
    using System.Collections.Generic;

    public class Ex06MaximalKSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var elements = new List<long>(n);
            for (int i = n - 1; i >= 0; i--)
            {
                elements.Add(long.Parse(Console.ReadLine()));
            }

            long maxElement, maxSum = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                maxElement = long.MinValue;
                for (int j = elements.Count - 1; j >= 0; j--)
                {
                    var currentElement = elements[j];
                    if (maxElement < currentElement)
                    {
                        maxElement = currentElement;
                    }
                }

                maxSum += maxElement;
                elements.Remove(maxElement);
            }

            Console.WriteLine(maxSum);
        }
    }
}