namespace Devices
{
    public class IPhone4S : MobilePhone
    {
        public IPhone4S(uint? price = null, string owner = null, Display display = null, Battery battery = null)
            : base("IPhone4S", "Apple", price, owner)
        {

        }
    }
}