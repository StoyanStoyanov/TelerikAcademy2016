namespace Ex01AllocateArray
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/01.%20Allocate%20array

    using System;

    public class Ex01AllocateArray
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                array[i] = i * 5;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}