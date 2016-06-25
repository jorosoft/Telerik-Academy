namespace _02.BankAccounts.Models
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal ballance, decimal interestRate) 
            : base(customer, ballance, interestRate)
        {
        }

        public override decimal CalculateInterestAmmount(int months)
        {
            if (this.Owner.CustomerType == (CustomerType)0)
            {
                months -= 3;
            }

            if (this.Owner.CustomerType == (CustomerType)1)
            {
                months -= 2;
            }

            if (months < 0)
            {
                return 0;
            }

            return months * this.InterestRate;
        }
    }
}
