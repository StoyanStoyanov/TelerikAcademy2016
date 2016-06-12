namespace Devices
{
    using System;
    using Utils;
    using System.Linq;

    public static class MobilePhoneCallHistoryTest
    {
        private const decimal PricePerMinute = 0.37M;
        private static readonly DateTime beginningOfTime = new DateTime(1970, 1, 1, 12, 42, 42);

        public static void Test()
        {
            var phone = new MobilePhone("G5", "Lenovo", 1600, "Tosho");

            for (int i = 0; i < 10; i++)
            {
                var number = Generator.GetRandomBGNumber();
                var callStart = Generator.GetRandomDateTime(beginningOfTime, DateTime.Today);
                var duration = Generator.GetRandomDuration();
                var call = new Call(number, callStart, duration);

                phone.AddCall(call);
            }

            Console.WriteLine("======================= All calls in the call history =======================");
            Console.WriteLine(phone.GetCallHistoryInfo());
            Console.WriteLine("======================= End of calls in the call history =======================");

            var totalPriceOfCalls = phone.CalculateCallsTotalCost(PricePerMinute);
            Console.WriteLine("Total price of the calls in the call history: {0}", totalPriceOfCalls);

            Console.WriteLine();

            var callHistory = phone.GetCallHistory();

            var longestCall = callHistory.Max();

            Console.WriteLine("Longest call details:\n{0}", longestCall);

            var indexOfLongestCall = Array.IndexOf(callHistory, longestCall);
            phone.DeleteCall(indexOfLongestCall);
            
            var totalPriceExcludingLongestCall = phone.CalculateCallsTotalCost(PricePerMinute);

            Console.WriteLine("Total price after excluding longest call: {0}", totalPriceExcludingLongestCall);

            Console.WriteLine("\nCalls after excluding the longest call from the call history:");

            Console.WriteLine("======================= All calls in the call history =======================");
            Console.WriteLine(phone.GetCallHistoryInfo());
            Console.WriteLine("======================= End of calls in the call history =======================");

            phone.ClearCallHistory();

            Console.WriteLine("\nCalls after clearing the call history:");

            Console.WriteLine("======================= All calls in the call history =======================");
            Console.WriteLine(phone.GetCallHistoryInfo());
            Console.WriteLine("======================= End of calls in the call history =======================");
        }
    }
}