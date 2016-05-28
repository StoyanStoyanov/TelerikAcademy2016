namespace Ex01SquareRoot
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/07.%20Exception-Handling/homework/01.%20Square%20root

    using System;

    public class Ex01SquareRoot
    {
        public static void Main()
        {
            try
            {
                var number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:F3}", Math.Sqrt(number));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}