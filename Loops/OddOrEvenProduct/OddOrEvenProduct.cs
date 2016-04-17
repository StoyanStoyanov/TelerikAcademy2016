namespace OddOrEvenProduct
{
    /*
        10. Odd and Even Product

        Description

        You are given N integers (given in a single line, separated by a space).

        Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

        Input

        On the first line you will receive the number N
        On the second line you will receive N numbers separated by a whitespace
        Output

        If the two products are equal, output a string in the format "yes PRODUCT_VALUE", 
        otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

        Constraints

        N will always be a valid integer number in the range [4, 50]
        All input numbers from the second line will also be valid integers
        Time limit: 0.1s
        Memory limit: 16MB
        1 2 3 4 5 
        0123456789
    */

    using System;

    public class OddOrEvenProduct
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');

            long evenProduct = 1, oddProduct = 1;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(input[i]);
                if (((i + 1) & 1) == 0)
                {
                    evenProduct *= number;
                }
                else
                {
                    oddProduct *= number;
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}