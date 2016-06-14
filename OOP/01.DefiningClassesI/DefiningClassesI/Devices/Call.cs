namespace Devices
{
    using System;

    public class Call : IComparable<Call>
    {
        public Call(string number, DateTime startTime, uint duration)
        {
            this.Number = number;
            this.StartTime = startTime;
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

        public int CompareTo(Call other)
        {
            return this.Duration.CompareTo(other.Duration);
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