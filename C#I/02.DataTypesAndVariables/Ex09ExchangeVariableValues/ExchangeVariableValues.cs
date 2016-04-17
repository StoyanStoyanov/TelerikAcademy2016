namespace Ex09ExchangeVariableValues
{
    // 09. Declare two integer variables a and b and assign them with 5 and 10 and after that 
    // exchange their values by using some programming logic. Print the variable values before and after the exchange.

    using System;

    public class ExchangeVariableValues
    {
        static void Main()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a bits: {0}", Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b bits: {0}", Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine();

            a ^= b;
            Console.WriteLine("a bits: {0}", Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b bits: {0}", Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine();

            b ^= a;
            Console.WriteLine("a bits: {0}", Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b bits: {0}", Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine();

            a ^= b;
            Console.WriteLine("a bits: {0}", Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b bits: {0}", Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
