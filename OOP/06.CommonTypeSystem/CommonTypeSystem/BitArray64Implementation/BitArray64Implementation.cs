namespace BitArray64Implementation
{
    using System;

    // Define a class BitArray64 to hold 64 bit values inside an ulong value. 
    // Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

    public class BitArray64Implementation
    {
        public static void Main()
        {
            try
            {
                // Create some instances of the BitArray64 class
                var arr = new BitArray64(155);
                var arr1 = new BitArray64(155);
                
                // Print the first instance's Value and Length, and print the instance itself
                Console.WriteLine("arr.Value: {0}", arr.Value);
                Console.WriteLine("arr.Length: {0}", arr.Length);
                Console.WriteLine("BitArray64(Value): {0}", arr);

                Console.WriteLine();

                // Print the second instance's Value and Length, and print the instance itself
                Console.WriteLine("arr1.Value: {0}", arr1.Value);
                Console.WriteLine("arr1.Length: {0}", arr1.Length);
                Console.WriteLine("BitArray64(Value): {0}", arr1);

                Console.WriteLine();

                // Check if the two instances are equal
                Console.WriteLine("Is arr equal to arr1? {0}", arr.Equals(arr1));
                Console.WriteLine("arr == arr1? {0}", arr == arr1);
                Console.WriteLine("arr != arr1? {0}", arr != arr1);

                Console.WriteLine("\nLet's change only the first BitArray64 (arr).\n");

                // Change some of the "bits" of the first array
                arr[3] = 0;
                Console.WriteLine("arr after bit at position 3 is changed to zero: {0}", arr);
                Console.WriteLine("The new inner value of arr is {0}", arr.Value);

                Console.WriteLine();

                arr[50] = 1;
                Console.WriteLine("arr after bit at position 50 is changed to one: {0}", arr);
                Console.WriteLine("The new inner value of arr is {0}", arr.Value);

                Console.WriteLine();

                // Each of the next two lines of code throw an exception
                // arr[-1] = 0;
                // arr[3] = 50;

                // Let's check again whether the two instances are equal
                Console.WriteLine("Is arr equal to arr1? {0}", arr.Equals(arr1));
                Console.WriteLine("arr == arr1? {0}", arr == arr1);
                Console.WriteLine("arr != arr1? {0}", arr != arr1);
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
