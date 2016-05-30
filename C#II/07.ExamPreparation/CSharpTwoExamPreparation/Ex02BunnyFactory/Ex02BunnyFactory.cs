namespace Ex02BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Ex02BunnyFactory
    {
        public static void Main()
        {
            var cages = new List<int>();
            var line = Console.ReadLine();

            int bunnies;
            while (line != "END")
            {
                bunnies = int.Parse(line);
                cages.Add(bunnies);

                line = Console.ReadLine();
            }

            int s;
            int sum;
            BigInteger product;
            var next = new StringBuilder();

            for (int i = 1; i < cages.Count; i++)
            {
                s = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    s += cages[j];
                }

                if (cages.Count - i < s)
                {
                    break;
                }

                sum = 0;
                product = 1;

                for (int j = i; j < i + s; j++)
                {
                    sum += cages[j];
                    product *= cages[j];
                }

                while (product > 0)
                {
                    var d = product % 10;
                    if (d != 0 && d != 1)
                        next.Insert(0, d);
                    product /= 10;
                }

                while (sum > 0)
                {
                    var d = sum % 10;
                    if (d != 0 && d != 1)
                        next.Insert(0, d);
                    sum /= 10;
                }

                for (int j = i + s; j < cages.Count; j++)
                {
                    var value = cages[j];
                    // obviously there can be 0 or 1 bunnies in a cage...
                    if (value != 0 && value != 1)
                    {
                        next.Append(value);
                    }
                }

                cages = next
                    .ToString()
                    .Select(b => b - '0')
                    .ToList();
                next.Clear();
            }

            Console.WriteLine(string.Join(" ", cages));
        }
    }
}