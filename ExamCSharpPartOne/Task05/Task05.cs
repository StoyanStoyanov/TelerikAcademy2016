namespace Task05
{
    using System;
    using System.Collections.Generic;

    public class Task05
    {
        public static void Main()
        {
            var head = uint.Parse(Console.ReadLine());
            var numberOfCombs = uint.Parse(Console.ReadLine());

            var winners = new List<uint>();
            bool haveEqual = false;

            //var bitCounts = new List<int>();
            var maxCount = 0;
            uint winner = 0;
            var positionOfLastSetBitHead = 0;

            for (int i = 31; i >= 0; i--)
            {
                if (((head & (1 << i)) >> i) == 1)
                {
                    positionOfLastSetBitHead = i;
                    break;
                }
            }

            for (int comb = 0; comb < numberOfCombs; comb++)
            {
                var currentComb = uint.Parse(Console.ReadLine());
                var positionOfLastSetBit = 0;

                for (int i = 31; i >= 0; i--)
                {
                    if (((currentComb & (1 << i)) >> i) == 1)
                    {
                        positionOfLastSetBit = i;
                        break;
                    }
                }

                var isUsable = true;
                var rangeToCheck = positionOfLastSetBitHead > positionOfLastSetBit ? positionOfLastSetBit : positionOfLastSetBitHead;
                for (int p = 0; p < rangeToCheck + 1; p++)
                {
                    var bitInHead = (head & (1 << p)) >> p;
                    var bitInCurrComb = (currentComb & (1 << p)) >> p;
                    if ((bitInHead ^ bitInCurrComb) == 0)
                    {
                        isUsable = false;
                        break;
                    }
                }

                if (isUsable)
                {
                    var count = CountSetBits(positionOfLastSetBit, currentComb);
                    if (maxCount <= count)
                    {
                        //if (maxCount == count)
                        //{
                        //    haveEqual = true;
                        //    winners.Add(currentComb);
                        //}

                        maxCount = count;
                        winner = currentComb;
                    }

                    //usableCombs.Add(currentComb);
                    //bitCounts.Add();
                }
            }



            //for (int i = 0; i < usableCombs.Count; i++)
            //{
            //    if (bitCounts[i] > maxCount)
            //    {
            //        maxCount = bitCounts[i];
            //        winnerIndex = i;
            //    }
            //}

            //if (haveEqual)
            //{
            //    Console.WriteLine(winners[0]);
            //}
            //else
            //{
                Console.WriteLine(winner);
            //}
        }

        private static int CountSetBits(int rangeToCheck, uint number)
        {
            var numberOfSetBits = 0;

            for (int p = 0; p < rangeToCheck + 1; p++)
            {
                if ((number & (1 << p)) != 0)
                {
                    numberOfSetBits++;
                }
            }

            return numberOfSetBits;
        }
    }
}