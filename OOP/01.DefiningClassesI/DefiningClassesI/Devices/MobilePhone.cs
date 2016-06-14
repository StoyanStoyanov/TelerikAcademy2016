namespace Devices
{
    using System.Linq;
    using System.Collections.Generic;

    public class MobilePhone : Device
    {
        public static readonly IPhone4S IPhone4S = new IPhone4S(1600, "Pesho");

        private readonly List<Call> callHistory;

        public MobilePhone(string model, string manufacturer, uint? price = null, string owner = null, Display display = null, Battery battery = null)
            : base(model, manufacturer, price, owner)
        {
            this.callHistory = new List<Call>();
            this.Display = display;
            this.Battery = battery;
        }

        public Display Display { get; set; }

        public Battery Battery { get; set; }

        public void AddCall(Call call) 
        {
            this.callHistory.Add(call);
        }

        public void AddCalls(Call[] calls)
        {
            this.callHistory.Concat(calls);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            this.callHistory.RemoveAt(callIndex);
        }

        public Call[] GetCallHistory()
        {
            return (Call[]) this.callHistory
                .Select(c => c.Copy())
                .ToArray()
                .Clone();

            //var copy = new Call[this.callHistory.Count];

            //this.callHistory.Select(c => c.Copy()).ToArray().CopyTo(copy, 0);

            //return copy;
        }

        public string GetCallHistoryInfo()
        {
            return string.Join("\n", this.callHistory);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateCallsTotalCost(decimal pricePerMinute)
        {
            decimal cost = 0;

            foreach (var call in this.callHistory)
            {
                var minutes = call.Duration / 60;
                cost += minutes * pricePerMinute;
            }

            return cost;
        }
    }
}