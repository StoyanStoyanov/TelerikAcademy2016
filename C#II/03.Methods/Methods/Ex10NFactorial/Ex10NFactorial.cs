namespace Ex10NFactorial
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/10.%20N%20Factorial

    using System;
    using System.Numerics;

    public class Ex10NFactorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var nFactorial = CalculateFactorial(n);

            Console.WriteLine(nFactorial);
        }

        private static BigInteger CalculateFactorial(int n)
        {
            var factorial = new BigInteger(1);

            for (var i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}