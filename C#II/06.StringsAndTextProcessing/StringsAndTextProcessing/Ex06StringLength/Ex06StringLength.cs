namespace Ex06StringLength
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/06.%20String%20length

    using System;

    public class Ex06StringLength
    {
        public static void Main()
        {
            Console.Write(Console.ReadLine().Replace("\\", "").PadRight(20, '*'));
        }
    }
}