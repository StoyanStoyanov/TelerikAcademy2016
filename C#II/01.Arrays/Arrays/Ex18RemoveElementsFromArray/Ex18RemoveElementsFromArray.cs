namespace Ex18RemoveElementsFromArray
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/18.%20Remove%20elements%20from%20array

    using System;
    using System.Collections.Generic;

    public class Ex18RemoveElementsFromArray
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            // longest increasing subsequence (tolerating equal elements)
            // note: 1 2 2 3 4 5 is a valid increasing sequence
            var s = new List<int>(n);

            for (int i = n - 1; i >= 0; i--)
            {
                var num = int.Parse(Console.ReadLine());
                if (s.Count == 0 || num >= s[s.Count - 1]) 
                    s.Add(num);
                else
                {
                    for (int j = 0; j < s.Count; j++)
                    {
                        // not strictly increasing
                        if (s[j] > num)
                        {
                            s[j] = num;
                            break;
                        }
                    }
                }
            }

            var minimalElementsToRemove = n - s.Count;
            Console.WriteLine(minimalElementsToRemove);
        }
    }
}