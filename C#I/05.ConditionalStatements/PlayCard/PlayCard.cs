namespace PlayCard
{
    /*
        Description

        Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.

        Input

        On the only line you will receive a single string.
        Output

        Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".
        Constraints

        String length will always be between 1 and 5
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;

    public class PlayCard
    {
        public static void Main()
        {
            string card = Console.ReadLine();
            string cards = "2,3,4,5,6,7,8,9,10,J,Q,K,A";

            Console.WriteLine("{0} {1}", cards.Contains(card) ? "yes" : "no", card);
        }
    }
}