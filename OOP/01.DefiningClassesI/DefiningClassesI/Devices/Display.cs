namespace Devices
{
    public class Display
    {
        public Display(ushort width, ushort height, uint? numberOfColors)
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfColors = numberOfColors;
        }

        public ushort Width { get; set; }

        public ushort Height { get; set; }
        
        public uint? NumberOfColors { get; set; }

        public int? Size
        {
            get
            {
                return this.Width * this.Height;
            }
        }

        public override string ToString()
        {
            return string.Format("[Size: {0}, Colors: {1}]", this.Size, this.NumberOfColors);
        }
    }
}