namespace PrintDeck
{
    /*
        04. Print a Deck

        Description

        Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards
        up to the card with the given sign(without the jokers). 
        The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
        Input

        On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
        Output

        The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds 
        Constraints

        The input character will always be a valid card sign.
        Time limit: 0.1s
        Memory limit: 16MB
    */

    using System;
    using System.Text;

    public class PrintDeck
    {
        public static void Main()
        {
            var faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var suits = new string[] { "spades", "clubs",  "hearts", "diamonds" };
            var stopFace = Console.ReadLine();
            var output = new StringBuilder();

            for (int f = 0, numberOfFaces = faces.Length; f < numberOfFaces; f++)
            {
                var currentCardFace = faces[f];
                for (int s = 0, numberOfSuits = suits.Length; s < numberOfSuits; s++)
                {
                    var currentCardSuit = suits[s];
                    output.Append(currentCardFace);
                    output.Append(" of ");
                    output.Append(currentCardSuit);
                    output.Append(s != numberOfSuits - 1 ? ", " : "\n");
                }

                if (currentCardFace == stopFace)
                {
                    break;
                }
            }

            Console.Write(output);
        }
    }
}