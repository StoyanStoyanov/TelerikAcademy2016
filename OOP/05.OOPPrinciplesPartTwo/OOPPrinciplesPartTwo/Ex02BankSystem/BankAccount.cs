namespace Ex02BankSystem
{
    using System.Text;

    public abstract class BankAccount
    {
        protected BankAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; protected set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; protected set; }

        public virtual decimal CalculateInterestAmount(uint numberOfMonths)
        {
            return this.InterestRate * numberOfMonths;
        }

        public override string ToString()
        {
            var accountInfo = new StringBuilder();

            accountInfo.AppendFormat("Account type:    {0}\n", this.GetType().Name);
            accountInfo.AppendFormat("Account holder:  {0}\n", this.Customer);
            accountInfo.AppendFormat("Account balance: {0}\n", this.Balance);
            accountInfo.AppendFormat("Account interest rate: {0}\n", this.InterestRate);
            accountInfo.AppendFormat("Account details: {0}", this is DepositAccount ? "Withdraw and Deposit" : "Deposit only");

            return accountInfo.ToString();
        }
    }
}