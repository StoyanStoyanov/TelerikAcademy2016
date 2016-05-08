namespace Ex15PrimeNumbers
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/15.%20Prime%20numbers

    using System;

    public class Ex15PrimeNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var primes = GetPrimes(n, new bool[n + 1]);

            // print the biggest prime number which is <= N.
            for (int i = n; i >= 2; i--)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        // Sieve of Erathosthenes - Euler's modified version.
        private static bool[] GetPrimes(int n, bool[] primes)
        {
            // mark 2 as prime
            primes[2] = true;

            // mark odd primes starting from 3
            for (int o = 3; o <= n; o += 2)
            {
                primes[o] = true;
            }

            // mark out factors of odd primes.
            for (int o = 3; o <= n; o += 2)
            {
                if (primes[o])
                {
                    // find the current max factor of o
                    var maxF = n / o;

                    // if its even, start from the odd below
                    for (int f = (maxF & 1) == 0 ? --maxF : maxF; f >= o; f -= 2)
                    {
                        // if f is prime, mark out factor of o 
                        if (primes[f]) primes[o * f] = false;
                    }
                }
            }

            return primes;
        }
    }
}