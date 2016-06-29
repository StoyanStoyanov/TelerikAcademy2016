namespace Ex02BankSystem
{
    using System;

    public class MortgageAccount : BankAccount, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        { }

        public void Deposit(decimal money)
        {
            if (money < 0) throw new ArgumentException("Unable to deposit a negative amount of money.");

            this.Balance += money;
        }

        public override decimal CalculateInterestAmount(uint months)
        {
            if (this.Customer is Company)
            {
                return months < 13 ? (months * InterestRate) / 2 : ((12 * InterestRate) / 2) + ((months - 12) * InterestRate);
            }
           
            return months < 7 ? 0 : (months - 6) * this.InterestRate;
        }
    }
}