namespace Ex11AddingPolynomials
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/03.%20Methods/homework/11.%20Adding%20polynomials

    using System;
    using System.Text;

    public class Ex11AddingPolynomials
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var pOneAsArray = ReadInputArray(n);
            var pTwoAsArray = ReadInputArray(n);

            var pResultAsArray = AddPolynomials(pOneAsArray, pTwoAsArray, n);

            Console.WriteLine(string.Join(" ", pResultAsArray));
        }

        private static int[] AddPolynomials(int[] pOneAsArray, int[] pTwoAsArray, int commonSize)
        {
            var result = new int[commonSize];

            for (int i = pOneAsArray.Length - 1; i >= 0; i--)
            {
                result[i] = pOneAsArray[i] + pTwoAsArray[i];
            }

            return result;
        }

        private static int[] ReadInputArray(int size)
        {
            var input = Console.ReadLine();

            var array = new int[size];
            var num = new StringBuilder();

            for (int i = 0, j = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (char.IsDigit(symbol) || symbol == '-')
                {
                    num.Append(symbol);

                    if (i < input.Length - 1)
                    {
                        continue;
                    }
                }

                array[j++] = int.Parse(num.ToString());
                num.Clear();
            }

            return array;
        }
    }
}