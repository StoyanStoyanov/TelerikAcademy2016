namespace Ex15BitSwap
{
    // 15. Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. 
    // Print the resulting integer on the console.
    // On the only four lines of the input you will receive the integers n, p, q and k in this order.

    using System;

    public class BitSwap
    {
        public static void Main()
        {
            var n = ulong.Parse(Console.ReadLine());
            var p = byte.Parse(Console.ReadLine());
            var q = byte.Parse(Console.ReadLine());
            var k = byte.Parse(Console.ReadLine());

            //for (int i = 0; i < k; i++, p++, q++)
            //{
            //    n = SwapBits(p, q, n);
            //}

            var leftPositions = new byte[k];
            var rightPositions = new byte[k];
            for (int i = 0; i < k; i++, p++, q++)
            {
                leftPositions[i] = p;
                rightPositions[i] = q;
            }

            n = SwapBits(leftPositions, rightPositions, n);

            Console.WriteLine(n);
        }

        private static ulong SwapBits(byte position1, byte position2, ulong number)
        {
            var x = ((number >> position1) ^ (number >> position2)) & 1;

            return number ^ ((x << position1) | (x << position2));
        }

        private static ulong SwapBits(byte[] positions1, byte[] positions2, ulong number)
        {
            for (int i = 0, numberOfSwaps = positions1.Length; i < numberOfSwaps; i++)
            {
                var temp = ((number >> positions1[i]) ^ (number >> positions2[i])) & 1;

                number ^= ((temp << positions1[i]) | (temp << positions2[i]));
            }

            return number;
        }
    }
}