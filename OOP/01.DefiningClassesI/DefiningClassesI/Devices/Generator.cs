namespace Devices.Utils
{
    using System;
    using System.Text;

    public static class Generator
    {
        /*
         *             Random gen = new Random();

         **/
        private static readonly Random gen = new Random();

        public static DateTime GetRandomDateTime(DateTime start, DateTime end)
        {
            var randomDateTime = start;
            var range = end - start;

            randomDateTime = randomDateTime.AddDays(gen.Next(range.Days));
            randomDateTime = randomDateTime.AddHours(gen.Next(range.Hours));
            randomDateTime = randomDateTime.AddMinutes(gen.Next(range.Minutes));
            randomDateTime = randomDateTime.AddSeconds(gen.Next(range.Seconds));

            return randomDateTime;
        }

        public static string GetRandomBGNumber()
        {
            var randomBGnumber = new StringBuilder();
            var countryCode = "359";
            var startDigit = "8";

            randomBGnumber.Append(countryCode);
            randomBGnumber.Append(startDigit);
            randomBGnumber.Append(gen.Next(7, 10));

            for (int i = 0; i < 7; i++)
            {
                randomBGnumber.Append(gen.Next(0, 10));
            }

            return randomBGnumber.ToString();
        }

        public static uint GetRandomDuration()
        {
            var duration = gen.Next(0, int.MaxValue);
            return (uint)duration;
        }
    }
}