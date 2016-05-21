namespace Ex06StringLength
{
    using System;

    public class Ex06StringLength
    {
        public static void Main()
        {
            Console.Write(Console.ReadLine().Replace("\\", "").PadRight(20, '*'));
        }
    }
}