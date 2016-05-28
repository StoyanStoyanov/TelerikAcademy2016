namespace Ex02EnterNumbers
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/07.%20Exception-Handling/homework/02.%20Enter%20numbers

    using System;
    using System.Text;

    public class Ex02EnterNumbers
    {
        public static void Main()
        {
            var start = 1;
            var end = 100;

            var output = new StringBuilder();
            output.Append(start);

            for (int i = 0; i < 10; i++)
            {
                output.Append(" < ");
                int num;
                try
                {
                    num = ReadNumberInRange(start, end);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Exception");
                    return;
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("Exception");
                    return;
                }

                output.Append(num);
                start = num;
            }

            output.Append(" < ");
            output.Append(end);

            Console.WriteLine(output);
        }

        private static int ReadNumberInRange(int start, int end)
        {
            var n = int.Parse(Console.ReadLine());

            if (start >= n || n >= end)
            {
                throw new ArgumentException();
            }

            return n;
        }
    }
}