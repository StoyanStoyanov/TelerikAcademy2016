namespace Ex02GetLargestNumber
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/02.%20Get%20largest%20number

    using System;
    using System.Linq;

    public class Ex02GetLargestNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            var num1 = numbers[0];
            var num2 = numbers[1];
            var num3 = numbers[2];

            var max = GetMax(GetMax(num1, num2), num3);

            Console.WriteLine(max);
        }

        private static int GetMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}