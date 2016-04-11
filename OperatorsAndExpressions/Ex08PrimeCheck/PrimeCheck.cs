namespace Ex08PrimeCheck
{
    /* 
        08. Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression 
        to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
        Note: You should check if the number is positive
    */

    using System;
    using System.Collections.Generic;

    public class PrimeCheck
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = false;
            List<int> dividers = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                if (number % i == 0)
                {
                    dividers.Add(i);
                }
            }

            if ((dividers.Count == 2) && ((dividers[0] == 1) && (dividers[1] == number)))
            {
                isPrime = true;
            }

            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}