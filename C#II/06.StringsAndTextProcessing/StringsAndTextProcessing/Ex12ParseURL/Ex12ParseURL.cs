namespace Ex12ParseURL
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/12.%20Parse%20URL

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