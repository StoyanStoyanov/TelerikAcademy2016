namespace Devices
{
    using System;

    public static class MobilePhoneTest
    {
        public static void Test()
        {
            var nokiaLumia930 = new MobilePhone("Lumia 930", "Nokia", 950, "Pesho", new Display(1080, 1920, 256000), new Battery("Toshiba", null, null, BatteryType.LiIon));
            var samsumGalaxyS5 = new MobilePhone("Galaxy S5", "Samsung");
            var iPhone4S = MobilePhone.IPhone4S;

            var phones = new MobilePhone[3] { nokiaLumia930, samsumGalaxyS5, iPhone4S };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine();
        }
    }
}