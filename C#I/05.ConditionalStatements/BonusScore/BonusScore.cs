namespace BonusScore
{
    /*  02.
        Description

        Write a program that applies bonus score to given score in the range [1…9] by the following rules:

        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is less than 0 or more than 9, the program prints "invalid score".
        Input

        The only input line will contain one integer number - the score
        Output

        Output the score with the applied bonus
        Constraints

        The score will always be a valid integer number
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class BonusScore
    {
        public static void Main()
        {
            var score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(score *= 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(score *= 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(score *= 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}