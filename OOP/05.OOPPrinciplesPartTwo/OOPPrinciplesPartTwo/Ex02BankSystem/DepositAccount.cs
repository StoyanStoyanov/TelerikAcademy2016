namespace Ex02BankSystem
{
    using System;

    public class DepositAccount : BankAccount, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        { }

        public void Withdraw(decimal money)
        {
            if (money < 0)
            { 
                throw new ArgumentException("Unable to withdraw a negative amount of money.");
            }

            this.Balance -= money;
        }

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
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0.0M;
            }

            return base.CalculateInterestAmount(numberOfMonths);
        }
    }
}