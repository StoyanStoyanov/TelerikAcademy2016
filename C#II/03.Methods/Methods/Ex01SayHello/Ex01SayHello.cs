namespace Ex01SayHello
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/01.%20Say%20Hello

    using System;

    public class Ex01SayHello
    {
        public static void Main()
        {
            var name = ReadName();

            SayHello(name);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        private static string ReadName()
        {
            return Console.ReadLine();
        }
    }
}