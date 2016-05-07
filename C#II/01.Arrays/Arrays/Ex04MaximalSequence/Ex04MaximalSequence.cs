namespace Ex04MaximalSequence
{
    // https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/01.%20Arrays/homework/04.%20Maximal%20sequence

    using System;

    public class Ex04MaximalSequence
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var previousElement = int.Parse(Console.ReadLine());
            int currentElement, count = 1, maxCount = 1;

            for (int i = n - 2; i >= 0; i--)
            {
                currentElement = int.Parse(Console.ReadLine());
                if (previousElement == currentElement)
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    previousElement = currentElement;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}