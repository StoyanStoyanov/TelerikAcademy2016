namespace Devices
{
    public class Battery
    {
        public Battery(string model, uint? hoursIdle = null, uint? hoursTalk = null, BatteryType batteryType = 0)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model { get; set; }

        public uint? HoursIdle { get; set; }

        public uint? HoursTalk { get; set; }

        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            return string.Format("[Model: {0}, Type: {1}]", this.Model, this.BatteryType);
        }
    }
}