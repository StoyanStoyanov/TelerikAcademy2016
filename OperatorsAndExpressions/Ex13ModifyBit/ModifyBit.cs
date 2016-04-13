namespace Ex13ModifyBit
{
    using System;

    public class ModifyBit
    {
        static void Main()
        {
            var number = ulong.Parse(Console.ReadLine());
            var targetBitPosition = byte.Parse(Console.ReadLine());
            var newBitValue = byte.Parse(Console.ReadLine());

            var mask = 1UL << targetBitPosition;
            var currentBitValue = (number & mask) >> targetBitPosition;

            Console.WriteLine(currentBitValue != newBitValue ? number ^= mask : number);
        }
    }
}