namespace Ex02BankSystem
{
    /* 
     * Exercise 02. 
     * 
     * A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
     * Customers could be individuals or companies.All accounts have customer, balance and interest rate (monthly based).
     * 
     * Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
     * All accounts can calculate their interest amount for a given period (in months). 
     * In the common case its is calculated as follows: number_of_months * interest_rate.
     * 
     * Loan accounts have no interest for the first 3 months if are held by individuals and 
     * for the first 2 months if are held by a company.
     * Deposit accounts have no interest if their balance is positive and less than 1000.
     * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
     * 
     * Your task is to write a program to model the bank system by classes and interfaces. 
     * You should identify the classes, interfaces, base classes and abstract actions 
     * and implement the calculation of the interest functionality through overridden methods.
     * 
     */

    using System;

    public class BankSystem
    {
        public static void Main()
        {
            try
            {
                var accounts = new BankAccount[] 
                { 
                    // This account type has no interest if balance is positive and less than 1000
                    new DepositAccount(new Individual("George Georgiev"), 1000M, 0.3M),
                    new DepositAccount(new Company("GoshoSoft"), 600M, 0.2M),

                    // This account type has no interest for the first 3 months if held by individuals and 
                    // for the first 2 months if held by a company.
                    new LoanAccount(new Individual("Alexander Alexandrov"), 2000M, 0.6M),
                    new LoanAccount(new Company("M-Trade EOOD"), 10000M, 0.5M),

                    // This account type has ½ interest for the first 12 months for companies and
                    // no interest for the first 6 months for individuals
                    new MortgageAccount(new Individual("Peter Petrov"), 100000M, 0.6M),
                    new MortgageAccount(new Company("Lutiche EOOD"), 5000M, 0.7M),
                };

                foreach (var account in accounts)
                {
                    Console.WriteLine(account);
                    Console.WriteLine("Account interest amount for 2 months: {0}.", account.CalculateInterestAmount(2));
                    Console.WriteLine("Account interest amount for 3 months: {0}.", account.CalculateInterestAmount(3));
                    Console.WriteLine("Account interest amount for 6 months: {0}.", account.CalculateInterestAmount(6));
                    Console.WriteLine("Account interest amount for 12 months: {0}.", account.CalculateInterestAmount(12));
                    Console.WriteLine("Account interest amount for 24 months: {0}.", account.CalculateInterestAmount(24));

                    Console.WriteLine();
                }
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}