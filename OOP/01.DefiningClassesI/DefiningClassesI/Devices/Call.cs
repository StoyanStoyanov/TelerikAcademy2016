namespace Devices
{
    using System;

    public class Call : IComparable
    {
        public Call(string number, DateTime startTime, uint duration)
        {
            this.StartTime = startTime;
            this.Number = number;
            this.Duration = duration;
        }

        public string Number { get; set; }

        public DateTime StartTime { get; set; }

        public uint Duration { get; set; }

        public DateTime EndTime
        {
            get
            {
                return this.StartTime.AddSeconds(this.Duration);
            }
        }

        public int CompareTo(object obj)
        {
            var otherCall = obj as Call;

            if (otherCall == null)
            {
                throw new ArgumentException();
            }

            return this.Duration.CompareTo(otherCall.Duration);
        }

        public Call Copy()
        {
            return (Call)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Call:\nNumber: {this.Number}\nStart: {this.StartTime}\nDuration: {this.Duration}\nEnd: {this.EndTime}\n";
        }
    }
}