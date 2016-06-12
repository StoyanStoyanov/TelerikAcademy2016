namespace Devices
{
    using System.Linq;
    using System.Text;

    public abstract class Device
    {
        protected Device(string model, string manufacturer, uint? price = null, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public uint? Price { get; set; }

        public string Owner { get; set; }

        public override string ToString()
        {
            var deviceInfo = new StringBuilder();
            var properties = this.GetType()
                .GetProperties()
                .OrderBy(p => p.Name);

            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    deviceInfo.Append(property.Name);
                    deviceInfo.Append(": ");
                    deviceInfo.Append(property.GetValue(this) ?? "N/A");
                    deviceInfo.AppendLine();
                }
            }

            return deviceInfo.ToString();
        }
    }
}