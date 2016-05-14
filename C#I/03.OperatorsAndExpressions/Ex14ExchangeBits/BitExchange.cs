namespace Ex14BitExchange
{
    // 14. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

    using System;

    public class BitExchange
    {
        public static void Main()
        {
            var n = ulong.Parse(Console.ReadLine());

            byte[] rightPositions = { 3, 4, 5 };
            byte[] leftPositions = { 24, 25, 26 };

            for (int i = 0; i < 3; i++)
            {
                n = SwapBits(rightPositions[i], leftPositions[i], n);
            }

            Console.WriteLine(n);
        }

        private static ulong SwapBits(byte firstBitPosition, byte secondBitPosition, ulong number)
        {
            var x = ((number >> firstBitPosition) ^ (number >> secondBitPosition)) & 1;

            return number ^ ((x << firstBitPosition) | (x << secondBitPosition));
        }
    }
}