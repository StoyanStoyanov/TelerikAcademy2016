namespace Ex02CompareArrays
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/02.%20Compare%20arrays

    using System;

    public class Ex02CompareArrays
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            var firstArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            var secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            var equal = true;
            for (int i = n - 1; i >= 0; i--)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }

            Console.WriteLine(equal ? "Equal" : "Not equal");
        }
    }
}