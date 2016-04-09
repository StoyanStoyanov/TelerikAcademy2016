namespace Ex12NullValuesArithmetic
{
    /*  
        12. Create a program that assigns null values to an integer and to a double variable.
        Try to print these variables at the console.
        Try to add some number or the null literal to these variables and print the result.
    */

    using System;

    public class NullValuesArithmetic
    {
        public static void Main()
        {
            int? nullableInteger = null;
            double? nullableDouble = null;

            Console.WriteLine(nullableInteger);
            Console.WriteLine(nullableDouble);

            Console.WriteLine(nullableInteger + 5);
            Console.WriteLine(nullableDouble + 5);

            Console.WriteLine(nullableInteger + nullableInteger);
            Console.WriteLine(nullableDouble + nullableDouble);
        }
    }
}
