namespace Ex11BankAccountData
{
    /* 
        11. A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
        bank name, IBAN, 3 credit card numbers associated with the account. 
        Declare the variables needed to keep the information for a single bank account 
        using the appropriate data types and descriptive names. 
    */

    using System;
    using System.Collections.Generic;

    public class BankAccountData
    {
        public static void Main()
        {
            string firstName = "Tosho";
            string middleName = "Toshev";
            string lastName = "Toshev";

            decimal balance = 550000M;
            string iban = "BG3434BDDTTDDWDNSDN";
            List<string> creditCardNumbers = new List<string> { "ffh22434434314", "4h3j4h34h44343h43", "jffdfdfd34341421jd"};

            Console.WriteLine("Account holder first name: {0}", firstName);
            Console.WriteLine("Account holder middle name: {0}", middleName);
            Console.WriteLine("Account holder last name: {0}", lastName);
            Console.WriteLine("Account holder balance: {0}", balance);
            Console.WriteLine("Account holder iban: {0}", iban);

            Console.WriteLine("Account holder card numbers:");
            foreach (var cardNum in creditCardNumbers)
            {
                Console.WriteLine(cardNum);
            }
        }
    }
}
