namespace Ex12ParseURL
{
    using System;

    public class Ex12ParseURL
    {
        public static void Main()
        {
            var url = new Uri(Console.ReadLine());

            Console.WriteLine("[protocol] = {0}", url.Scheme);
            Console.WriteLine("[server] = {0}", url.DnsSafeHost);
            Console.WriteLine("[resource] = {0}", url.PathAndQuery);
        }
    }
}