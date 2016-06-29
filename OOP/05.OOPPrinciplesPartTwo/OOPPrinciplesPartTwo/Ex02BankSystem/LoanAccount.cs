namespace Ex02BankSystem
{
    using System;

    public class LoanAccount : BankAccount, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        { }

        public void Deposit(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Unable to deposit a negative amount of money.");
            }

            this.Balance += money;
        }

        public override decimal CalculateInterestAmount(uint numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                return numberOfMonths < 4 ? 0 : (numberOfMonths - 3) * this.InterestRate;
            }

            return numberOfMonths < 3 ? 0 : (numberOfMonths - 2) * this.InterestRate;
        }
    }
}