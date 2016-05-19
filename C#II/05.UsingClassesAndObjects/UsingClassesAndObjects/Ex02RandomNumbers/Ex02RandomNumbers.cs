namespace Ex02RandomNumbers
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/05.%20Using-Classes-and-Objects/homework/02.%20Random%20numbers

    using System;

    public class Ex02RandomNumbers
    {
        public static void Main()
        {
            var min = 100;
            var max = 200;
            var amount = 10;

            var randoms = GenerateRandomNumbers(min, max, amount);

            foreach (var random in randoms)
            {
                Console.WriteLine(random);
            }
        }

        private static int[] GenerateRandomNumbers(int min, int max, int amount)
        {
            var randoms = new int[amount];
            var gen = new Random();

            for (int i = amount - 1; i >= 0; i--)
            {
                randoms[i] = gen.Next(min, max + 1);
            }

            return randoms;
        }
    }
}