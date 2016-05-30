namespace Ex04VariableLengthCoding
{
    // http://bgcoder.com/Contests/Practice/Index/142#3
    // 100/100

    using System;
    using System.Linq;

    public class Ex04VariableLengthCoding
    {
        public static void Main()
        {
            var code = string.Join("", Console.ReadLine()
                .Split()
                .Select(n => Convert.ToString(byte.Parse(n), 2).PadLeft(8, '0'))
            )
            .Split(new[] { '0' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Length);

            var numberOfLines = int.Parse(Console.ReadLine());
            var reverseTable = new char[numberOfLines + 1];
            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();
                var index = int.Parse(line.Substring(1));
                var ch = line[0];
                reverseTable[index] = ch;
            }

            Console.WriteLine(code.Select(x => reverseTable[x]).ToArray());
        }
    }
}