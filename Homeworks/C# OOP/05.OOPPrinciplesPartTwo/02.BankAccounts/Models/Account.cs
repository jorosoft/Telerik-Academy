namespace _02.BankAccounts.Models
{
    public abstract class Account
    {
        public Account(Customer customer, decimal ballance, decimal interestRate)
        {
            this.Owner = customer;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
        }

        public Customer Owner { get; set; }

        public decimal Ballance { get; set; }

        public decimal InterestRate { get; set; }

        public void DepositMoney(decimal ammount)
        {
            this.Ballance += ammount;
        }

        public abstract decimal CalculateInterestAmmount(int months);       
    }
}
