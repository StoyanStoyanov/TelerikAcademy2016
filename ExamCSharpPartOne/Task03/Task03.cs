namespace Task03
{
    using System;
    using System.Numerics;

    public class Task03
    {
        public static void Main()
        {
            var numberOfDigits = int.Parse(Console.ReadLine());
            ulong n = 1;

            while (numberOfDigits > 0)
            {
                var length = n.ToString().Length;
                
                n++;
                numberOfDigits -= length;
            }

            Console.WriteLine(n - 1);
        }
    }
}