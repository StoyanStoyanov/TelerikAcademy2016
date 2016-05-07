namespace Ex03CompareCharArrays
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/03.%20Compare%20char%20arrays

    using System;

    public class Ex03CompareCharArrays
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();
            var firstStringLen = firstString.Length;
            var secondStringLen = secondString.Length;
            var length = firstStringLen > secondStringLen ? secondStringLen : firstStringLen;

            for (int i = 0; i < length; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    Console.WriteLine(">");
                    return;
                }
                else if (firstString[i] < secondString[i])
                {
                    Console.WriteLine("<");
                    return;
                }
            }

            if (firstStringLen > secondStringLen)
            {
                Console.WriteLine(">");
            }
            else if (firstStringLen < secondStringLen)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}