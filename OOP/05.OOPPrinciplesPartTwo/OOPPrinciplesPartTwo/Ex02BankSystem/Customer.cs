namespace Ex02BankSystem
{
    public abstract class Customer
    {
        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}