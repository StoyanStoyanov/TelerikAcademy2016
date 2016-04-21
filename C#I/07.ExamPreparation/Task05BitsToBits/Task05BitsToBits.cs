namespace Task05BitsToBits
{
    // http://bgcoder.com/Contests/Practice/Index/202#4
    // 100/100

    using System;

    public class Task05BitsToBits
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            int onesCount = 0, onesMaxCount = 0, zeroesCount = 0, zeroesMaxCount = 0;
            int positions = 30;

            for (int num = 0; num < n; num++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                for (int p = positions - 1; p >= 0; p--)
                {
                    var currentBit = (currentNumber & (1 << p)) >> p;
                    if (currentBit == 0)
                    {
                        zeroesCount++;

                        if (onesCount > onesMaxCount)
                        {
                            onesMaxCount = onesCount;
                        }

                        onesCount = 0;
                    }
                    else if (currentBit == 1)
                    {
                        onesCount++;

                        if (zeroesCount > zeroesMaxCount)
                        {
                            zeroesMaxCount = zeroesCount;
                        }

                        zeroesCount = 0;
                    }
                }
            }

            if (zeroesCount > zeroesMaxCount)
            {
                zeroesMaxCount = zeroesCount;
            }

            if (onesCount > onesMaxCount)
            {
                onesMaxCount = onesCount;
            }

            Console.WriteLine(zeroesMaxCount);
            Console.WriteLine(onesMaxCount);
        }
    }
}